namespace QuanLyBanDoChoiLEGO
{
    partial class form_mainwindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_board_3 = new System.Windows.Forms.Button();
            this.btn_board_2 = new System.Windows.Forms.Button();
            this.btn_board_1 = new System.Windows.Forms.Button();
            this.lbl_dashboard = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1467, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_board_3);
            this.panel1.Controls.Add(this.btn_board_2);
            this.panel1.Controls.Add(this.btn_board_1);
            this.panel1.Controls.Add(this.lbl_dashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 781);
            this.panel1.TabIndex = 1;
            // 
            // btn_board_3
            // 
            this.btn_board_3.Location = new System.Drawing.Point(27, 91);
            this.btn_board_3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_board_3.Name = "btn_board_3";
            this.btn_board_3.Size = new System.Drawing.Size(100, 28);
            this.btn_board_3.TabIndex = 3;
            this.btn_board_3.Text = "button3";
            this.btn_board_3.UseVisualStyleBackColor = true;
            // 
            // btn_board_2
            // 
            this.btn_board_2.Location = new System.Drawing.Point(27, 55);
            this.btn_board_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_board_2.Name = "btn_board_2";
            this.btn_board_2.Size = new System.Drawing.Size(100, 28);
            this.btn_board_2.TabIndex = 2;
            this.btn_board_2.Text = "button2";
            this.btn_board_2.UseVisualStyleBackColor = true;
            // 
            // btn_board_1
            // 
            this.btn_board_1.Location = new System.Drawing.Point(27, 20);
            this.btn_board_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_board_1.Name = "btn_board_1";
            this.btn_board_1.Size = new System.Drawing.Size(100, 28);
            this.btn_board_1.TabIndex = 1;
            this.btn_board_1.Text = "button1";
            this.btn_board_1.UseVisualStyleBackColor = true;
            this.btn_board_1.Click += new System.EventHandler(this.btn_board_1_Click);
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.AutoSize = true;
            this.lbl_dashboard.Location = new System.Drawing.Point(23, 0);
            this.lbl_dashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dashboard.Name = "lbl_dashboard";
            this.lbl_dashboard.Size = new System.Drawing.Size(78, 17);
            this.lbl_dashboard.TabIndex = 0;
            this.lbl_dashboard.Text = "Dashboard";
            // 
            // form_mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 809);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_mainwindow";
            this.Text = "Quản lí bán đồ chơi LEGO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_dashboard;
        private System.Windows.Forms.Button btn_board_3;
        private System.Windows.Forms.Button btn_board_2;
        private System.Windows.Forms.Button btn_board_1;
    }
}

