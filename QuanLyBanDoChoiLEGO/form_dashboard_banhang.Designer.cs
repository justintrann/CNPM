namespace QuanLyBanDoChoiLEGO
{
    partial class form_dashboard_banhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_dashboard_banhang));
            this.buttonSearchProduct = new System.Windows.Forms.Button();
            this.textBoxSearchProduct = new System.Windows.Forms.TextBox();
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.listViewIsSelectedProduct = new System.Windows.Forms.ListView();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.checkBox1_2_Tuoi = new System.Windows.Forms.CheckBox();
            this.checkBox3_5_Tuoi = new System.Windows.Forms.CheckBox();
            this.checkBox6_8_Tuoi = new System.Windows.Forms.CheckBox();
            this.checkBox9_11_Tuoi = new System.Windows.Forms.CheckBox();
            this.checkBoxTren12Tuoi = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonSearchProduct
            // 
            this.buttonSearchProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSearchProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearchProduct.BackgroundImage")));
            this.buttonSearchProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearchProduct.Location = new System.Drawing.Point(12, 12);
            this.buttonSearchProduct.MinimumSize = new System.Drawing.Size(30, 30);
            this.buttonSearchProduct.Name = "buttonSearchProduct";
            this.buttonSearchProduct.Size = new System.Drawing.Size(30, 30);
            this.buttonSearchProduct.TabIndex = 0;
            this.buttonSearchProduct.UseVisualStyleBackColor = false;
            // 
            // textBoxSearchProduct
            // 
            this.textBoxSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchProduct.Location = new System.Drawing.Point(48, 12);
            this.textBoxSearchProduct.MinimumSize = new System.Drawing.Size(349, 30);
            this.textBoxSearchProduct.Name = "textBoxSearchProduct";
            this.textBoxSearchProduct.Size = new System.Drawing.Size(349, 30);
            this.textBoxSearchProduct.TabIndex = 1;
            // 
            // listViewProduct
            // 
            this.listViewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(12, 58);
            this.listViewProduct.MinimumSize = new System.Drawing.Size(385, 380);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(385, 380);
            this.listViewProduct.TabIndex = 2;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            // 
            // listViewIsSelectedProduct
            // 
            this.listViewIsSelectedProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewIsSelectedProduct.HideSelection = false;
            this.listViewIsSelectedProduct.Location = new System.Drawing.Point(403, 58);
            this.listViewIsSelectedProduct.MinimumSize = new System.Drawing.Size(385, 340);
            this.listViewIsSelectedProduct.Name = "listViewIsSelectedProduct";
            this.listViewIsSelectedProduct.Size = new System.Drawing.Size(385, 340);
            this.listViewIsSelectedProduct.TabIndex = 3;
            this.listViewIsSelectedProduct.UseCompatibleStateImageBehavior = false;
            // 
            // labelTongTien
            // 
            this.labelTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelTongTien.Location = new System.Drawing.Point(403, 413);
            this.labelTongTien.MinimumSize = new System.Drawing.Size(87, 20);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(87, 20);
            this.labelTongTien.TabIndex = 4;
            this.labelTongTien.Text = "Tổng tiền";
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxTongTien.Location = new System.Drawing.Point(496, 404);
            this.textBoxTongTien.MinimumSize = new System.Drawing.Size(187, 34);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.Size = new System.Drawing.Size(187, 34);
            this.textBoxTongTien.TabIndex = 5;
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.buttonCheckOut.Location = new System.Drawing.Point(689, 404);
            this.buttonCheckOut.MinimumSize = new System.Drawing.Size(99, 34);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(99, 34);
            this.buttonCheckOut.TabIndex = 6;
            this.buttonCheckOut.Text = "Thanh toán";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // checkBox1_2_Tuoi
            // 
            this.checkBox1_2_Tuoi.AutoSize = true;
            this.checkBox1_2_Tuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1_2_Tuoi.Location = new System.Drawing.Point(407, 4);
            this.checkBox1_2_Tuoi.Name = "checkBox1_2_Tuoi";
            this.checkBox1_2_Tuoi.Size = new System.Drawing.Size(86, 21);
            this.checkBox1_2_Tuoi.TabIndex = 7;
            this.checkBox1_2_Tuoi.Text = "1 - 2 tuổi";
            this.checkBox1_2_Tuoi.UseVisualStyleBackColor = true;
            // 
            // checkBox3_5_Tuoi
            // 
            this.checkBox3_5_Tuoi.AutoSize = true;
            this.checkBox3_5_Tuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3_5_Tuoi.Location = new System.Drawing.Point(407, 31);
            this.checkBox3_5_Tuoi.Name = "checkBox3_5_Tuoi";
            this.checkBox3_5_Tuoi.Size = new System.Drawing.Size(86, 21);
            this.checkBox3_5_Tuoi.TabIndex = 8;
            this.checkBox3_5_Tuoi.Text = "3 - 5 tuổi";
            this.checkBox3_5_Tuoi.UseVisualStyleBackColor = true;
            // 
            // checkBox6_8_Tuoi
            // 
            this.checkBox6_8_Tuoi.AutoSize = true;
            this.checkBox6_8_Tuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6_8_Tuoi.Location = new System.Drawing.Point(518, 4);
            this.checkBox6_8_Tuoi.Name = "checkBox6_8_Tuoi";
            this.checkBox6_8_Tuoi.Size = new System.Drawing.Size(86, 21);
            this.checkBox6_8_Tuoi.TabIndex = 9;
            this.checkBox6_8_Tuoi.Text = "6 - 8 tuổi";
            this.checkBox6_8_Tuoi.UseVisualStyleBackColor = true;
            // 
            // checkBox9_11_Tuoi
            // 
            this.checkBox9_11_Tuoi.AutoSize = true;
            this.checkBox9_11_Tuoi.Location = new System.Drawing.Point(518, 31);
            this.checkBox9_11_Tuoi.Name = "checkBox9_11_Tuoi";
            this.checkBox9_11_Tuoi.Size = new System.Drawing.Size(94, 21);
            this.checkBox9_11_Tuoi.TabIndex = 10;
            this.checkBox9_11_Tuoi.Text = "9 - 11 tuổi";
            this.checkBox9_11_Tuoi.UseVisualStyleBackColor = true;
            // 
            // checkBoxTren12Tuoi
            // 
            this.checkBoxTren12Tuoi.AutoSize = true;
            this.checkBoxTren12Tuoi.Location = new System.Drawing.Point(610, 4);
            this.checkBoxTren12Tuoi.Name = "checkBoxTren12Tuoi";
            this.checkBoxTren12Tuoi.Size = new System.Drawing.Size(107, 21);
            this.checkBoxTren12Tuoi.TabIndex = 11;
            this.checkBoxTren12Tuoi.Text = "Trên 12 tuổi";
            this.checkBoxTren12Tuoi.UseVisualStyleBackColor = true;
            // 
            // form_dashboard_banhang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxTren12Tuoi);
            this.Controls.Add(this.checkBox9_11_Tuoi);
            this.Controls.Add(this.checkBox6_8_Tuoi);
            this.Controls.Add(this.checkBox3_5_Tuoi);
            this.Controls.Add(this.checkBox1_2_Tuoi);
            this.Controls.Add(this.buttonCheckOut);
            this.Controls.Add(this.textBoxTongTien);
            this.Controls.Add(this.labelTongTien);
            this.Controls.Add(this.listViewIsSelectedProduct);
            this.Controls.Add(this.listViewProduct);
            this.Controls.Add(this.textBoxSearchProduct);
            this.Controls.Add(this.buttonSearchProduct);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "form_dashboard_banhang";
            this.Text = "Bán Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.form_dashboard_banhang_Resize);
            this.Resize += new System.EventHandler(this.form_dashboard_banhang_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearchProduct;
        private System.Windows.Forms.TextBox textBoxSearchProduct;
        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.ListView listViewIsSelectedProduct;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.CheckBox checkBox1_2_Tuoi;
        private System.Windows.Forms.CheckBox checkBox3_5_Tuoi;
        private System.Windows.Forms.CheckBox checkBox6_8_Tuoi;
        private System.Windows.Forms.CheckBox checkBox9_11_Tuoi;
        private System.Windows.Forms.CheckBox checkBoxTren12Tuoi;
    }
}