namespace Chess.GUI
{
    partial class InviteWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InviteWindow));
            this.OfflineGameButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.status = new System.Windows.Forms.Label();
            this.layoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OfflineGameButton
            // 
            this.OfflineGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OfflineGameButton.AutoSize = true;
            this.OfflineGameButton.Location = new System.Drawing.Point(3, 3);
            this.OfflineGameButton.Name = "OfflineGameButton";
            this.OfflineGameButton.Size = new System.Drawing.Size(125, 25);
            this.OfflineGameButton.TabIndex = 0;
            this.OfflineGameButton.Text = "Start offline game";
            this.OfflineGameButton.UseVisualStyleBackColor = true;
            this.OfflineGameButton.Click += new System.EventHandler(this.OfflineGameButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitButton.AutoSize = true;
            this.ExitButton.Location = new System.Drawing.Point(3, 34);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(125, 25);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // layoutPanel
            // 
            this.layoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.layoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layoutPanel.Controls.Add(this.OfflineGameButton);
            this.layoutPanel.Controls.Add(this.ExitButton);
            this.layoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.layoutPanel.Location = new System.Drawing.Point(27, 26);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(131, 126);
            this.layoutPanel.TabIndex = 5;
            // 
            // status
            // 
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(1, 187);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 6;
            // 
            // InviteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(184, 202);
            this.Controls.Add(this.status);
            this.Controls.Add(this.layoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "InviteWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chess";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InviteWindow_FormClosed);
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.FlowLayoutPanel layoutPanel;
        private System.Windows.Forms.Label status;
        public System.Windows.Forms.Button OfflineGameButton;
    }
}