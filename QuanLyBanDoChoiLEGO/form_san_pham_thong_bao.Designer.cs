namespace QuanLyBanDoChoiLEGO
{
    partial class form_san_pham_thong_bao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_san_pham_thong_bao));
            this.labelThongBao = new System.Windows.Forms.Label();
            this.buttonThuCong = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelThongBao
            // 
            this.labelThongBao.AutoSize = true;
            this.labelThongBao.BackColor = System.Drawing.Color.Transparent;
            this.labelThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongBao.ForeColor = System.Drawing.Color.White;
            this.labelThongBao.Location = new System.Drawing.Point(12, 25);
            this.labelThongBao.Name = "labelThongBao";
            this.labelThongBao.Size = new System.Drawing.Size(346, 18);
            this.labelThongBao.TabIndex = 0;
            this.labelThongBao.Text = "Bạn muốn nhập thủ công hay nhập bằng file Excel ?";
            // 
            // buttonThuCong
            // 
            this.buttonThuCong.BackColor = System.Drawing.Color.Red;
            this.buttonThuCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThuCong.ForeColor = System.Drawing.Color.White;
            this.buttonThuCong.Location = new System.Drawing.Point(12, 66);
            this.buttonThuCong.Name = "buttonThuCong";
            this.buttonThuCong.Size = new System.Drawing.Size(147, 31);
            this.buttonThuCong.TabIndex = 1;
            this.buttonThuCong.Text = "Nhập thủ công";
            this.buttonThuCong.UseVisualStyleBackColor = false;
            this.buttonThuCong.Click += new System.EventHandler(this.buttonThuCong_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcel.ForeColor = System.Drawing.Color.White;
            this.buttonExcel.Location = new System.Drawing.Point(211, 66);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(147, 31);
            this.buttonExcel.TabIndex = 2;
            this.buttonExcel.Text = "Excel";
            this.buttonExcel.UseVisualStyleBackColor = false;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // form_san_pham_thong_bao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanDoChoiLEGO.Properties.Resources.lego_wallpaper_hd_1366x768_1296312;
            this.ClientSize = new System.Drawing.Size(420, 110);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonThuCong);
            this.Controls.Add(this.labelThongBao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_san_pham_thong_bao";
            this.Text = "Thông báo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelThongBao;
        private System.Windows.Forms.Button buttonThuCong;
        private System.Windows.Forms.Button buttonExcel;
    }
}