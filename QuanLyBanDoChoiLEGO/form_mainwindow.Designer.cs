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
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btn_board_3);
            this.panel1.Controls.Add(this.btn_board_2);
            this.panel1.Controls.Add(this.btn_board_1);
            this.panel1.Controls.Add(this.lbl_dashboard);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 618);
            this.panel1.TabIndex = 1;
            // 
            // btn_board_3
            // 
            this.btn_board_3.Location = new System.Drawing.Point(20, 74);
            this.btn_board_3.Name = "btn_board_3";
            this.btn_board_3.Size = new System.Drawing.Size(75, 23);
            this.btn_board_3.TabIndex = 3;
            this.btn_board_3.Text = "button3";
            this.btn_board_3.UseVisualStyleBackColor = true;
            // 
            // btn_board_2
            // 
            this.btn_board_2.Location = new System.Drawing.Point(20, 45);
            this.btn_board_2.Name = "btn_board_2";
            this.btn_board_2.Size = new System.Drawing.Size(75, 23);
            this.btn_board_2.TabIndex = 2;
            this.btn_board_2.Text = "button2";
            this.btn_board_2.UseVisualStyleBackColor = true;
            // 
            // btn_board_1
            // 
            this.btn_board_1.Location = new System.Drawing.Point(20, 16);
            this.btn_board_1.Name = "btn_board_1";
            this.btn_board_1.Size = new System.Drawing.Size(75, 23);
            this.btn_board_1.TabIndex = 1;
            this.btn_board_1.Text = "button1";
            this.btn_board_1.UseVisualStyleBackColor = true;
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.AutoSize = true;
            this.lbl_dashboard.Location = new System.Drawing.Point(17, 0);
            this.lbl_dashboard.Name = "lbl_dashboard";
            this.lbl_dashboard.Size = new System.Drawing.Size(59, 13);
            this.lbl_dashboard.TabIndex = 0;
            this.lbl_dashboard.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(130, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 618);
            this.panel2.TabIndex = 2;
            // 
            // form_mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 657);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_mainwindow";
            this.Text = "Quản lí bán đồ chơi LEGO";
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
        private System.Windows.Forms.Panel panel2;
    }
}

