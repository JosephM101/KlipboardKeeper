using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KlipboardKeeper.IconApp;

namespace KlipboardKeeper.Forms
{
    public partial class ClipboardHistoryWindow : Form
    {
        public BindingList<ClipboardItem> clipboardHistory { get; set; }

        public ClipboardHistoryWindow()
        {
            InitializeComponent();
        }

        private ClipboardItem GetSelectedItemFromDataGridView()
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < clipboardHistory.Count)
                {
                    return clipboardHistory[selectedIndex];
                }
            }

            return default;
        }

        private List<ClipboardItem> GetSelectedItemsFromDataGridView()
        {
            List<ClipboardItem> items = new List<ClipboardItem>();
            if (dataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
                {
                    int selectedIndex = dataGridView.SelectedRows[i].Index;
                    if (selectedIndex >= 0 && selectedIndex < clipboardHistory.Count)
                    {
                        items.Add(clipboardHistory[selectedIndex]);
                    }
                }
            }

            return items;
        }

        private void menuItem_closeWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClipboardHistoryWindow_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = clipboardHistory;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count < 1)
            {
                toolStripButton_editSelectedItem.Enabled = false;
                toolStripButton_copySelectedItem.Enabled = false;
                toolStripButton_deleteSelectedItem.Enabled = false;
            }
            else if (dataGridView.SelectedRows.Count > 1)
            {
                toolStripButton_editSelectedItem.Enabled = false;
                toolStripButton_copySelectedItem.Enabled = false;
                toolStripButton_deleteSelectedItem.Enabled = true;
            }
            else
            {
                toolStripButton_editSelectedItem.Enabled = true;
                toolStripButton_copySelectedItem.Enabled = true;
                toolStripButton_deleteSelectedItem.Enabled = true;
            }

            if (dataGridView.SelectedRows.Count == 1)
            {
                temp_selectedGuid = GetSelectedItemFromDataGridView().Guid;
            }
        }

        private void toolStripButton_copySelectedItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                Debug.WriteLine("Copied selected item to clipboard");
                ClipboardItem selectedItem = GetSelectedItemFromDataGridView();
                Clipboard.SetText(selectedItem.Text);
            }
        }

        private void toolStripButton_deleteSelectedItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                List<ClipboardItem> selectedItems = GetSelectedItemsFromDataGridView();
                DialogResult result = MessageBox.Show(
                    $"You are about to delete {selectedItems.Count} item(s). Are you sure?",
                    "Clipboard History",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (result == DialogResult.Yes)
                {
                    foreach(ClipboardItem selectedItem in selectedItems)
                    {
                        Debug.WriteLine(selectedItem.Guid.ToString());
                        clipboardHistory.Remove(selectedItem);
                    }
                }
            }
        }

        private void toolStripButton_editSelectedItem_Click(object sender, EventArgs e)
        {
            OpenEditWindow();
        }

        private void OpenEditWindow()
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                ClipboardItem selectedItem = GetSelectedItemFromDataGridView();
                EditItemWindow editItemWindow = new EditItemWindow(selectedItem);
                editItemWindow.TopMost = this.TopMost;
                editItemWindow.ShowDialog();
                if (editItemWindow.saved)
                {
                    clipboardHistory.Where(item => item.Guid == editItemWindow.clipboardItem.Guid).First().Text = editItemWindow.textBox.Text;
                }
            }
        }

        private void menuItem_deselectAll_Click(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }


        Guid temp_selectedGuid = Guid.Empty;
        private void statusStripUpdater_Tick(object sender, EventArgs e)
        {
            string items_suffix = dataGridView.RowCount == 1 ? "" : "s";
            int selectedCount = dataGridView.SelectedRows.Count;

            string s_part1 = $"{dataGridView.RowCount} item{items_suffix}";
            string s_part2 = (selectedCount > 0) ? $", {selectedCount} selected" : "";

            toolStripStatusLabel_itemCount.Text = $"{s_part1}{s_part2}";

            if (selectedCount > 0)
            {
                if (selectedCount == 1)
                {
                    toolStripStatusLabel_selectedGuid.Text = temp_selectedGuid.ToString();
                }
                else
                {
                    toolStripStatusLabel_selectedGuid.Text = "Multiple selected";
                }
            }
            else
            {
                toolStripStatusLabel_selectedGuid.Text = "";
            }
        }

        private void ClipboardHistoryWindow_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                dataGridView.ClearSelection();
            }
        }

        private void menuItem_clearAllHistory_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are about to erase your entire clipboard history. \n" +
                                                  "THIS CANNOT BE UNDONE!\n" +
                                                  "\n" +
                                                  "Are you sure you want to do this?",
                                                  "Clear history?", 
                                                  MessageBoxButtons.YesNo, 
                                                  MessageBoxIcon.Question,
                                                  MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                clipboardHistory.Clear();
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenEditWindow();
        }
    }
}