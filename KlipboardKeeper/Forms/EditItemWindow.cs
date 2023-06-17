using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KlipboardKeeper.IconApp;

namespace KlipboardKeeper.Forms
{
    public partial class EditItemWindow : Form
    {
        public bool saved = false;
        bool skipExitMessage = false;
        public ClipboardItem clipboardItem;

        private bool _ShowFirstStartDialog = false;

        public EditItemWindow(ClipboardItem clipboardItem, bool showFirstStartDialog)
        {
            InitializeComponent();
            this.clipboardItem = clipboardItem;
            this._ShowFirstStartDialog = showFirstStartDialog;
        }

        private async void EditItemWindow_Shown(object sender, EventArgs e)
        {
            if (_ShowFirstStartDialog)
            {
                await Task.Delay(400); // Allow enough time for the edit window to finish drawing.
                new KlipboardKeeper_Editor_WelcomeMessage(this.TopMost).ShowDialog();
            }
        }

        private void EditItemWindow_Load(object sender, EventArgs e)
        {
            textBox.Text = clipboardItem.Text;
        }

        private void EditItemWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!skipExitMessage)
            {
                if (!saved)
                {
                    DialogResult result = MessageBox.Show("Close the editor? Unsaved changes will be discarded.",
                                                          "Close editor?",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        e.Cancel = false;
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void toolStripButton_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, textBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Sorry, there was an error writing that file. It may be open in another application.\n" +
                                    $"\n" +
                                    $"Error message: {ex.Message}",
                                    "Error saving to file",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void EditItemWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        void CopyToClipboard()
        {
            Clipboard.SetText(textBox.Text);
        }

        void SaveChanges()
        {
            saved = true;
            // clipboardItem.Text = textBox.Text;
        }

        private void toolStripSplitButton_done_ButtonClick(object sender, EventArgs e)
        {
            toolStripSplitButton_done.ShowDropDown();
        }

        private void saveChangesAndCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveChanges();
            CopyToClipboard();
            Close();
        }

        private void justSaveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveChanges();
            Close();
        }

        private void justCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox.Text);
            // MessageBox.Show("Copied.");
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void toolStripButton_OpenInExternalEditor_Click(object sender, EventArgs e)
        {
            string tempFilePath = Path.GetTempFileName();
            string tempTxtFilePath = Path.ChangeExtension(tempFilePath, ".txt");
            File.Move(tempFilePath, tempTxtFilePath);
            File.WriteAllText(tempTxtFilePath, clipboardItem.Text);
            Process.Start(tempTxtFilePath);

            skipExitMessage = true;
            Close();
        }
    }
}