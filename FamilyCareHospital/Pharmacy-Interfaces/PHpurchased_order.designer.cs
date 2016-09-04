namespace FamilyCareHospital.Pharmacy_Interfaces
{
    partial class PHpurchased_order
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
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_crntSts = new System.Windows.Forms.Label();
            this.lbl_addDte = new System.Windows.Forms.Label();
            this.lbl_supp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_cat = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_itm = new System.Windows.Forms.Label();
            this.btn_vw = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbx_vwCat = new System.Windows.Forms.ComboBox();
            this.cmbx_type = new System.Windows.Forms.ComboBox();
            this.dgv_purchsdOrdr = new System.Windows.Forms.DataGridView();
            this.txt_odrID = new System.Windows.Forms.TextBox();
            this.txt_itmName = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_supID = new System.Windows.Forms.TextBox();
            this.dtp_rcvdDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_adedDate = new System.Windows.Forms.DateTimePicker();
            this.cmbx_Cat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx_crntStats = new System.Windows.Forms.ComboBox();
            this.lbl_QtyOfItm = new System.Windows.Forms.Label();
            this.lbl_rtrn = new System.Windows.Forms.Label();
            this.lbl_addToStck = new System.Windows.Forms.Label();
            this.cmbx_qltyOfItm = new System.Windows.Forms.ComboBox();
            this.cmbx_return = new System.Windows.Forms.ComboBox();
            this.cmbx_addToStck = new System.Windows.Forms.ComboBox();
            this.btn_updt = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_purchsdOrdr)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 30);
            this.label10.TabIndex = 44;
            this.label10.Text = "Purchased order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(24, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Order id";
            // 
            // lbl_crntSts
            // 
            this.lbl_crntSts.AutoSize = true;
            this.lbl_crntSts.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_crntSts.Location = new System.Drawing.Point(24, 455);
            this.lbl_crntSts.Name = "lbl_crntSts";
            this.lbl_crntSts.Size = new System.Drawing.Size(92, 17);
            this.lbl_crntSts.TabIndex = 50;
            this.lbl_crntSts.Text = "Recieved date";
            // 
            // lbl_addDte
            // 
            this.lbl_addDte.AutoSize = true;
            this.lbl_addDte.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_addDte.Location = new System.Drawing.Point(24, 356);
            this.lbl_addDte.Name = "lbl_addDte";
            this.lbl_addDte.Size = new System.Drawing.Size(79, 17);
            this.lbl_addDte.TabIndex = 52;
            this.lbl_addDte.Text = "Added date";
            // 
            // lbl_supp
            // 
            this.lbl_supp.AutoSize = true;
            this.lbl_supp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_supp.Location = new System.Drawing.Point(24, 315);
            this.lbl_supp.Name = "lbl_supp";
            this.lbl_supp.Size = new System.Drawing.Size(74, 17);
            this.lbl_supp.TabIndex = 53;
            this.lbl_supp.Text = "Supplier ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(34, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 54;
            this.label9.Text = "Quantity";
            // 
            // lbl_cat
            // 
            this.lbl_cat.AutoSize = true;
            this.lbl_cat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_cat.Location = new System.Drawing.Point(29, 225);
            this.lbl_cat.Name = "lbl_cat";
            this.lbl_cat.Size = new System.Drawing.Size(64, 17);
            this.lbl_cat.TabIndex = 55;
            this.lbl_cat.Text = "Category";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_name.Location = new System.Drawing.Point(29, 187);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 17);
            this.lbl_name.TabIndex = 56;
            this.lbl_name.Text = "Name";
            // 
            // lbl_itm
            // 
            this.lbl_itm.AutoSize = true;
            this.lbl_itm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_itm.Location = new System.Drawing.Point(24, 143);
            this.lbl_itm.Name = "lbl_itm";
            this.lbl_itm.Size = new System.Drawing.Size(53, 17);
            this.lbl_itm.TabIndex = 57;
            this.lbl_itm.Text = "Item ID";
            // 
            // btn_vw
            // 
            this.btn_vw.Location = new System.Drawing.Point(928, 87);
            this.btn_vw.Name = "btn_vw";
            this.btn_vw.Size = new System.Drawing.Size(75, 23);
            this.btn_vw.TabIndex = 73;
            this.btn_vw.Text = "View";
            this.btn_vw.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Image = global::FamilyCareHospital.Properties.Resources.SEARCH_search_32px;
            this.btn_search.Location = new System.Drawing.Point(635, 84);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 39);
            this.btn_search.TabIndex = 72;
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(362, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 17);
            this.label16.TabIndex = 71;
            this.label16.Text = "Choose type";
            // 
            // cmbx_vwCat
            // 
            this.cmbx_vwCat.FormattingEnabled = true;
            this.cmbx_vwCat.Location = new System.Drawing.Point(764, 87);
            this.cmbx_vwCat.Name = "cmbx_vwCat";
            this.cmbx_vwCat.Size = new System.Drawing.Size(121, 21);
            this.cmbx_vwCat.TabIndex = 70;
            this.cmbx_vwCat.Text = "category";
            // 
            // cmbx_type
            // 
            this.cmbx_type.FormattingEnabled = true;
            this.cmbx_type.Location = new System.Drawing.Point(467, 87);
            this.cmbx_type.Name = "cmbx_type";
            this.cmbx_type.Size = new System.Drawing.Size(121, 21);
            this.cmbx_type.TabIndex = 69;
            // 
            // dgv_purchsdOrdr
            // 
            this.dgv_purchsdOrdr.AllowUserToOrderColumns = true;
            this.dgv_purchsdOrdr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_purchsdOrdr.Location = new System.Drawing.Point(388, 241);
            this.dgv_purchsdOrdr.Name = "dgv_purchsdOrdr";
            this.dgv_purchsdOrdr.Size = new System.Drawing.Size(602, 314);
            this.dgv_purchsdOrdr.TabIndex = 74;
            this.dgv_purchsdOrdr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_purchsdOrdr_MouseClick);
            // 
            // txt_odrID
            // 
            this.txt_odrID.Location = new System.Drawing.Point(153, 93);
            this.txt_odrID.Name = "txt_odrID";
            this.txt_odrID.Size = new System.Drawing.Size(100, 20);
            this.txt_odrID.TabIndex = 80;
            // 
            // txt_itmName
            // 
            this.txt_itmName.Location = new System.Drawing.Point(153, 143);
            this.txt_itmName.Name = "txt_itmName";
            this.txt_itmName.Size = new System.Drawing.Size(100, 20);
            this.txt_itmName.TabIndex = 79;
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(153, 270);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(100, 20);
            this.txt_qty.TabIndex = 77;
            this.txt_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qty_KeyPress);
            // 
            // txt_supID
            // 
            this.txt_supID.Location = new System.Drawing.Point(153, 315);
            this.txt_supID.Name = "txt_supID";
            this.txt_supID.Size = new System.Drawing.Size(100, 20);
            this.txt_supID.TabIndex = 76;
            // 
            // dtp_rcvdDate
            // 
            this.dtp_rcvdDate.CustomFormat = "yyyy-MM-dd";
            this.dtp_rcvdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_rcvdDate.Location = new System.Drawing.Point(130, 455);
            this.dtp_rcvdDate.Name = "dtp_rcvdDate";
            this.dtp_rcvdDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_rcvdDate.TabIndex = 81;
            // 
            // dtp_adedDate
            // 
            this.dtp_adedDate.CustomFormat = "yyyy-MM-dd";
            this.dtp_adedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_adedDate.Location = new System.Drawing.Point(140, 353);
            this.dtp_adedDate.Name = "dtp_adedDate";
            this.dtp_adedDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_adedDate.TabIndex = 82;
            // 
            // cmbx_Cat
            // 
            this.cmbx_Cat.FormattingEnabled = true;
            this.cmbx_Cat.Location = new System.Drawing.Point(153, 225);
            this.cmbx_Cat.Name = "cmbx_Cat";
            this.cmbx_Cat.Size = new System.Drawing.Size(121, 21);
            this.cmbx_Cat.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 84;
            this.label1.Text = "Current Status";
            // 
            // cmbx_crntStats
            // 
            this.cmbx_crntStats.FormattingEnabled = true;
            this.cmbx_crntStats.Location = new System.Drawing.Point(153, 403);
            this.cmbx_crntStats.Name = "cmbx_crntStats";
            this.cmbx_crntStats.Size = new System.Drawing.Size(121, 21);
            this.cmbx_crntStats.TabIndex = 85;
            // 
            // lbl_QtyOfItm
            // 
            this.lbl_QtyOfItm.AutoSize = true;
            this.lbl_QtyOfItm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_QtyOfItm.Location = new System.Drawing.Point(34, 508);
            this.lbl_QtyOfItm.Name = "lbl_QtyOfItm";
            this.lbl_QtyOfItm.Size = new System.Drawing.Size(101, 17);
            this.lbl_QtyOfItm.TabIndex = 86;
            this.lbl_QtyOfItm.Text = "Quality Of Item";
            // 
            // lbl_rtrn
            // 
            this.lbl_rtrn.AutoSize = true;
            this.lbl_rtrn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_rtrn.Location = new System.Drawing.Point(29, 556);
            this.lbl_rtrn.Name = "lbl_rtrn";
            this.lbl_rtrn.Size = new System.Drawing.Size(49, 17);
            this.lbl_rtrn.TabIndex = 87;
            this.lbl_rtrn.Text = "Return";
            // 
            // lbl_addToStck
            // 
            this.lbl_addToStck.AutoSize = true;
            this.lbl_addToStck.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_addToStck.Location = new System.Drawing.Point(34, 601);
            this.lbl_addToStck.Name = "lbl_addToStck";
            this.lbl_addToStck.Size = new System.Drawing.Size(88, 17);
            this.lbl_addToStck.TabIndex = 88;
            this.lbl_addToStck.Text = "Add To Stock";
            // 
            // cmbx_qltyOfItm
            // 
            this.cmbx_qltyOfItm.FormattingEnabled = true;
            this.cmbx_qltyOfItm.Location = new System.Drawing.Point(209, 508);
            this.cmbx_qltyOfItm.Name = "cmbx_qltyOfItm";
            this.cmbx_qltyOfItm.Size = new System.Drawing.Size(121, 21);
            this.cmbx_qltyOfItm.TabIndex = 89;
            // 
            // cmbx_return
            // 
            this.cmbx_return.FormattingEnabled = true;
            this.cmbx_return.Location = new System.Drawing.Point(209, 556);
            this.cmbx_return.Name = "cmbx_return";
            this.cmbx_return.Size = new System.Drawing.Size(121, 21);
            this.cmbx_return.TabIndex = 90;
            // 
            // cmbx_addToStck
            // 
            this.cmbx_addToStck.FormattingEnabled = true;
            this.cmbx_addToStck.Location = new System.Drawing.Point(209, 597);
            this.cmbx_addToStck.Name = "cmbx_addToStck";
            this.cmbx_addToStck.Size = new System.Drawing.Size(121, 21);
            this.cmbx_addToStck.TabIndex = 91;
            // 
            // btn_updt
            // 
            this.btn_updt.Image = global::FamilyCareHospital.Properties.Resources.EDIT_edit_32px;
            this.btn_updt.Location = new System.Drawing.Point(621, 601);
            this.btn_updt.Name = "btn_updt";
            this.btn_updt.Size = new System.Drawing.Size(75, 47);
            this.btn_updt.TabIndex = 98;
            this.btn_updt.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.Image = global::FamilyCareHospital.Properties.Resources.DELETE_trash_32px;
            this.btn_del.Location = new System.Drawing.Point(738, 601);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 47);
            this.btn_del.TabIndex = 97;
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_del_KeyPress);
            // 
            // btn_add
            // 
            this.btn_add.Image = global::FamilyCareHospital.Properties.Resources.ADD_add_file_32px;
            this.btn_add.Location = new System.Drawing.Point(513, 601);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 47);
            this.btn_add.TabIndex = 96;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(153, 187);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 99;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // btn_back
            // 
            this.btn_back.Image = global::FamilyCareHospital.Properties.Resources.BACK_undo_32px;
            this.btn_back.Location = new System.Drawing.Point(1097, 14);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 41);
            this.btn_back.TabIndex = 100;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // PHpurchased_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_updt);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cmbx_addToStck);
            this.Controls.Add(this.cmbx_return);
            this.Controls.Add(this.cmbx_qltyOfItm);
            this.Controls.Add(this.lbl_addToStck);
            this.Controls.Add(this.lbl_rtrn);
            this.Controls.Add(this.lbl_QtyOfItm);
            this.Controls.Add(this.cmbx_crntStats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbx_Cat);
            this.Controls.Add(this.dtp_adedDate);
            this.Controls.Add(this.dtp_rcvdDate);
            this.Controls.Add(this.txt_odrID);
            this.Controls.Add(this.txt_itmName);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_supID);
            this.Controls.Add(this.dgv_purchsdOrdr);
            this.Controls.Add(this.btn_vw);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbx_vwCat);
            this.Controls.Add(this.cmbx_type);
            this.Controls.Add(this.lbl_itm);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_cat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_supp);
            this.Controls.Add(this.lbl_addDte);
            this.Controls.Add(this.lbl_crntSts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Name = "PHpurchased_order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHpurchased_order";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_purchsdOrdr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_crntSts;
        private System.Windows.Forms.Label lbl_addDte;
        private System.Windows.Forms.Label lbl_supp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_cat;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_itm;
        private System.Windows.Forms.Button btn_vw;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbx_vwCat;
        private System.Windows.Forms.ComboBox cmbx_type;
        private System.Windows.Forms.DataGridView dgv_purchsdOrdr;
        private System.Windows.Forms.TextBox txt_odrID;
        private System.Windows.Forms.TextBox txt_itmName;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_supID;
        private System.Windows.Forms.DateTimePicker dtp_rcvdDate;
        private System.Windows.Forms.DateTimePicker dtp_adedDate;
        private System.Windows.Forms.ComboBox cmbx_Cat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbx_crntStats;
        private System.Windows.Forms.Label lbl_QtyOfItm;
        private System.Windows.Forms.Label lbl_rtrn;
        private System.Windows.Forms.Label lbl_addToStck;
        private System.Windows.Forms.ComboBox cmbx_qltyOfItm;
        private System.Windows.Forms.ComboBox cmbx_return;
        private System.Windows.Forms.ComboBox cmbx_addToStck;
        private System.Windows.Forms.Button btn_updt;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_back;
    }
}