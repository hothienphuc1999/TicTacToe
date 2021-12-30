
namespace AI_DACK
{
    partial class Dashboard
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
            this.rightPanel = new System.Windows.Forms.Panel();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.notificationTxt = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.turnLabel = new System.Windows.Forms.Label();
            this.scorePanel = new System.Windows.Forms.Panel();
            this.secondPlayerPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.scoreOLable = new System.Windows.Forms.Label();
            this.firstPlayerPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.scoreXLable = new System.Windows.Forms.Label();
            this.tậpTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoVánChơiMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chơiLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rightPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.scorePanel.SuspendLayout();
            this.secondPlayerPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.firstPlayerPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.rightPanel.Controls.Add(this.logListBox);
            this.rightPanel.Controls.Add(this.label1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(650, 24);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Padding = new System.Windows.Forms.Padding(5);
            this.rightPanel.Size = new System.Drawing.Size(150, 426);
            this.rightPanel.TabIndex = 1;
            // 
            // logListBox
            // 
            this.logListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.logListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logListBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logListBox.ForeColor = System.Drawing.Color.White;
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 15;
            this.logListBox.Location = new System.Drawing.Point(5, 28);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(140, 393);
            this.logListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các lượt đi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.mainPanel);
            this.leftPanel.Controls.Add(this.notificationTxt);
            this.leftPanel.Controls.Add(this.titlePanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(0, 24);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(650, 426);
            this.leftPanel.TabIndex = 2;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Enabled = false;
            this.mainPanel.Location = new System.Drawing.Point(0, 70);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(650, 343);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseClick);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            // 
            // notificationTxt
            // 
            this.notificationTxt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.notificationTxt.Location = new System.Drawing.Point(0, 413);
            this.notificationTxt.Name = "notificationTxt";
            this.notificationTxt.Size = new System.Drawing.Size(650, 13);
            this.notificationTxt.TabIndex = 1;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.White;
            this.titlePanel.Controls.Add(this.turnLabel);
            this.titlePanel.Controls.Add(this.scorePanel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(650, 70);
            this.titlePanel.TabIndex = 0;
            // 
            // turnLabel
            // 
            this.turnLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turnLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLabel.Location = new System.Drawing.Point(0, 45);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(650, 25);
            this.turnLabel.TabIndex = 1;
            this.turnLabel.Text = "Lượt của X";
            this.turnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scorePanel
            // 
            this.scorePanel.BackColor = System.Drawing.Color.Transparent;
            this.scorePanel.Controls.Add(this.secondPlayerPanel);
            this.scorePanel.Controls.Add(this.firstPlayerPanel);
            this.scorePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.scorePanel.Location = new System.Drawing.Point(0, 0);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Padding = new System.Windows.Forms.Padding(5);
            this.scorePanel.Size = new System.Drawing.Size(650, 45);
            this.scorePanel.TabIndex = 0;
            this.scorePanel.SizeChanged += new System.EventHandler(this.scorePanel_SizeChanged);
            // 
            // secondPlayerPanel
            // 
            this.secondPlayerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.secondPlayerPanel.Controls.Add(this.panel4);
            this.secondPlayerPanel.Location = new System.Drawing.Point(330, 3);
            this.secondPlayerPanel.Name = "secondPlayerPanel";
            this.secondPlayerPanel.Size = new System.Drawing.Size(140, 35);
            this.secondPlayerPanel.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.scoreOLable);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panel4.Size = new System.Drawing.Size(140, 32);
            this.panel4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(20, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "O";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreOLable
            // 
            this.scoreOLable.Dock = System.Windows.Forms.DockStyle.Right;
            this.scoreOLable.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreOLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.scoreOLable.Location = new System.Drawing.Point(96, 0);
            this.scoreOLable.Name = "scoreOLable";
            this.scoreOLable.Size = new System.Drawing.Size(24, 32);
            this.scoreOLable.TabIndex = 1;
            this.scoreOLable.Text = "_";
            this.scoreOLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstPlayerPanel
            // 
            this.firstPlayerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.firstPlayerPanel.Controls.Add(this.panel3);
            this.firstPlayerPanel.Location = new System.Drawing.Point(130, 3);
            this.firstPlayerPanel.Name = "firstPlayerPanel";
            this.firstPlayerPanel.Size = new System.Drawing.Size(140, 35);
            this.firstPlayerPanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.scoreXLable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panel3.Size = new System.Drawing.Size(140, 32);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(20, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreXLable
            // 
            this.scoreXLable.Dock = System.Windows.Forms.DockStyle.Right;
            this.scoreXLable.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreXLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.scoreXLable.Location = new System.Drawing.Point(96, 0);
            this.scoreXLable.Name = "scoreXLable";
            this.scoreXLable.Size = new System.Drawing.Size(24, 32);
            this.scoreXLable.TabIndex = 1;
            this.scoreXLable.Text = "_";
            this.scoreXLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tậpTinToolStripMenuItem
            // 
            this.tậpTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoVánChơiMớiToolStripMenuItem,
            this.chơiLạiToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.tậpTinToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tậpTinToolStripMenuItem.Name = "tậpTinToolStripMenuItem";
            this.tậpTinToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.tậpTinToolStripMenuItem.Text = "Tập tin";
            // 
            // tạoVánChơiMớiToolStripMenuItem
            // 
            this.tạoVánChơiMớiToolStripMenuItem.Name = "tạoVánChơiMớiToolStripMenuItem";
            this.tạoVánChơiMớiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tạoVánChơiMớiToolStripMenuItem.Text = "Tạo ván mới";
            this.tạoVánChơiMớiToolStripMenuItem.Click += new System.EventHandler(this.tạoVánChơiMớiToolStripMenuItem_Click);
            // 
            // chơiLạiToolStripMenuItem
            // 
            this.chơiLạiToolStripMenuItem.Name = "chơiLạiToolStripMenuItem";
            this.chơiLạiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chơiLạiToolStripMenuItem.Text = "Chơi lại";
            this.chơiLạiToolStripMenuItem.Click += new System.EventHandler(this.chơiLạiToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.BackgroundImage = global::AI_DACK.Properties.Resources.noel;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tậpTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Cờ Caro";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.rightPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.scorePanel.ResumeLayout(false);
            this.secondPlayerPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.firstPlayerPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label notificationTxt;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Panel scorePanel;
        private System.Windows.Forms.Panel firstPlayerPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label scoreXLable;
        private System.Windows.Forms.Panel secondPlayerPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label scoreOLable;
        private System.Windows.Forms.ToolStripMenuItem tậpTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoVánChơiMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chơiLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ListBox logListBox;
    }
}

