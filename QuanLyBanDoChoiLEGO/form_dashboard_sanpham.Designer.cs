namespace QuanLyBanDoChoiLEGO
{
    partial class form_dashboard_sanpham
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
            this.buttonNhapKho = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonXemTonKho = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonNhapKho
            // 
            this.buttonNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNhapKho.Location = new System.Drawing.Point(13, 12);
            this.buttonNhapKho.Name = "buttonNhapKho";
            this.buttonNhapKho.Size = new System.Drawing.Size(108, 37);
            this.buttonNhapKho.TabIndex = 0;
            this.buttonNhapKho.Text = "Nhập kho";
            this.buttonNhapKho.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(127, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cập nhật kho";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonXemTonKho
            // 
            this.buttonXemTonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXemTonKho.Location = new System.Drawing.Point(279, 12);
            this.buttonXemTonKho.Name = "buttonXemTonKho";
            this.buttonXemTonKho.Size = new System.Drawing.Size(135, 37);
            this.buttonXemTonKho.TabIndex = 2;
            this.buttonXemTonKho.Text = "Xem tồn kho";
            this.buttonXemTonKho.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 56);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(775, 382);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // form_dashboard_sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonXemTonKho);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonNhapKho);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "form_dashboard_sanpham";
            this.Text = "Sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNhapKho;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonXemTonKho;
        private System.Windows.Forms.ListView listView1;
    }
}