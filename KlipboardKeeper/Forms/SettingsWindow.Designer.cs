namespace KlipboardKeeper.Forms
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_clipboardHistory_maxSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox_uiOptions_keepHistoryWindowOnTop = new System.Windows.Forms.CheckBox();
            this.checkBox_uiOptions_showCopyPreviewBalloon = new System.Windows.Forms.CheckBox();
            this.checkBox_behavior_ignoreClipboardDataPresentAtStartup = new System.Windows.Forms.CheckBox();
            this.checkBox_behavior_tryToPreventDuplicates = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox_memory_rememberClipboardHistory = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox_startup_startWithWindows = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_resetDialogFlags = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_clipboardHistory_maxSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 62);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "History";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown_clipboardHistory_maxSize);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(221, 26);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keep up to";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown_clipboardHistory_maxSize
            // 
            this.numericUpDown_clipboardHistory_maxSize.Location = new System.Drawing.Point(68, 3);
            this.numericUpDown_clipboardHistory_maxSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_clipboardHistory_maxSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_clipboardHistory_maxSize.Name = "numericUpDown_clipboardHistory_maxSize";
            this.numericUpDown_clipboardHistory_maxSize.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown_clipboardHistory_maxSize.TabIndex = 1;
            this.toolTip.SetToolTip(this.numericUpDown_clipboardHistory_maxSize, "NOTE: Changes to this setting are only applied when KlipboardKeeper is restarted." +
        "");
            this.numericUpDown_clipboardHistory_maxSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_clipboardHistory_maxSize.ValueChanged += new System.EventHandler(this.numericUpDown_clipboardHistory_maxSize_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "clipboard entries";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 119);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UI && Behavior";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.checkBox_uiOptions_keepHistoryWindowOnTop);
            this.flowLayoutPanel2.Controls.Add(this.checkBox_uiOptions_showCopyPreviewBalloon);
            this.flowLayoutPanel2.Controls.Add(this.checkBox_behavior_ignoreClipboardDataPresentAtStartup);
            this.flowLayoutPanel2.Controls.Add(this.checkBox_behavior_tryToPreventDuplicates);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(333, 100);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // checkBox_uiOptions_keepHistoryWindowOnTop
            // 
            this.checkBox_uiOptions_keepHistoryWindowOnTop.AutoSize = true;
            this.checkBox_uiOptions_keepHistoryWindowOnTop.Location = new System.Drawing.Point(3, 3);
            this.checkBox_uiOptions_keepHistoryWindowOnTop.Name = "checkBox_uiOptions_keepHistoryWindowOnTop";
            this.checkBox_uiOptions_keepHistoryWindowOnTop.Size = new System.Drawing.Size(220, 17);
            this.checkBox_uiOptions_keepHistoryWindowOnTop.TabIndex = 0;
            this.checkBox_uiOptions_keepHistoryWindowOnTop.Text = "Keep history window on top of everything";
            this.checkBox_uiOptions_keepHistoryWindowOnTop.UseVisualStyleBackColor = true;
            this.checkBox_uiOptions_keepHistoryWindowOnTop.CheckedChanged += new System.EventHandler(this.checkBox_uiOptions_keepHistoryWindowOnTop_CheckedChanged);
            // 
            // checkBox_uiOptions_showCopyPreviewBalloon
            // 
            this.checkBox_uiOptions_showCopyPreviewBalloon.AutoSize = true;
            this.checkBox_uiOptions_showCopyPreviewBalloon.Location = new System.Drawing.Point(3, 26);
            this.checkBox_uiOptions_showCopyPreviewBalloon.Name = "checkBox_uiOptions_showCopyPreviewBalloon";
            this.checkBox_uiOptions_showCopyPreviewBalloon.Size = new System.Drawing.Size(238, 17);
            this.checkBox_uiOptions_showCopyPreviewBalloon.TabIndex = 1;
            this.checkBox_uiOptions_showCopyPreviewBalloon.Text = "Show balloon with preview of copied content";
            this.toolTip.SetToolTip(this.checkBox_uiOptions_showCopyPreviewBalloon, "If checked. when content is copied to the clipboard, a balloon/notification ackno" +
        "wledging the event will appear.\r\n\r\nThe balloon will also briefly show the copied" +
        " content.");
            this.checkBox_uiOptions_showCopyPreviewBalloon.UseVisualStyleBackColor = true;
            this.checkBox_uiOptions_showCopyPreviewBalloon.CheckedChanged += new System.EventHandler(this.checkBox_uiOptions_showCopyPreviewBalloon_CheckedChanged);
            // 
            // checkBox_behavior_ignoreClipboardDataPresentAtStartup
            // 
            this.checkBox_behavior_ignoreClipboardDataPresentAtStartup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_behavior_ignoreClipboardDataPresentAtStartup.AutoSize = true;
            this.checkBox_behavior_ignoreClipboardDataPresentAtStartup.Location = new System.Drawing.Point(3, 49);
            this.checkBox_behavior_ignoreClipboardDataPresentAtStartup.Name = "checkBox_behavior_ignoreClipboardDataPresentAtStartup";
            this.checkBox_behavior_ignoreClipboardDataPresentAtStartup.Size = new System.Drawing.Size(302, 17);
            this.checkBox_behavior_ignoreClipboardDataPresentAtStartup.TabIndex = 2;
            this.checkBox_behavior_ignoreClipboardDataPresentAtStartup.Text = "Ignore clipboard data present when KlipboardKeeper starts";
            this.toolTip.SetToolTip(this.checkBox_behavior_ignoreClipboardDataPresentAtStartup, resources.GetString("checkBox_behavior_ignoreClipboardDataPresentAtStartup.ToolTip"));
            this.checkBox_behavior_ignoreClipboardDataPresentAtStartup.UseVisualStyleBackColor = true;
            this.checkBox_behavior_ignoreClipboardDataPresentAtStartup.CheckedChanged += new System.EventHandler(this.checkBox_behavior_ignoreClipboardDataPresentAtStartup_CheckedChanged);
            // 
            // checkBox_behavior_tryToPreventDuplicates
            // 
            this.checkBox_behavior_tryToPreventDuplicates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_behavior_tryToPreventDuplicates.AutoSize = true;
            this.checkBox_behavior_tryToPreventDuplicates.Location = new System.Drawing.Point(3, 72);
            this.checkBox_behavior_tryToPreventDuplicates.Name = "checkBox_behavior_tryToPreventDuplicates";
            this.checkBox_behavior_tryToPreventDuplicates.Size = new System.Drawing.Size(302, 17);
            this.checkBox_behavior_tryToPreventDuplicates.TabIndex = 3;
            this.checkBox_behavior_tryToPreventDuplicates.Text = "Try to prevent duplicate copies";
            this.toolTip.SetToolTip(this.checkBox_behavior_tryToPreventDuplicates, "If KlipboardKeeper detects that newly received content from the clipboard matches" +
        " content already in the history, it will ignore it.");
            this.checkBox_behavior_tryToPreventDuplicates.UseVisualStyleBackColor = true;
            this.checkBox_behavior_tryToPreventDuplicates.CheckedChanged += new System.EventHandler(this.checkBox_behavior_tryToPreventDuplicates_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 49);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Memory";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.checkBox_memory_rememberClipboardHistory);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(333, 30);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // checkBox_memory_rememberClipboardHistory
            // 
            this.checkBox_memory_rememberClipboardHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_memory_rememberClipboardHistory.AutoSize = true;
            this.checkBox_memory_rememberClipboardHistory.Location = new System.Drawing.Point(3, 3);
            this.checkBox_memory_rememberClipboardHistory.Name = "checkBox_memory_rememberClipboardHistory";
            this.checkBox_memory_rememberClipboardHistory.Size = new System.Drawing.Size(258, 17);
            this.checkBox_memory_rememberClipboardHistory.TabIndex = 3;
            this.checkBox_memory_rememberClipboardHistory.Text = "Remember clipboard history between app restarts";
            this.toolTip.SetToolTip(this.checkBox_memory_rememberClipboardHistory, resources.GetString("checkBox_memory_rememberClipboardHistory.ToolTip"));
            this.checkBox_memory_rememberClipboardHistory.UseVisualStyleBackColor = true;
            this.checkBox_memory_rememberClipboardHistory.CheckedChanged += new System.EventHandler(this.checkBox_memory_rememberClipboardHistory_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flowLayoutPanel4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 49);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Startup";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.checkBox_startup_startWithWindows);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(333, 30);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // checkBox_startup_startWithWindows
            // 
            this.checkBox_startup_startWithWindows.AutoSize = true;
            this.checkBox_startup_startWithWindows.Location = new System.Drawing.Point(3, 3);
            this.checkBox_startup_startWithWindows.Name = "checkBox_startup_startWithWindows";
            this.checkBox_startup_startWithWindows.Size = new System.Drawing.Size(117, 17);
            this.checkBox_startup_startWithWindows.TabIndex = 0;
            this.checkBox_startup_startWithWindows.Text = "Start with Windows";
            this.checkBox_startup_startWithWindows.UseVisualStyleBackColor = true;
            this.checkBox_startup_startWithWindows.CheckedChanged += new System.EventHandler(this.checkBox_startup_startWithWindows_CheckedChanged);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(282, 431);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Close";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOTE: Some settings may not take effect until you restart KlipboardKeeper.";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.flowLayoutPanel5);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 306);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(339, 54);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Miscellaneous";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.button_resetDialogFlags);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(333, 35);
            this.flowLayoutPanel5.TabIndex = 0;
            // 
            // button_resetDialogFlags
            // 
            this.button_resetDialogFlags.AutoSize = true;
            this.button_resetDialogFlags.Location = new System.Drawing.Point(3, 3);
            this.button_resetDialogFlags.Name = "button_resetDialogFlags";
            this.button_resetDialogFlags.Size = new System.Drawing.Size(106, 23);
            this.button_resetDialogFlags.TabIndex = 0;
            this.button_resetDialogFlags.Text = "Reset Dialog Flags";
            this.button_resetDialogFlags.UseVisualStyleBackColor = true;
            this.button_resetDialogFlags.Click += new System.EventHandler(this.button_resetDialogFlags_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.okButton;
            this.ClientSize = new System.Drawing.Size(369, 466);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KlipboardKeeper Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_clipboardHistory_maxSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_clipboardHistory_maxSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBox_uiOptions_keepHistoryWindowOnTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_uiOptions_showCopyPreviewBalloon;
        private System.Windows.Forms.CheckBox checkBox_behavior_ignoreClipboardDataPresentAtStartup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox checkBox_memory_rememberClipboardHistory;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.CheckBox checkBox_startup_startWithWindows;
        private System.Windows.Forms.CheckBox checkBox_behavior_tryToPreventDuplicates;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button button_resetDialogFlags;
    }
}