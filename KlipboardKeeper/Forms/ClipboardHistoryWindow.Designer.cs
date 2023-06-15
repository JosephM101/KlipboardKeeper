namespace KlipboardKeeper.Forms
{
    partial class ClipboardHistoryWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClipboardHistoryWindow));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem_clearAllHistory = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem_closeWindow = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem_deselectAll = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem_about = new System.Windows.Forms.MenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStripButton_editSelectedItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_deleteSelectedItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_itemCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_selectedGuid = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_copySelectedItem = new System.Windows.Forms.ToolStripButton();
            this.statusStripUpdater = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem3,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_clearAllHistory,
            this.menuItem6,
            this.menuItem_closeWindow});
            this.menuItem1.Text = "File";
            // 
            // menuItem_clearAllHistory
            // 
            this.menuItem_clearAllHistory.Index = 0;
            this.menuItem_clearAllHistory.Text = "Clear all history";
            this.menuItem_clearAllHistory.Click += new System.EventHandler(this.menuItem_clearAllHistory_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "-";
            // 
            // menuItem_closeWindow
            // 
            this.menuItem_closeWindow.Index = 2;
            this.menuItem_closeWindow.Text = "Exit";
            this.menuItem_closeWindow.Click += new System.EventHandler(this.menuItem_closeWindow_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_deselectAll});
            this.menuItem3.Text = "Edit";
            // 
            // menuItem_deselectAll
            // 
            this.menuItem_deselectAll.Index = 0;
            this.menuItem_deselectAll.Text = "Deselect All";
            this.menuItem_deselectAll.Click += new System.EventHandler(this.menuItem_deselectAll_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_about});
            this.menuItem2.Text = "Help";
            // 
            // menuItem_about
            // 
            this.menuItem_about.Index = 0;
            this.menuItem_about.Text = "About";
            this.menuItem_about.Click += new System.EventHandler(this.menuItem_about_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowCellErrors = false;
            this.dataGridView.ShowRowErrors = false;
            this.dataGridView.Size = new System.Drawing.Size(508, 244);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // toolStripButton_editSelectedItem
            // 
            this.toolStripButton_editSelectedItem.Enabled = false;
            this.toolStripButton_editSelectedItem.Image = global::KlipboardKeeper.Images.Icons_Thick.edit_16;
            this.toolStripButton_editSelectedItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButton_editSelectedItem.Name = "toolStripButton_editSelectedItem";
            this.toolStripButton_editSelectedItem.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton_editSelectedItem.Text = "Edit";
            this.toolStripButton_editSelectedItem.ToolTipText = "Edit";
            this.toolStripButton_editSelectedItem.Click += new System.EventHandler(this.toolStripButton_editSelectedItem_Click);
            // 
            // toolStripButton_deleteSelectedItem
            // 
            this.toolStripButton_deleteSelectedItem.Enabled = false;
            this.toolStripButton_deleteSelectedItem.Image = global::KlipboardKeeper.Images.Icons_Thick.trash_2_16;
            this.toolStripButton_deleteSelectedItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButton_deleteSelectedItem.Name = "toolStripButton_deleteSelectedItem";
            this.toolStripButton_deleteSelectedItem.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton_deleteSelectedItem.Text = "Delete";
            this.toolStripButton_deleteSelectedItem.ToolTipText = "Delete";
            this.toolStripButton_deleteSelectedItem.Click += new System.EventHandler(this.toolStripButton_deleteSelectedItem_Click);
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.dataGridView);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(508, 244);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(508, 291);
            this.toolStripContainer.TabIndex = 2;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_itemCount,
            this.toolStripStatusLabel_selectedGuid});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(508, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // toolStripStatusLabel_itemCount
            // 
            this.toolStripStatusLabel_itemCount.Name = "toolStripStatusLabel_itemCount";
            this.toolStripStatusLabel_itemCount.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel_itemCount.Text = "- items";
            // 
            // toolStripStatusLabel_selectedGuid
            // 
            this.toolStripStatusLabel_selectedGuid.Name = "toolStripStatusLabel_selectedGuid";
            this.toolStripStatusLabel_selectedGuid.Size = new System.Drawing.Size(449, 17);
            this.toolStripStatusLabel_selectedGuid.Spring = true;
            this.toolStripStatusLabel_selectedGuid.Text = "---";
            this.toolStripStatusLabel_selectedGuid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_copySelectedItem,
            this.toolStripButton_editSelectedItem,
            this.toolStripButton_deleteSelectedItem});
            this.toolStrip.Location = new System.Drawing.Point(3, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(169, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton_copySelectedItem
            // 
            this.toolStripButton_copySelectedItem.Enabled = false;
            this.toolStripButton_copySelectedItem.Image = global::KlipboardKeeper.Images.Icons_Thick.copy_16;
            this.toolStripButton_copySelectedItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButton_copySelectedItem.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.toolStripButton_copySelectedItem.Name = "toolStripButton_copySelectedItem";
            this.toolStripButton_copySelectedItem.Size = new System.Drawing.Size(55, 22);
            this.toolStripButton_copySelectedItem.Text = "Copy";
            this.toolStripButton_copySelectedItem.ToolTipText = "Copy";
            this.toolStripButton_copySelectedItem.Click += new System.EventHandler(this.toolStripButton_copySelectedItem_Click);
            // 
            // statusStripUpdater
            // 
            this.statusStripUpdater.Enabled = true;
            this.statusStripUpdater.Tick += new System.EventHandler(this.statusStripUpdater_Tick);
            // 
            // ClipboardHistoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 291);
            this.Controls.Add(this.toolStripContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(40, 40);
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "ClipboardHistoryWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clipboard History";
            this.Load += new System.EventHandler(this.ClipboardHistoryWindow_Load);
            this.VisibleChanged += new System.EventHandler(this.ClipboardHistoryWindow_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem_about;
        private System.Windows.Forms.MenuItem menuItem_closeWindow;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ToolStripButton toolStripButton_copySelectedItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_editSelectedItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_deleteSelectedItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem_deselectAll;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_itemCount;
        private System.Windows.Forms.Timer statusStripUpdater;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_selectedGuid;
        private System.Windows.Forms.MenuItem menuItem_clearAllHistory;
        private System.Windows.Forms.MenuItem menuItem6;
    }
}