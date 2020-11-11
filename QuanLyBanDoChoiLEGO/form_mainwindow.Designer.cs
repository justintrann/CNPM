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
            this.panel_side = new System.Windows.Forms.Panel();
            this.btn_board_sanpham = new System.Windows.Forms.Button();
            this.btn_board_thongke = new System.Windows.Forms.Button();
            this.btn_board_lichsu = new System.Windows.Forms.Button();
            this.btn_board_banhang = new System.Windows.Forms.Button();
            this.lbl_dashboard = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel_side.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // panel_side
            // 
            this.panel_side.Controls.Add(this.btn_board_sanpham);
            this.panel_side.Controls.Add(this.btn_board_thongke);
            this.panel_side.Controls.Add(this.btn_board_lichsu);
            this.panel_side.Controls.Add(this.btn_board_banhang);
            this.panel_side.Controls.Add(this.lbl_dashboard);
            this.panel_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side.Location = new System.Drawing.Point(0, 24);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(124, 633);
            this.panel_side.TabIndex = 1;
            // 
            // btn_board_sanpham
            // 
            this.btn_board_sanpham.Location = new System.Drawing.Point(20, 17);
            this.btn_board_sanpham.Name = "btn_board_sanpham";
            this.btn_board_sanpham.Size = new System.Drawing.Size(75, 23);
            this.btn_board_sanpham.TabIndex = 4;
            this.btn_board_sanpham.Text = "Sản phẩm";
            this.btn_board_sanpham.UseVisualStyleBackColor = true;
            this.btn_board_sanpham.Click += new System.EventHandler(this.btn_board_sanpham_Click);
            // 
            // btn_board_thongke
            // 
            this.btn_board_thongke.Location = new System.Drawing.Point(20, 104);
            this.btn_board_thongke.Name = "btn_board_thongke";
            this.btn_board_thongke.Size = new System.Drawing.Size(75, 23);
            this.btn_board_thongke.TabIndex = 3;
            this.btn_board_thongke.Text = "Thống kê";
            this.btn_board_thongke.UseVisualStyleBackColor = true;
            this.btn_board_thongke.Click += new System.EventHandler(this.btn_board_3_Click);
            // 
            // btn_board_lichsu
            // 
            this.btn_board_lichsu.Location = new System.Drawing.Point(20, 75);
            this.btn_board_lichsu.Name = "btn_board_lichsu";
            this.btn_board_lichsu.Size = new System.Drawing.Size(75, 23);
            this.btn_board_lichsu.TabIndex = 2;
            this.btn_board_lichsu.Text = "Lịch sử";
            this.btn_board_lichsu.UseVisualStyleBackColor = true;
            this.btn_board_lichsu.Click += new System.EventHandler(this.btn_board_2_Click);
            // 
            // btn_board_banhang
            // 
            this.btn_board_banhang.Location = new System.Drawing.Point(20, 46);
            this.btn_board_banhang.Name = "btn_board_banhang";
            this.btn_board_banhang.Size = new System.Drawing.Size(75, 23);
            this.btn_board_banhang.TabIndex = 1;
            this.btn_board_banhang.Text = "Bán hàng";
            this.btn_board_banhang.UseVisualStyleBackColor = true;
            this.btn_board_banhang.Click += new System.EventHandler(this.btn_board_1_Click);
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
            // form_mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 657);
            this.Controls.Add(this.panel_side);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_mainwindow";
            this.Text = "Quản lí bán đồ chơi LEGO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_mainwindow_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_side.ResumeLayout(false);
            this.panel_side.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Label lbl_dashboard;
        private System.Windows.Forms.Button btn_board_thongke;
        private System.Windows.Forms.Button btn_board_lichsu;
        private System.Windows.Forms.Button btn_board_banhang;
        private System.Windows.Forms.Button btn_board_sanpham;
    }
}

