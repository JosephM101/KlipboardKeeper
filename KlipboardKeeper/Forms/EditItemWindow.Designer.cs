namespace KlipboardKeeper.Forms
{
    partial class EditItemWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditItemWindow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton_done = new System.Windows.Forms.ToolStripSplitButton();
            this.saveChangesAndCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justSaveChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton_openInExternalEditor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_cancel = new System.Windows.Forms.ToolStripButton();
            this.textBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton_done,
            this.toolStripButton_openInExternalEditor,
            this.toolStripButton_cancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toolStrip1.Size = new System.Drawing.Size(524, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton_done
            // 
            this.toolStripSplitButton_done.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSplitButton_done.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveChangesAndCopyToolStripMenuItem,
            this.justSaveChangesToolStripMenuItem,
            this.justCopyToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToFileToolStripMenuItem});
            this.toolStripSplitButton_done.Image = global::KlipboardKeeper.Properties.Resources.check_32;
            this.toolStripSplitButton_done.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton_done.Name = "toolStripSplitButton_done";
            this.toolStripSplitButton_done.Size = new System.Drawing.Size(67, 22);
            this.toolStripSplitButton_done.Text = "Done";
            this.toolStripSplitButton_done.ButtonClick += new System.EventHandler(this.toolStripSplitButton_done_ButtonClick);
            // 
            // saveChangesAndCopyToolStripMenuItem
            // 
            this.saveChangesAndCopyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesAndCopyToolStripMenuItem.Name = "saveChangesAndCopyToolStripMenuItem";
            this.saveChangesAndCopyToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.saveChangesAndCopyToolStripMenuItem.Text = "Save changes && copy to clipboard";
            this.saveChangesAndCopyToolStripMenuItem.Click += new System.EventHandler(this.saveChangesAndCopyToolStripMenuItem_Click);
            // 
            // justSaveChangesToolStripMenuItem
            // 
            this.justSaveChangesToolStripMenuItem.Image = global::KlipboardKeeper.Properties.Resources.save_32;
            this.justSaveChangesToolStripMenuItem.Name = "justSaveChangesToolStripMenuItem";
            this.justSaveChangesToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.justSaveChangesToolStripMenuItem.Text = "Just save changes";
            this.justSaveChangesToolStripMenuItem.Click += new System.EventHandler(this.justSaveChangesToolStripMenuItem_Click);
            // 
            // justCopyToolStripMenuItem
            // 
            this.justCopyToolStripMenuItem.Name = "justCopyToolStripMenuItem";
            this.justCopyToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.justCopyToolStripMenuItem.Text = "Just copy to clipboard";
            this.justCopyToolStripMenuItem.Click += new System.EventHandler(this.justCopyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Image = global::KlipboardKeeper.Properties.Resources.save_32;
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.saveToFileToolStripMenuItem.Text = "Save to file";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // toolStripButton_openInExternalEditor
            // 
            this.toolStripButton_openInExternalEditor.Image = global::KlipboardKeeper.Properties.Resources.Open_16x;
            this.toolStripButton_openInExternalEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_openInExternalEditor.Name = "toolStripButton_openInExternalEditor";
            this.toolStripButton_openInExternalEditor.Size = new System.Drawing.Size(168, 22);
            this.toolStripButton_openInExternalEditor.Text = "Open in System Text Editor";
            this.toolStripButton_openInExternalEditor.Click += new System.EventHandler(this.toolStripButton_OpenInExternalEditor_Click);
            // 
            // toolStripButton_cancel
            // 
            this.toolStripButton_cancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_cancel.Image = global::KlipboardKeeper.Properties.Resources.x_16;
            this.toolStripButton_cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_cancel.Margin = new System.Windows.Forms.Padding(0, 1, 8, 2);
            this.toolStripButton_cancel.Name = "toolStripButton_cancel";
            this.toolStripButton_cancel.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton_cancel.Text = "Cancel";
            this.toolStripButton_cancel.Click += new System.EventHandler(this.toolStripButton_Cancel_Click);
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 25);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(524, 259);
            this.textBox.TabIndex = 4;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Plain Text Files|*.txt";
            // 
            // EditItemWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 284);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditItemWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Item";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditItemWindow_FormClosing);
            this.Load += new System.EventHandler(this.EditItemWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditItemWindow_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_openInExternalEditor;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton_done;
        private System.Windows.Forms.ToolStripMenuItem saveChangesAndCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem justSaveChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem justCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_cancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        public System.Windows.Forms.TextBox textBox;
    }
}