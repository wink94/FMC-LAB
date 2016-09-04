namespace FamilyCareHospital.Pharmacy_Interfaces
{
    partial class PHplaced_order
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
            this.lbl_odrID = new System.Windows.Forms.Label();
            this.lbl_addDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_cat = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_itmID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_vw = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_choseTyp = new System.Windows.Forms.Label();
            this.cmbx_cat = new System.Windows.Forms.ComboBox();
            this.cmbx_choseTyp = new System.Windows.Forms.ComboBox();
            this.dgv_PlcdOrdr = new System.Windows.Forms.DataGridView();
            this.txt_itmID = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_odrID = new System.Windows.Forms.TextBox();
            this.cmbx_vwCat = new System.Windows.Forms.ComboBox();
            this.dtp_addDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_rcvdDate = new System.Windows.Forms.DateTimePicker();
            this.cmbx_return = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_crntStus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbx_addToStck = new System.Windows.Forms.ComboBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_updt = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PlcdOrdr)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_odrID
            // 
            this.lbl_odrID.AutoSize = true;
            this.lbl_odrID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_odrID.Location = new System.Drawing.Point(31, 106);
            this.lbl_odrID.Name = "lbl_odrID";
            this.lbl_odrID.Size = new System.Drawing.Size(58, 17);
            this.lbl_odrID.TabIndex = 0;
            this.lbl_odrID.Text = "Order id";
            // 
            // lbl_addDate
            // 
            this.lbl_addDate.AutoSize = true;
            this.lbl_addDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_addDate.Location = new System.Drawing.Point(31, 303);
            this.lbl_addDate.Name = "lbl_addDate";
            this.lbl_addDate.Size = new System.Drawing.Size(79, 17);
            this.lbl_addDate.TabIndex = 1;
            this.lbl_addDate.Text = "Added date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(31, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Received date";
            // 
            // lbl_cat
            // 
            this.lbl_cat.AutoSize = true;
            this.lbl_cat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_cat.Location = new System.Drawing.Point(31, 257);
            this.lbl_cat.Name = "lbl_cat";
            this.lbl_cat.Size = new System.Drawing.Size(64, 17);
            this.lbl_cat.TabIndex = 6;
            this.lbl_cat.Text = "Category";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_name.Location = new System.Drawing.Point(31, 207);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 17);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "Name";
            // 
            // lbl_itmID
            // 
            this.lbl_itmID.AutoSize = true;
            this.lbl_itmID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_itmID.Location = new System.Drawing.Point(31, 154);
            this.lbl_itmID.Name = "lbl_itmID";
            this.lbl_itmID.Size = new System.Drawing.Size(51, 17);
            this.lbl_itmID.TabIndex = 8;
            this.lbl_itmID.Text = "Item id";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 30);
            this.label14.TabIndex = 26;
            this.label14.Text = "Placed order";
            // 
            // btn_vw
            // 
            this.btn_vw.Location = new System.Drawing.Point(1017, 151);
            this.btn_vw.Name = "btn_vw";
            this.btn_vw.Size = new System.Drawing.Size(75, 23);
            this.btn_vw.TabIndex = 41;
            this.btn_vw.Text = "View";
            this.btn_vw.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Image = global::FamilyCareHospital.Properties.Resources.SEARCH_search_32px;
            this.btn_search.Location = new System.Drawing.Point(724, 132);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 39);
            this.btn_search.TabIndex = 40;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_choseTyp
            // 
            this.lbl_choseTyp.AutoSize = true;
            this.lbl_choseTyp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_choseTyp.Location = new System.Drawing.Point(451, 148);
            this.lbl_choseTyp.Name = "lbl_choseTyp";
            this.lbl_choseTyp.Size = new System.Drawing.Size(84, 17);
            this.lbl_choseTyp.TabIndex = 39;
            this.lbl_choseTyp.Text = "Choose type";
            // 
            // cmbx_cat
            // 
            this.cmbx_cat.FormattingEnabled = true;
            this.cmbx_cat.Location = new System.Drawing.Point(169, 257);
            this.cmbx_cat.Name = "cmbx_cat";
            this.cmbx_cat.Size = new System.Drawing.Size(121, 21);
            this.cmbx_cat.TabIndex = 38;
            // 
            // cmbx_choseTyp
            // 
            this.cmbx_choseTyp.FormattingEnabled = true;
            this.cmbx_choseTyp.Location = new System.Drawing.Point(556, 151);
            this.cmbx_choseTyp.Name = "cmbx_choseTyp";
            this.cmbx_choseTyp.Size = new System.Drawing.Size(121, 21);
            this.cmbx_choseTyp.TabIndex = 37;
            // 
            // dgv_PlcdOrdr
            // 
            this.dgv_PlcdOrdr.AllowUserToAddRows = false;
            this.dgv_PlcdOrdr.AllowUserToDeleteRows = false;
            this.dgv_PlcdOrdr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PlcdOrdr.Location = new System.Drawing.Point(417, 231);
            this.dgv_PlcdOrdr.Name = "dgv_PlcdOrdr";
            this.dgv_PlcdOrdr.ReadOnly = true;
            this.dgv_PlcdOrdr.Size = new System.Drawing.Size(713, 419);
            this.dgv_PlcdOrdr.TabIndex = 42;
            this.dgv_PlcdOrdr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_PlcdOrdr_MouseClick);
            // 
            // txt_itmID
            // 
            this.txt_itmID.Location = new System.Drawing.Point(169, 154);
            this.txt_itmID.Name = "txt_itmID";
            this.txt_itmID.Size = new System.Drawing.Size(100, 20);
            this.txt_itmID.TabIndex = 43;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(169, 204);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 50;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // txt_odrID
            // 
            this.txt_odrID.Location = new System.Drawing.Point(169, 103);
            this.txt_odrID.Name = "txt_odrID";
            this.txt_odrID.Size = new System.Drawing.Size(100, 20);
            this.txt_odrID.TabIndex = 51;
            // 
            // cmbx_vwCat
            // 
            this.cmbx_vwCat.FormattingEnabled = true;
            this.cmbx_vwCat.Location = new System.Drawing.Point(848, 148);
            this.cmbx_vwCat.Name = "cmbx_vwCat";
            this.cmbx_vwCat.Size = new System.Drawing.Size(121, 21);
            this.cmbx_vwCat.TabIndex = 52;
            // 
            // dtp_addDate
            // 
            this.dtp_addDate.CustomFormat = "yyyy-MM-dd";
            this.dtp_addDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_addDate.Location = new System.Drawing.Point(169, 300);
            this.dtp_addDate.Name = "dtp_addDate";
            this.dtp_addDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_addDate.TabIndex = 53;
            // 
            // dtp_rcvdDate
            // 
            this.dtp_rcvdDate.CustomFormat = "yyyy-MM-dd";
            this.dtp_rcvdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_rcvdDate.Location = new System.Drawing.Point(169, 407);
            this.dtp_rcvdDate.Name = "dtp_rcvdDate";
            this.dtp_rcvdDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_rcvdDate.TabIndex = 54;
            // 
            // cmbx_return
            // 
            this.cmbx_return.FormattingEnabled = true;
            this.cmbx_return.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbx_return.Location = new System.Drawing.Point(169, 463);
            this.cmbx_return.Name = "cmbx_return";
            this.cmbx_return.Size = new System.Drawing.Size(121, 21);
            this.cmbx_return.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Return";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(31, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Current Status";
            // 
            // cmbx_crntStus
            // 
            this.cmbx_crntStus.FormattingEnabled = true;
            this.cmbx_crntStus.Items.AddRange(new object[] {
            "Received",
            "Pending"});
            this.cmbx_crntStus.Location = new System.Drawing.Point(169, 355);
            this.cmbx_crntStus.Name = "cmbx_crntStus";
            this.cmbx_crntStus.Size = new System.Drawing.Size(121, 21);
            this.cmbx_crntStus.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(31, 523);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "Add To Stock";
            // 
            // cmbx_addToStck
            // 
            this.cmbx_addToStck.FormattingEnabled = true;
            this.cmbx_addToStck.Items.AddRange(new object[] {
            "Done",
            "Pending"});
            this.cmbx_addToStck.Location = new System.Drawing.Point(169, 519);
            this.cmbx_addToStck.Name = "cmbx_addToStck";
            this.cmbx_addToStck.Size = new System.Drawing.Size(121, 21);
            this.cmbx_addToStck.TabIndex = 62;
            // 
            // btn_del
            // 
            this.btn_del.Image = global::FamilyCareHospital.Properties.Resources.DELETE_trash_32px;
            this.btn_del.Location = new System.Drawing.Point(245, 585);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 45);
            this.btn_del.TabIndex = 64;
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_del_KeyPress);
            // 
            // btn_updt
            // 
            this.btn_updt.Image = global::FamilyCareHospital.Properties.Resources.EDIT_edit_32px;
            this.btn_updt.Location = new System.Drawing.Point(139, 585);
            this.btn_updt.Name = "btn_updt";
            this.btn_updt.Size = new System.Drawing.Size(75, 45);
            this.btn_updt.TabIndex = 65;
            this.btn_updt.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Image = global::FamilyCareHospital.Properties.Resources.ADD_add_file_32px;
            this.btn_add.Location = new System.Drawing.Point(34, 585);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 45);
            this.btn_add.TabIndex = 66;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_back
            // 
            this.btn_back.Image = global::FamilyCareHospital.Properties.Resources.BACK_undo_32px;
            this.btn_back.Location = new System.Drawing.Point(1097, 14);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 41);
            this.btn_back.TabIndex = 89;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // PHplaced_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_updt);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.cmbx_addToStck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbx_crntStus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbx_return);
            this.Controls.Add(this.dtp_rcvdDate);
            this.Controls.Add(this.dtp_addDate);
            this.Controls.Add(this.cmbx_vwCat);
            this.Controls.Add(this.txt_odrID);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_itmID);
            this.Controls.Add(this.dgv_PlcdOrdr);
            this.Controls.Add(this.btn_vw);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_choseTyp);
            this.Controls.Add(this.cmbx_cat);
            this.Controls.Add(this.cmbx_choseTyp);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_itmID);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_cat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_addDate);
            this.Controls.Add(this.lbl_odrID);
            this.Name = "PHplaced_order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "placed_order";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PlcdOrdr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_odrID;
        private System.Windows.Forms.Label lbl_addDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_cat;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_itmID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_vw;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_choseTyp;
        private System.Windows.Forms.ComboBox cmbx_cat;
        private System.Windows.Forms.ComboBox cmbx_choseTyp;
        private System.Windows.Forms.DataGridView dgv_PlcdOrdr;
        private System.Windows.Forms.TextBox txt_itmID;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_odrID;
        private System.Windows.Forms.ComboBox cmbx_vwCat;
        private System.Windows.Forms.DateTimePicker dtp_addDate;
        private System.Windows.Forms.DateTimePicker dtp_rcvdDate;
        private System.Windows.Forms.ComboBox cmbx_return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_crntStus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbx_addToStck;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_updt;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_back;
    }
}