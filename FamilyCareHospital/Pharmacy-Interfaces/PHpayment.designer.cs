namespace FamilyCareHospital.Pharmacy_Interfaces
{
    partial class PHpayment
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
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_payID = new System.Windows.Forms.Label();
            this.lbl_amt = new System.Windows.Forms.Label();
            this.lbl_supID = new System.Windows.Forms.Label();
            this.lbl_odrID = new System.Windows.Forms.Label();
            this.txt_pID = new System.Windows.Forms.TextBox();
            this.txt_amnt = new System.Windows.Forms.TextBox();
            this.txt_supID = new System.Windows.Forms.TextBox();
            this.txt_oID = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_updt = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_choseTyp = new System.Windows.Forms.Label();
            this.cmbx_typ = new System.Windows.Forms.ComboBox();
            this.dgv_pymnt = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_payType = new System.Windows.Forms.Label();
            this.cmbx_pType = new System.Windows.Forms.ComboBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_vwAll = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pymnt)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 30);
            this.label14.TabIndex = 27;
            this.label14.Text = "Payment";
            // 
            // lbl_payID
            // 
            this.lbl_payID.AutoSize = true;
            this.lbl_payID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_payID.Location = new System.Drawing.Point(14, 124);
            this.lbl_payID.Name = "lbl_payID";
            this.lbl_payID.Size = new System.Drawing.Size(79, 17);
            this.lbl_payID.TabIndex = 28;
            this.lbl_payID.Text = "Payment ID";
            // 
            // lbl_amt
            // 
            this.lbl_amt.AutoSize = true;
            this.lbl_amt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_amt.Location = new System.Drawing.Point(14, 288);
            this.lbl_amt.Name = "lbl_amt";
            this.lbl_amt.Size = new System.Drawing.Size(58, 17);
            this.lbl_amt.TabIndex = 29;
            this.lbl_amt.Text = "Amount";
            // 
            // lbl_supID
            // 
            this.lbl_supID.AutoSize = true;
            this.lbl_supID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_supID.Location = new System.Drawing.Point(14, 235);
            this.lbl_supID.Name = "lbl_supID";
            this.lbl_supID.Size = new System.Drawing.Size(74, 17);
            this.lbl_supID.TabIndex = 30;
            this.lbl_supID.Text = "Supplier ID";
            // 
            // lbl_odrID
            // 
            this.lbl_odrID.AutoSize = true;
            this.lbl_odrID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_odrID.Location = new System.Drawing.Point(14, 181);
            this.lbl_odrID.Name = "lbl_odrID";
            this.lbl_odrID.Size = new System.Drawing.Size(60, 17);
            this.lbl_odrID.TabIndex = 31;
            this.lbl_odrID.Text = "Order ID";
            // 
            // txt_pID
            // 
            this.txt_pID.Location = new System.Drawing.Point(112, 124);
            this.txt_pID.Name = "txt_pID";
            this.txt_pID.Size = new System.Drawing.Size(121, 20);
            this.txt_pID.TabIndex = 32;
            // 
            // txt_amnt
            // 
            this.txt_amnt.Location = new System.Drawing.Point(112, 288);
            this.txt_amnt.Name = "txt_amnt";
            this.txt_amnt.Size = new System.Drawing.Size(121, 20);
            this.txt_amnt.TabIndex = 34;
            this.txt_amnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amntID_KeyPress);
            // 
            // txt_supID
            // 
            this.txt_supID.Location = new System.Drawing.Point(112, 232);
            this.txt_supID.Name = "txt_supID";
            this.txt_supID.Size = new System.Drawing.Size(121, 20);
            this.txt_supID.TabIndex = 35;
            // 
            // txt_oID
            // 
            this.txt_oID.Location = new System.Drawing.Point(112, 178);
            this.txt_oID.Name = "txt_oID";
            this.txt_oID.Size = new System.Drawing.Size(121, 20);
            this.txt_oID.TabIndex = 36;
            // 
            // btn_add
            // 
            this.btn_add.Image = global::FamilyCareHospital.Properties.Resources.ADD_add_file_32px;
            this.btn_add.Location = new System.Drawing.Point(17, 440);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(103, 45);
            this.btn_add.TabIndex = 43;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_updt
            // 
            this.btn_updt.Image = global::FamilyCareHospital.Properties.Resources.EDIT_edit_32px;
            this.btn_updt.Location = new System.Drawing.Point(145, 440);
            this.btn_updt.Name = "btn_updt";
            this.btn_updt.Size = new System.Drawing.Size(88, 45);
            this.btn_updt.TabIndex = 41;
            this.btn_updt.UseVisualStyleBackColor = true;
            this.btn_updt.Click += new System.EventHandler(this.btn_updt_Click);
            // 
            // btn_search
            // 
            this.btn_search.Image = global::FamilyCareHospital.Properties.Resources.SEARCH_search_32px;
            this.btn_search.Location = new System.Drawing.Point(796, 115);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 42);
            this.btn_search.TabIndex = 46;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_choseTyp
            // 
            this.lbl_choseTyp.AutoSize = true;
            this.lbl_choseTyp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_choseTyp.Location = new System.Drawing.Point(430, 124);
            this.lbl_choseTyp.Name = "lbl_choseTyp";
            this.lbl_choseTyp.Size = new System.Drawing.Size(84, 17);
            this.lbl_choseTyp.TabIndex = 45;
            this.lbl_choseTyp.Text = "Choose type";
            // 
            // cmbx_typ
            // 
            this.cmbx_typ.FormattingEnabled = true;
            this.cmbx_typ.Items.AddRange(new object[] {
            "Payment ID",
            "Order ID",
            "Supplier ID"});
            this.cmbx_typ.Location = new System.Drawing.Point(535, 127);
            this.cmbx_typ.Name = "cmbx_typ";
            this.cmbx_typ.Size = new System.Drawing.Size(121, 21);
            this.cmbx_typ.TabIndex = 44;
            // 
            // dgv_pymnt
            // 
            this.dgv_pymnt.AllowUserToAddRows = false;
            this.dgv_pymnt.AllowUserToDeleteRows = false;
            this.dgv_pymnt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pymnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pymnt.Location = new System.Drawing.Point(433, 178);
            this.dgv_pymnt.Name = "dgv_pymnt";
            this.dgv_pymnt.ReadOnly = true;
            this.dgv_pymnt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pymnt.Size = new System.Drawing.Size(713, 380);
            this.dgv_pymnt.TabIndex = 47;
            this.dgv_pymnt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_pymnt_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 38);
            this.button1.TabIndex = 48;
            this.button1.Text = "Monthly payment reports";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_payType
            // 
            this.lbl_payType.AutoSize = true;
            this.lbl_payType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_payType.Location = new System.Drawing.Point(14, 338);
            this.lbl_payType.Name = "lbl_payType";
            this.lbl_payType.Size = new System.Drawing.Size(93, 17);
            this.lbl_payType.TabIndex = 49;
            this.lbl_payType.Text = "Payment type";
            // 
            // cmbx_pType
            // 
            this.cmbx_pType.FormattingEnabled = true;
            this.cmbx_pType.Items.AddRange(new object[] {
            "Cash",
            "Cheque"});
            this.cmbx_pType.Location = new System.Drawing.Point(112, 334);
            this.cmbx_pType.Name = "cmbx_pType";
            this.cmbx_pType.Size = new System.Drawing.Size(121, 21);
            this.cmbx_pType.TabIndex = 50;
            // 
            // btn_del
            // 
            this.btn_del.Image = global::FamilyCareHospital.Properties.Resources.DELETE_trash_32px;
            this.btn_del.Location = new System.Drawing.Point(262, 440);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(87, 45);
            this.btn_del.TabIndex = 51;
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // txt_search
            // 
            this.txt_search.AutoCompleteCustomSource.AddRange(new string[] {
            "Payment ID",
            "Order ID",
            "Supplier ID"});
            this.txt_search.Location = new System.Drawing.Point(674, 129);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 52;
            this.txt_search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_search_MouseClick);
            // 
            // btn_vwAll
            // 
            this.btn_vwAll.Location = new System.Drawing.Point(1057, 127);
            this.btn_vwAll.Name = "btn_vwAll";
            this.btn_vwAll.Size = new System.Drawing.Size(75, 23);
            this.btn_vwAll.TabIndex = 53;
            this.btn_vwAll.Text = "View All";
            this.btn_vwAll.UseVisualStyleBackColor = true;
            this.btn_vwAll.Click += new System.EventHandler(this.btn_vwAll_Click);
            // 
            // btn_back
            // 
            this.btn_back.Image = global::FamilyCareHospital.Properties.Resources.BACK_undo_32px;
            this.btn_back.Location = new System.Drawing.Point(1097, 14);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 41);
            this.btn_back.TabIndex = 102;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // PHpayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_vwAll);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.cmbx_pType);
            this.Controls.Add(this.lbl_payType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_pymnt);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_choseTyp);
            this.Controls.Add(this.cmbx_typ);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_updt);
            this.Controls.Add(this.txt_oID);
            this.Controls.Add(this.txt_supID);
            this.Controls.Add(this.txt_amnt);
            this.Controls.Add(this.txt_pID);
            this.Controls.Add(this.lbl_odrID);
            this.Controls.Add(this.lbl_supID);
            this.Controls.Add(this.lbl_amt);
            this.Controls.Add(this.lbl_payID);
            this.Controls.Add(this.label14);
            this.Name = "PHpayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHpayment";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pymnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_payID;
        private System.Windows.Forms.Label lbl_amt;
        private System.Windows.Forms.Label lbl_supID;
        private System.Windows.Forms.Label lbl_odrID;
        private System.Windows.Forms.TextBox txt_pID;
        private System.Windows.Forms.TextBox txt_amnt;
        private System.Windows.Forms.TextBox txt_supID;
        private System.Windows.Forms.TextBox txt_oID;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_updt;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_choseTyp;
        private System.Windows.Forms.ComboBox cmbx_typ;
        private System.Windows.Forms.DataGridView dgv_pymnt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_payType;
        private System.Windows.Forms.ComboBox cmbx_pType;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_vwAll;
        private System.Windows.Forms.Button btn_back;
    }
}