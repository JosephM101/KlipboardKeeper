using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlipboardKeeper
{
    public class SynchronizedBindingList<T> : BindingList<T>
    {
        private List<T> mirroredList = new List<T>();

        protected override void InsertItem(int index, T item)
        {
            base.InsertItem(index, item);
            mirroredList.Insert(index, item);
        }

        protected override void RemoveItem(int index)
        {
            base.RemoveItem(index);
            mirroredList.RemoveAt(index);
        }

        protected override void SetItem(int index, T item)
        {
            base.SetItem(index, item);
            mirroredList[index] = item;
        }

        protected override void ClearItems()
        {
            base.ClearItems();
            mirroredList.Clear();
        }

        protected override void OnListChanged(ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset)
            {
                // If the list is reset, update the mirrored copy entirely
                mirroredList = new List<T>(this);
            }
            else
            {
                // Handle other list change events
                // Update the mirrored copy accordingly
                if (e.NewIndex >= 0 && e.NewIndex < mirroredList.Count)
                {
                    mirroredList[e.NewIndex] = this[e.NewIndex];
                }
            }

            base.OnListChanged(e);
        }

        public List<T> GetMirroredList()
        {
            return mirroredList;
        }
    }
}
