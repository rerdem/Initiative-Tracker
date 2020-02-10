namespace InitiativeTracker
{
    partial class frmMainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.importStripButton = new System.Windows.Forms.ToolStripSplitButton();
            this.importOnlyCreaturesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importOnlyPlayersItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addStripButton = new System.Windows.Forms.ToolStripButton();
            this.sortStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.startStripButton = new System.Windows.Forms.ToolStripButton();
            this.stopStripButton = new System.Windows.Forms.ToolStripButton();
            this.prevStripButton = new System.Windows.Forms.ToolStripButton();
            this.nextStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.roundLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.roundNumberLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainToolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 35);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(555, 597);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainToolStrip.AutoSize = false;
            this.mainToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importStripButton,
            this.exportStripButton,
            this.toolStripSeparator1,
            this.addStripButton,
            this.sortStripButton,
            this.toolStripSeparator2,
            this.startStripButton,
            this.stopStripButton,
            this.prevStripButton,
            this.nextStripButton});
            this.mainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mainToolStrip.Location = new System.Drawing.Point(33, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(520, 32);
            this.mainToolStrip.TabIndex = 2;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // importStripButton
            // 
            this.importStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.importStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importOnlyCreaturesItem,
            this.importOnlyPlayersItem});
            this.importStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.importStripButton.Image = ((System.Drawing.Image)(resources.GetObject("importStripButton.Image")));
            this.importStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importStripButton.Name = "importStripButton";
            this.importStripButton.Size = new System.Drawing.Size(78, 29);
            this.importStripButton.Text = "Import";
            this.importStripButton.ButtonClick += new System.EventHandler(this.importStripButton_ButtonClick);
            // 
            // importOnlyCreaturesItem
            // 
            this.importOnlyCreaturesItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.importOnlyCreaturesItem.Name = "importOnlyCreaturesItem";
            this.importOnlyCreaturesItem.Size = new System.Drawing.Size(194, 22);
            this.importOnlyCreaturesItem.Text = "Import Only Creatures";
            this.importOnlyCreaturesItem.Click += new System.EventHandler(this.importOnlyCreaturesItem_Click);
            // 
            // importOnlyPlayersItem
            // 
            this.importOnlyPlayersItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.importOnlyPlayersItem.Name = "importOnlyPlayersItem";
            this.importOnlyPlayersItem.Size = new System.Drawing.Size(194, 22);
            this.importOnlyPlayersItem.Text = "Import Only Players";
            this.importOnlyPlayersItem.Click += new System.EventHandler(this.importOnlyPlayersItem_Click);
            // 
            // exportStripButton
            // 
            this.exportStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exportStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.exportStripButton.Image = ((System.Drawing.Image)(resources.GetObject("exportStripButton.Image")));
            this.exportStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportStripButton.Name = "exportStripButton";
            this.exportStripButton.Size = new System.Drawing.Size(64, 29);
            this.exportStripButton.Text = "Export";
            this.exportStripButton.Click += new System.EventHandler(this.exportStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // addStripButton
            // 
            this.addStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addStripButton.Image")));
            this.addStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addStripButton.Name = "addStripButton";
            this.addStripButton.Size = new System.Drawing.Size(45, 29);
            this.addStripButton.Text = "Add";
            this.addStripButton.Click += new System.EventHandler(this.addStripButton_Click);
            // 
            // sortStripButton
            // 
            this.sortStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sortStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.sortStripButton.Image = ((System.Drawing.Image)(resources.GetObject("sortStripButton.Image")));
            this.sortStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortStripButton.Name = "sortStripButton";
            this.sortStripButton.Size = new System.Drawing.Size(45, 29);
            this.sortStripButton.Text = "Sort";
            this.sortStripButton.Click += new System.EventHandler(this.sortStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // startStripButton
            // 
            this.startStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.startStripButton.Image = ((System.Drawing.Image)(resources.GetObject("startStripButton.Image")));
            this.startStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.startStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startStripButton.Name = "startStripButton";
            this.startStripButton.Size = new System.Drawing.Size(79, 29);
            this.startStripButton.Text = "Start";
            this.startStripButton.Click += new System.EventHandler(this.startStripButton_Click);
            // 
            // stopStripButton
            // 
            this.stopStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stopStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.stopStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopStripButton.Name = "stopStripButton";
            this.stopStripButton.Size = new System.Drawing.Size(49, 29);
            this.stopStripButton.Text = "Stop";
            this.stopStripButton.Click += new System.EventHandler(this.stopStripButton_Click);
            // 
            // prevStripButton
            // 
            this.prevStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.prevStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.prevStripButton.Image = ((System.Drawing.Image)(resources.GetObject("prevStripButton.Image")));
            this.prevStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prevStripButton.Name = "prevStripButton";
            this.prevStripButton.Size = new System.Drawing.Size(63, 29);
            this.prevStripButton.Text = "< Prev";
            this.prevStripButton.Click += new System.EventHandler(this.prevStripButton_Click);
            // 
            // nextStripButton
            // 
            this.nextStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.nextStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.nextStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nextStripButton.Image")));
            this.nextStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextStripButton.Name = "nextStripButton";
            this.nextStripButton.Size = new System.Drawing.Size(66, 29);
            this.nextStripButton.Text = "Next >";
            this.nextStripButton.Click += new System.EventHandler(this.nextStripButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roundLabel,
            this.roundNumberLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 635);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(579, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // roundLabel
            // 
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(91, 17);
            this.roundLabel.Text = "Combat Round:";
            // 
            // roundNumberLabel
            // 
            this.roundNumberLabel.Name = "roundNumberLabel";
            this.roundNumberLabel.Size = new System.Drawing.Size(13, 17);
            this.roundNumberLabel.Text = "1";
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 657);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.flowLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainWindow";
            this.Text = "Initiative Tracker";
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton sortStripButton;
        private System.Windows.Forms.ToolStripButton exportStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton addStripButton;
        private System.Windows.Forms.ToolStripSplitButton importStripButton;
        private System.Windows.Forms.ToolStripMenuItem importOnlyCreaturesItem;
        private System.Windows.Forms.ToolStripMenuItem importOnlyPlayersItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton startStripButton;
        private System.Windows.Forms.ToolStripButton prevStripButton;
        private System.Windows.Forms.ToolStripButton nextStripButton;
        private System.Windows.Forms.ToolStripButton stopStripButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel roundLabel;
        private System.Windows.Forms.ToolStripStatusLabel roundNumberLabel;
    }
}

