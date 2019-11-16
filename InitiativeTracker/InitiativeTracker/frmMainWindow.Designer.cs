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
            this.sortStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addStripButton = new System.Windows.Forms.ToolStripButton();
            this.exportStripButton = new System.Windows.Forms.ToolStripButton();
            this.importStripButton = new System.Windows.Forms.ToolStripSplitButton();
            this.importOnlyCreaturesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importOnlyPlayersItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStrip.SuspendLayout();
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
            this.flowLayoutPanel.Size = new System.Drawing.Size(410, 610);
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
            this.sortStripButton});
            this.mainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mainToolStrip.Location = new System.Drawing.Point(12, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(410, 32);
            this.mainToolStrip.TabIndex = 2;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // sortStripButton
            // 
            this.sortStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sortStripButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.sortStripButton.Image = ((System.Drawing.Image)(resources.GetObject("sortStripButton.Image")));
            this.sortStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortStripButton.Name = "sortStripButton";
            this.sortStripButton.Size = new System.Drawing.Size(55, 29);
            this.sortStripButton.Text = "Sort";
            this.sortStripButton.Click += new System.EventHandler(this.sortStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // addStripButton
            // 
            this.addStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addStripButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.addStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addStripButton.Image")));
            this.addStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addStripButton.Name = "addStripButton";
            this.addStripButton.Size = new System.Drawing.Size(53, 29);
            this.addStripButton.Text = "Add";
            this.addStripButton.Click += new System.EventHandler(this.addStripButton_Click);
            // 
            // exportStripButton
            // 
            this.exportStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exportStripButton.Enabled = false;
            this.exportStripButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.exportStripButton.Image = ((System.Drawing.Image)(resources.GetObject("exportStripButton.Image")));
            this.exportStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportStripButton.Name = "exportStripButton";
            this.exportStripButton.Size = new System.Drawing.Size(77, 29);
            this.exportStripButton.Text = "Export";
            // 
            // importStripButton
            // 
            this.importStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.importStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importOnlyCreaturesItem,
            this.importOnlyPlayersItem});
            this.importStripButton.Enabled = false;
            this.importStripButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.importStripButton.Image = ((System.Drawing.Image)(resources.GetObject("importStripButton.Image")));
            this.importStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importStripButton.Name = "importStripButton";
            this.importStripButton.Size = new System.Drawing.Size(91, 29);
            this.importStripButton.Text = "Import";
            // 
            // importOnlyCreaturesItem
            // 
            this.importOnlyCreaturesItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.importOnlyCreaturesItem.Name = "importOnlyCreaturesItem";
            this.importOnlyCreaturesItem.Size = new System.Drawing.Size(196, 22);
            this.importOnlyCreaturesItem.Text = "Import Only Creatures";
            // 
            // importOnlyPlayersItem
            // 
            this.importOnlyPlayersItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.importOnlyPlayersItem.Name = "importOnlyPlayersItem";
            this.importOnlyPlayersItem.Size = new System.Drawing.Size(196, 22);
            this.importOnlyPlayersItem.Text = "Import Only Players";
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 657);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "frmMainWindow";
            this.Text = "Initiative Tracker";
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

