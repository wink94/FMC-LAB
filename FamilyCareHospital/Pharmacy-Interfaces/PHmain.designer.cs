namespace FamilyCareHospital.Pharmacy_Interfaces
{
    partial class PHmain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_vwPurchOrd = new System.Windows.Forms.Button();
            this.btn_vwPlacedOrd = new System.Windows.Forms.Button();
            this.btn_purchOrd = new System.Windows.Forms.Button();
            this.btn_placedOrd = new System.Windows.Forms.Button();
            this.btn_addCat = new System.Windows.Forms.Button();
            this.btn_vwStock = new System.Windows.Forms.Button();
            this.btn_mngStock = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_retailSale = new System.Windows.Forms.Button();
            this.btn_vwSale = new System.Windows.Forms.Button();
            this.btn_payments = new System.Windows.Forms.Button();
            this.btn_mngSupp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_user = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(74, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Stock";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(766, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sale";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(526, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Supplier";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Order";
            // 
            // btn_Home
            // 
            this.btn_Home.Image = global::FamilyCareHospital.Properties.Resources.HOME_home_48px;
            this.btn_Home.Location = new System.Drawing.Point(976, 5);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(64, 52);
            this.btn_Home.TabIndex = 24;
            this.btn_Home.UseVisualStyleBackColor = true;
            // 
            // btn_vwPurchOrd
            // 
            this.btn_vwPurchOrd.BackColor = System.Drawing.Color.Yellow;
            this.btn_vwPurchOrd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_vwPurchOrd.Image = global::FamilyCareHospital.Properties.Resources.to_do_64px;
            this.btn_vwPurchOrd.Location = new System.Drawing.Point(301, 421);
            this.btn_vwPurchOrd.Name = "btn_vwPurchOrd";
            this.btn_vwPurchOrd.Size = new System.Drawing.Size(187, 119);
            this.btn_vwPurchOrd.TabIndex = 23;
            this.btn_vwPurchOrd.Text = "View purchased order";
            this.btn_vwPurchOrd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_vwPurchOrd.UseVisualStyleBackColor = false;
            this.btn_vwPurchOrd.Click += new System.EventHandler(this.btn_vwPurchOrd_Click);
            // 
            // btn_vwPlacedOrd
            // 
            this.btn_vwPlacedOrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_vwPlacedOrd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_vwPlacedOrd.Image = global::FamilyCareHospital.Properties.Resources.list_64px;
            this.btn_vwPlacedOrd.Location = new System.Drawing.Point(269, 187);
            this.btn_vwPlacedOrd.Name = "btn_vwPlacedOrd";
            this.btn_vwPlacedOrd.Size = new System.Drawing.Size(187, 119);
            this.btn_vwPlacedOrd.TabIndex = 22;
            this.btn_vwPlacedOrd.Text = "View placed order";
            this.btn_vwPlacedOrd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_vwPlacedOrd.UseVisualStyleBackColor = false;
            this.btn_vwPlacedOrd.Click += new System.EventHandler(this.btn_vwPlacedOrd_Click);
            // 
            // btn_purchOrd
            // 
            this.btn_purchOrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_purchOrd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_purchOrd.Image = global::FamilyCareHospital.Properties.Resources.edit_user_72px;
            this.btn_purchOrd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_purchOrd.Location = new System.Drawing.Point(397, 161);
            this.btn_purchOrd.Name = "btn_purchOrd";
            this.btn_purchOrd.Size = new System.Drawing.Size(91, 119);
            this.btn_purchOrd.TabIndex = 21;
            this.btn_purchOrd.Text = "Purchased order";
            this.btn_purchOrd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_purchOrd.UseVisualStyleBackColor = false;
            this.btn_purchOrd.Click += new System.EventHandler(this.btn_purchOrd_Click);
            // 
            // btn_placedOrd
            // 
            this.btn_placedOrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_placedOrd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_placedOrd.Image = global::FamilyCareHospital.Properties.Resources.edit_file_64px;
            this.btn_placedOrd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_placedOrd.Location = new System.Drawing.Point(301, 161);
            this.btn_placedOrd.Name = "btn_placedOrd";
            this.btn_placedOrd.Size = new System.Drawing.Size(91, 119);
            this.btn_placedOrd.TabIndex = 20;
            this.btn_placedOrd.Text = "Placed order";
            this.btn_placedOrd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_placedOrd.UseVisualStyleBackColor = false;
            this.btn_placedOrd.Click += new System.EventHandler(this.btn_placedOrd_Click);
            // 
            // btn_addCat
            // 
            this.btn_addCat.BackColor = System.Drawing.Color.Aqua;
            this.btn_addCat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_addCat.Image = global::FamilyCareHospital.Properties.Resources.add_tag_64px;
            this.btn_addCat.Location = new System.Drawing.Point(74, 421);
            this.btn_addCat.Name = "btn_addCat";
            this.btn_addCat.Size = new System.Drawing.Size(187, 119);
            this.btn_addCat.TabIndex = 19;
            this.btn_addCat.Text = "Add category";
            this.btn_addCat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_addCat.UseVisualStyleBackColor = false;
            this.btn_addCat.Click += new System.EventHandler(this.btn_addCat_Click);
            // 
            // btn_vwStock
            // 
            this.btn_vwStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_vwStock.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_vwStock.Image = global::FamilyCareHospital.Properties.Resources.fine_print_96px1;
            this.btn_vwStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_vwStock.Location = new System.Drawing.Point(42, 187);
            this.btn_vwStock.Name = "btn_vwStock";
            this.btn_vwStock.Size = new System.Drawing.Size(187, 119);
            this.btn_vwStock.TabIndex = 18;
            this.btn_vwStock.Text = "View stock";
            this.btn_vwStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_vwStock.UseVisualStyleBackColor = false;
            this.btn_vwStock.Click += new System.EventHandler(this.btn_vwStock_Click);
            // 
            // btn_mngStock
            // 
            this.btn_mngStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_mngStock.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mngStock.Image = global::FamilyCareHospital.Properties.Resources.product_96px1;
            this.btn_mngStock.Location = new System.Drawing.Point(74, 161);
            this.btn_mngStock.Name = "btn_mngStock";
            this.btn_mngStock.Size = new System.Drawing.Size(187, 119);
            this.btn_mngStock.TabIndex = 17;
            this.btn_mngStock.Text = "Manage stock";
            this.btn_mngStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_mngStock.UseVisualStyleBackColor = false;
            this.btn_mngStock.Click += new System.EventHandler(this.btn_mngStock_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Image = global::FamilyCareHospital.Properties.Resources.LOGOUT_shutdown_logout_48px;
            this.btn_logout.Location = new System.Drawing.Point(1046, 5);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(64, 52);
            this.btn_logout.TabIndex = 16;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_retailSale
            // 
            this.btn_retailSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_retailSale.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_retailSale.Image = global::FamilyCareHospital.Properties.Resources.shopping_cart_loaded_64px;
            this.btn_retailSale.Location = new System.Drawing.Point(734, 57);
            this.btn_retailSale.Name = "btn_retailSale";
            this.btn_retailSale.Size = new System.Drawing.Size(187, 119);
            this.btn_retailSale.TabIndex = 7;
            this.btn_retailSale.Text = "Retail sale";
            this.btn_retailSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_retailSale.UseVisualStyleBackColor = false;
            this.btn_retailSale.Click += new System.EventHandler(this.btn_retailSale_Click);
            // 
            // btn_vwSale
            // 
            this.btn_vwSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_vwSale.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_vwSale.Image = global::FamilyCareHospital.Properties.Resources.view_file_64px;
            this.btn_vwSale.Location = new System.Drawing.Point(734, 187);
            this.btn_vwSale.Name = "btn_vwSale";
            this.btn_vwSale.Size = new System.Drawing.Size(187, 119);
            this.btn_vwSale.TabIndex = 5;
            this.btn_vwSale.Text = "View sale";
            this.btn_vwSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_vwSale.UseVisualStyleBackColor = false;
            this.btn_vwSale.Click += new System.EventHandler(this.btn_vwSale_Click);
            // 
            // btn_payments
            // 
            this.btn_payments.BackColor = System.Drawing.Color.Silver;
            this.btn_payments.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_payments.Image = global::FamilyCareHospital.Properties.Resources.banknotes_64px;
            this.btn_payments.Location = new System.Drawing.Point(499, 187);
            this.btn_payments.Name = "btn_payments";
            this.btn_payments.Size = new System.Drawing.Size(187, 119);
            this.btn_payments.TabIndex = 3;
            this.btn_payments.Text = "Payments";
            this.btn_payments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_payments.UseVisualStyleBackColor = false;
            this.btn_payments.Click += new System.EventHandler(this.btn_payments_Click);
            // 
            // btn_mngSupp
            // 
            this.btn_mngSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_mngSupp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_mngSupp.Image = global::FamilyCareHospital.Properties.Resources.interstate_truck_64px;
            this.btn_mngSupp.Location = new System.Drawing.Point(499, 57);
            this.btn_mngSupp.Name = "btn_mngSupp";
            this.btn_mngSupp.Size = new System.Drawing.Size(187, 119);
            this.btn_mngSupp.TabIndex = 2;
            this.btn_mngSupp.Text = "Manage supplier";
            this.btn_mngSupp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_mngSupp.UseVisualStyleBackColor = false;
            this.btn_mngSupp.Click += new System.EventHandler(this.btn_mngSupp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 37);
            this.label5.TabIndex = 25;
            this.label5.Text = "Pharmacy Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Location = new System.Drawing.Point(32, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 63);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.lbl_user);
            this.panel2.Controls.Add(this.btn_vwStock);
            this.panel2.Controls.Add(this.btn_vwPlacedOrd);
            this.panel2.Controls.Add(this.btn_mngSupp);
            this.panel2.Controls.Add(this.btn_payments);
            this.panel2.Controls.Add(this.btn_retailSale);
            this.panel2.Controls.Add(this.btn_vwSale);
            this.panel2.Location = new System.Drawing.Point(32, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 446);
            this.panel2.TabIndex = 27;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(994, 26);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(57, 21);
            this.lbl_user.TabIndex = 23;
            this.lbl_user.Text = "label6";
            // 
            // PHmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1184, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_vwPurchOrd);
            this.Controls.Add(this.btn_purchOrd);
            this.Controls.Add(this.btn_placedOrd);
            this.Controls.Add(this.btn_addCat);
            this.Controls.Add(this.btn_mngStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PHmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Family Care Hospital Pvt.Ltd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_mngSupp;
        private System.Windows.Forms.Button btn_payments;
        private System.Windows.Forms.Button btn_vwSale;
        private System.Windows.Forms.Button btn_retailSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_mngStock;
        private System.Windows.Forms.Button btn_vwStock;
        private System.Windows.Forms.Button btn_addCat;
        private System.Windows.Forms.Button btn_placedOrd;
        private System.Windows.Forms.Button btn_purchOrd;
        private System.Windows.Forms.Button btn_vwPlacedOrd;
        private System.Windows.Forms.Button btn_vwPurchOrd;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_user;
    }
}