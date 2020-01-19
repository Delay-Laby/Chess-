namespace Chess.GUI
{
    partial class PlayWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayWindow));
            this.gameConsole = new System.Windows.Forms.RichTextBox();
            this.commandLine = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Player1Time = new System.Windows.Forms.Label();
            this.Player2Time = new System.Windows.Forms.Label();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.skinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Skins_button = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // gameConsole
            // 
            this.gameConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gameConsole.BackColor = System.Drawing.SystemColors.Window;
            this.gameConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gameConsole.Cursor = System.Windows.Forms.Cursors.Default;
            this.gameConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameConsole.Location = new System.Drawing.Point(667, 0);
            this.gameConsole.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.gameConsole.MaxLength = 1000000;
            this.gameConsole.Name = "gameConsole";
            this.gameConsole.ReadOnly = true;
            this.gameConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.gameConsole.Size = new System.Drawing.Size(316, 560);
            this.gameConsole.TabIndex = 100;
            this.gameConsole.TabStop = false;
            this.gameConsole.Text = "";
            // 
            // commandLine
            // 
            this.commandLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.commandLine.Location = new System.Drawing.Point(667, 561);
            this.commandLine.Name = "commandLine";
            this.commandLine.Size = new System.Drawing.Size(242, 20);
            this.commandLine.TabIndex = 0;
            this.commandLine.Visible = false;
            this.commandLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commandLine_KeyDown);
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(909, 560);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 22);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Visible = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(675, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(819, 587);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "Player 2";
            // 
            // Player1Time
            // 
            this.Player1Time.AutoSize = true;
            this.Player1Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player1Time.Location = new System.Drawing.Point(671, 601);
            this.Player1Time.Name = "Player1Time";
            this.Player1Time.Size = new System.Drawing.Size(102, 39);
            this.Player1Time.TabIndex = 103;
            this.Player1Time.Text = "00:00";
            // 
            // Player2Time
            // 
            this.Player2Time.AutoSize = true;
            this.Player2Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player2Time.Location = new System.Drawing.Point(815, 601);
            this.Player2Time.Name = "Player2Time";
            this.Player2Time.Size = new System.Drawing.Size(102, 39);
            this.Player2Time.TabIndex = 104;
            this.Player2Time.Text = "00:00";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skinsToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // skinsToolStripMenuItem
            // 
            this.skinsToolStripMenuItem.Name = "skinsToolStripMenuItem";
            this.skinsToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.skinsToolStripMenuItem.Text = "skins";
            // 
            // Skins_button
            // 
            this.Skins_button.Location = new System.Drawing.Point(908, 643);
            this.Skins_button.Name = "Skins_button";
            this.Skins_button.Size = new System.Drawing.Size(75, 23);
            this.Skins_button.TabIndex = 105;
            this.Skins_button.Text = "Skins";
            this.Skins_button.UseVisualStyleBackColor = true;
            this.Skins_button.Click += new System.EventHandler(this.Skin_Click);
            // 
            // folderBrowser
            // 
            this.folderBrowser.SelectedPath = "Folder Selection";
            // 
            // PlayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(984, 666);
            this.Controls.Add(this.Skins_button);
            this.Controls.Add(this.Player2Time);
            this.Controls.Add(this.Player1Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.commandLine);
            this.Controls.Add(this.gameConsole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PlayWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.PlayWindow_Activated);
            this.Deactivate += new System.EventHandler(this.PlayWindow_Deactivate);
            this.Shown += new System.EventHandler(this.PlayWindow_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayWindow_Click);
            this.Move += new System.EventHandler(this.PlayWindow_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox gameConsole;
        private System.Windows.Forms.TextBox commandLine;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Player1Time;
        private System.Windows.Forms.Label Player2Time;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem skinsToolStripMenuItem;
        private System.Windows.Forms.Button Skins_button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}
