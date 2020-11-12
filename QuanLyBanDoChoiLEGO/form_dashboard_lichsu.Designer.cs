namespace QuanLyBanDoChoiLEGO
{
    partial class form_dashboard_lichsu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_dashboard_lichsu));
            this.textbox_search_product = new System.Windows.Forms.TextBox();
            this.buttonSearchProduct = new System.Windows.Forms.Button();
            this.listViewProductOut = new System.Windows.Forms.ListView();
            this.listViewProductIn = new System.Windows.Forms.ListView();
            this.domainUpDownTheLoai = new System.Windows.Forms.DomainUpDown();
            this.domainUpDownNam = new System.Windows.Forms.DomainUpDown();
            this.domainUpDownThang = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // textbox_search_product
            // 
            this.textbox_search_product.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_search_product.Location = new System.Drawing.Point(48, 13);
            this.textbox_search_product.MinimumSize = new System.Drawing.Size(349, 30);
            this.textbox_search_product.Name = "textbox_search_product";
            this.textbox_search_product.Size = new System.Drawing.Size(349, 30);
            this.textbox_search_product.TabIndex = 3;
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
            this.buttonSearchProduct.TabIndex = 2;
            this.buttonSearchProduct.UseVisualStyleBackColor = false;
            // 
            // listViewProductOut
            // 
            this.listViewProductOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProductOut.HideSelection = false;
            this.listViewProductOut.Location = new System.Drawing.Point(403, 58);
            this.listViewProductOut.MinimumSize = new System.Drawing.Size(385, 380);
            this.listViewProductOut.Name = "listViewProductOut";
            this.listViewProductOut.Size = new System.Drawing.Size(385, 380);
            this.listViewProductOut.TabIndex = 5;
            this.listViewProductOut.UseCompatibleStateImageBehavior = false;
            // 
            // listViewProductIn
            // 
            this.listViewProductIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProductIn.HideSelection = false;
            this.listViewProductIn.Location = new System.Drawing.Point(12, 58);
            this.listViewProductIn.MinimumSize = new System.Drawing.Size(385, 380);
            this.listViewProductIn.Name = "listViewProductIn";
            this.listViewProductIn.Size = new System.Drawing.Size(385, 380);
            this.listViewProductIn.TabIndex = 4;
            this.listViewProductIn.UseCompatibleStateImageBehavior = false;
            // 
            // domainUpDownTheLoai
            // 
            this.domainUpDownTheLoai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDownTheLoai.Location = new System.Drawing.Point(403, 12);
            this.domainUpDownTheLoai.Name = "domainUpDownTheLoai";
            this.domainUpDownTheLoai.Size = new System.Drawing.Size(90, 26);
            this.domainUpDownTheLoai.TabIndex = 6;
            this.domainUpDownTheLoai.Text = "Ngày";
            // 
            // domainUpDownNam
            // 
            this.domainUpDownNam.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDownNam.Location = new System.Drawing.Point(605, 12);
            this.domainUpDownNam.Name = "domainUpDownNam";
            this.domainUpDownNam.Size = new System.Drawing.Size(97, 26);
            this.domainUpDownNam.TabIndex = 7;
            this.domainUpDownNam.Text = "Năm";
            // 
            // domainUpDownThang
            // 
            this.domainUpDownThang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDownThang.Location = new System.Drawing.Point(499, 12);
            this.domainUpDownThang.Name = "domainUpDownThang";
            this.domainUpDownThang.Size = new System.Drawing.Size(100, 26);
            this.domainUpDownThang.TabIndex = 8;
            this.domainUpDownThang.Text = "Tháng";
            // 
            // form_dashboard_lichsu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(802, 458);
            this.Controls.Add(this.domainUpDownThang);
            this.Controls.Add(this.domainUpDownNam);
            this.Controls.Add(this.domainUpDownTheLoai);
            this.Controls.Add(this.listViewProductOut);
            this.Controls.Add(this.listViewProductIn);
            this.Controls.Add(this.textbox_search_product);
            this.Controls.Add(this.buttonSearchProduct);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "form_dashboard_lichsu";
            this.Text = "Lịch sử";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.form_history_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_search_product;
        private System.Windows.Forms.Button buttonSearchProduct;
        private System.Windows.Forms.ListView listViewProductOut;
        private System.Windows.Forms.ListView listViewProductIn;
        private System.Windows.Forms.DomainUpDown domainUpDownTheLoai;
        private System.Windows.Forms.DomainUpDown domainUpDownNam;
        private System.Windows.Forms.DomainUpDown domainUpDownThang;
    }
}