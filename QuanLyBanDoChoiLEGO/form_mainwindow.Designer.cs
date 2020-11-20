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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_mainwindow));
            this.panel_side = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_board_taikhoan = new System.Windows.Forms.Button();
            this.btn_board_sanpham = new System.Windows.Forms.Button();
            this.btn_board_thongke = new System.Windows.Forms.Button();
            this.btn_board_lichsu = new System.Windows.Forms.Button();
            this.btn_board_banhang = new System.Windows.Forms.Button();
            this.lbl_dashboard = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.Color.Transparent;
            this.panel_side.BackgroundImage = global::QuanLyBanDoChoiLEGO.Properties.Resources.lego_points_circles_yellow_9721_225x300;
            this.panel_side.Controls.Add(this.pictureBox1);
            this.panel_side.Controls.Add(this.btn_board_taikhoan);
            this.panel_side.Controls.Add(this.btn_board_sanpham);
            this.panel_side.Controls.Add(this.btn_board_thongke);
            this.panel_side.Controls.Add(this.btn_board_lichsu);
            this.panel_side.Controls.Add(this.btn_board_banhang);
            this.panel_side.Controls.Add(this.lbl_dashboard);
            this.panel_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side.ForeColor = System.Drawing.Color.White;
            this.panel_side.Location = new System.Drawing.Point(0, 28);
            this.panel_side.Margin = new System.Windows.Forms.Padding(4);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(165, 781);
            this.panel_side.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::QuanLyBanDoChoiLEGO.Properties.Resources.ClipartKey_1645945;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 478);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_board_taikhoan
            // 
            this.btn_board_taikhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_board_taikhoan.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_board_taikhoan.Enabled = false;
            this.btn_board_taikhoan.FlatAppearance.BorderSize = 0;
            this.btn_board_taikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_board_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_board_taikhoan.Location = new System.Drawing.Point(0, 695);
            this.btn_board_taikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_board_taikhoan.Name = "btn_board_taikhoan";
            this.btn_board_taikhoan.Size = new System.Drawing.Size(165, 80);
            this.btn_board_taikhoan.TabIndex = 5;
            this.btn_board_taikhoan.Text = "Tài khoản";
            this.btn_board_taikhoan.UseVisualStyleBackColor = false;
            this.btn_board_taikhoan.Visible = false;
            this.btn_board_taikhoan.Click += new System.EventHandler(this.btn_board_taikhoan_Click);
            // 
            // btn_board_sanpham
            // 
            this.btn_board_sanpham.BackColor = System.Drawing.Color.Red;
            this.btn_board_sanpham.FlatAppearance.BorderSize = 0;
            this.btn_board_sanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_board_sanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_board_sanpham.Location = new System.Drawing.Point(0, 30);
            this.btn_board_sanpham.Margin = new System.Windows.Forms.Padding(4);
            this.btn_board_sanpham.Name = "btn_board_sanpham";
            this.btn_board_sanpham.Size = new System.Drawing.Size(165, 80);
            this.btn_board_sanpham.TabIndex = 4;
            this.btn_board_sanpham.Text = "Sản phẩm";
            this.btn_board_sanpham.UseVisualStyleBackColor = false;
            this.btn_board_sanpham.Click += new System.EventHandler(this.btn_board_sanpham_Click);
            // 
            // btn_board_thongke
            // 
            this.btn_board_thongke.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_board_thongke.FlatAppearance.BorderSize = 0;
            this.btn_board_thongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_board_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_board_thongke.Location = new System.Drawing.Point(0, 190);
            this.btn_board_thongke.Margin = new System.Windows.Forms.Padding(4);
            this.btn_board_thongke.Name = "btn_board_thongke";
            this.btn_board_thongke.Size = new System.Drawing.Size(165, 80);
            this.btn_board_thongke.TabIndex = 3;
            this.btn_board_thongke.Text = "Thống kê";
            this.btn_board_thongke.UseVisualStyleBackColor = false;
            this.btn_board_thongke.Click += new System.EventHandler(this.btn_board_3_Click);
            // 
            // btn_board_lichsu
            // 
            this.btn_board_lichsu.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_board_lichsu.FlatAppearance.BorderSize = 0;
            this.btn_board_lichsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_board_lichsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_board_lichsu.Location = new System.Drawing.Point(0, 110);
            this.btn_board_lichsu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_board_lichsu.Name = "btn_board_lichsu";
            this.btn_board_lichsu.Size = new System.Drawing.Size(165, 80);
            this.btn_board_lichsu.TabIndex = 2;
            this.btn_board_lichsu.Text = "Lịch sử";
            this.btn_board_lichsu.UseVisualStyleBackColor = false;
            this.btn_board_lichsu.Click += new System.EventHandler(this.btn_board_2_Click);
            // 
            // btn_board_banhang
            // 
            this.btn_board_banhang.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_board_banhang.FlatAppearance.BorderSize = 0;
            this.btn_board_banhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_board_banhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_board_banhang.Location = new System.Drawing.Point(0, 270);
            this.btn_board_banhang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_board_banhang.Name = "btn_board_banhang";
            this.btn_board_banhang.Size = new System.Drawing.Size(165, 80);
            this.btn_board_banhang.TabIndex = 1;
            this.btn_board_banhang.Text = "Bán hàng";
            this.btn_board_banhang.UseVisualStyleBackColor = false;
            this.btn_board_banhang.Click += new System.EventHandler(this.btn_board_1_Click);
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.AutoSize = true;
            this.lbl_dashboard.ForeColor = System.Drawing.Color.Black;
            this.lbl_dashboard.Location = new System.Drawing.Point(23, 0);
            this.lbl_dashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dashboard.Name = "lbl_dashboard";
            this.lbl_dashboard.Size = new System.Drawing.Size(78, 17);
            this.lbl_dashboard.TabIndex = 0;
            this.lbl_dashboard.Text = "Dashboard";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.BackgroundImage = global::QuanLyBanDoChoiLEGO.Properties.Resources.Red_Studs_Lego_Wallpaper;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1467, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // form_mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1467, 809);
            this.Controls.Add(this.panel_side);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_mainwindow";
            this.Text = "Quản lí bán đồ chơi LEGO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_mainwindow_FormClosing);
            this.panel_side.ResumeLayout(false);
            this.panel_side.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btn_board_taikhoan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

