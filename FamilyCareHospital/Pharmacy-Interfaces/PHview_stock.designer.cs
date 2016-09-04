namespace FamilyCareHospital.Pharmacy_Interfaces
{
    partial class PHview_stock
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_secondDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_firstDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_outStock_Find = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_outStockRpt = new System.Windows.Forms.Button();
            this.btn_expItmRpt = new System.Windows.Forms.Button();
            this.btn_monthStockRpt = new System.Windows.Forms.Button();
            this.dgv_viwstk = new System.Windows.Forms.DataGridView();
            this.btn_vw = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbx_cat = new System.Windows.Forms.ComboBox();
            this.cmbx_chooseTyp = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_vwall = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_viwstk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "View stock";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_secondDate);
            this.groupBox1.Controls.Add(this.dtp_firstDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(17, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Out of stock items";
            // 
            // dtp_secondDate
            // 
            this.dtp_secondDate.CustomFormat = "yyyy-MM-dd";
            this.dtp_secondDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_secondDate.Location = new System.Drawing.Point(61, 121);
            this.dtp_secondDate.Name = "dtp_secondDate";
            this.dtp_secondDate.Size = new System.Drawing.Size(200, 25);
            this.dtp_secondDate.TabIndex = 4;
            // 
            // dtp_firstDate
            // 
            this.dtp_firstDate.CustomFormat = "yyyy-MM-dd";
            this.dtp_firstDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_firstDate.Location = new System.Drawing.Point(61, 32);
            this.dtp_firstDate.Name = "dtp_firstDate";
            this.dtp_firstDate.Size = new System.Drawing.Size(191, 25);
            this.dtp_firstDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Between";
            // 
            // btn_outStock_Find
            // 
            this.btn_outStock_Find.Location = new System.Drawing.Point(132, 298);
            this.btn_outStock_Find.Name = "btn_outStock_Find";
            this.btn_outStock_Find.Size = new System.Drawing.Size(65, 23);
            this.btn_outStock_Find.TabIndex = 3;
            this.btn_outStock_Find.Text = "Find";
            this.btn_outStock_Find.UseVisualStyleBackColor = true;
            this.btn_outStock_Find.Click += new System.EventHandler(this.btn_outStock_Find_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_outStockRpt);
            this.groupBox2.Controls.Add(this.btn_expItmRpt);
            this.groupBox2.Controls.Add(this.btn_monthStockRpt);
            this.groupBox2.Location = new System.Drawing.Point(17, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 205);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reports";
            // 
            // btn_outStockRpt
            // 
            this.btn_outStockRpt.Location = new System.Drawing.Point(18, 101);
            this.btn_outStockRpt.Name = "btn_outStockRpt";
            this.btn_outStockRpt.Size = new System.Drawing.Size(265, 23);
            this.btn_outStockRpt.TabIndex = 5;
            this.btn_outStockRpt.Text = "Out of stock items report";
            this.btn_outStockRpt.UseVisualStyleBackColor = true;
            // 
            // btn_expItmRpt
            // 
            this.btn_expItmRpt.Location = new System.Drawing.Point(18, 150);
            this.btn_expItmRpt.Name = "btn_expItmRpt";
            this.btn_expItmRpt.Size = new System.Drawing.Size(265, 23);
            this.btn_expItmRpt.TabIndex = 4;
            this.btn_expItmRpt.Text = "Monthly expired item report";
            this.btn_expItmRpt.UseVisualStyleBackColor = true;
            // 
            // btn_monthStockRpt
            // 
            this.btn_monthStockRpt.Location = new System.Drawing.Point(18, 56);
            this.btn_monthStockRpt.Name = "btn_monthStockRpt";
            this.btn_monthStockRpt.Size = new System.Drawing.Size(265, 23);
            this.btn_monthStockRpt.TabIndex = 3;
            this.btn_monthStockRpt.Text = "Monthly stock report";
            this.btn_monthStockRpt.UseVisualStyleBackColor = true;
            // 
            // dgv_viwstk
            // 
            this.dgv_viwstk.AllowUserToAddRows = false;
            this.dgv_viwstk.AllowUserToDeleteRows = false;
            this.dgv_viwstk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_viwstk.Location = new System.Drawing.Point(387, 158);
            this.dgv_viwstk.Name = "dgv_viwstk";
            this.dgv_viwstk.ReadOnly = true;
            this.dgv_viwstk.Size = new System.Drawing.Size(713, 419);
            this.dgv_viwstk.TabIndex = 37;
            // 
            // btn_vw
            // 
            this.btn_vw.Location = new System.Drawing.Point(1025, 124);
            this.btn_vw.Name = "btn_vw";
            this.btn_vw.Size = new System.Drawing.Size(75, 23);
            this.btn_vw.TabIndex = 78;
            this.btn_vw.Text = "View";
            this.btn_vw.UseVisualStyleBackColor = true;
            this.btn_vw.Click += new System.EventHandler(this.btn_vw_Click);
            // 
            // btn_search
            // 
            this.btn_search.Image = global::FamilyCareHospital.Properties.Resources.SEARCH_search_32px;
            this.btn_search.Location = new System.Drawing.Point(719, 102);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 40);
            this.btn_search.TabIndex = 77;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(384, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 17);
            this.label16.TabIndex = 76;
            this.label16.Text = "Choose type";
            // 
            // cmbx_cat
            // 
            this.cmbx_cat.FormattingEnabled = true;
            this.cmbx_cat.Location = new System.Drawing.Point(898, 126);
            this.cmbx_cat.Name = "cmbx_cat";
            this.cmbx_cat.Size = new System.Drawing.Size(121, 21);
            this.cmbx_cat.TabIndex = 75;
            this.cmbx_cat.Text = "select";
            // 
            // cmbx_chooseTyp
            // 
            this.cmbx_chooseTyp.FormattingEnabled = true;
            this.cmbx_chooseTyp.Items.AddRange(new object[] {
            "Item ID",
            "Item Name",
            "Batch Number"});
            this.cmbx_chooseTyp.Location = new System.Drawing.Point(486, 122);
            this.cmbx_chooseTyp.Name = "cmbx_chooseTyp";
            this.cmbx_chooseTyp.Size = new System.Drawing.Size(121, 21);
            this.cmbx_chooseTyp.TabIndex = 74;
            // 
            // btn_back
            // 
            this.btn_back.Image = global::FamilyCareHospital.Properties.Resources.BACK_undo_32px;
            this.btn_back.Location = new System.Drawing.Point(1097, 17);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 42);
            this.btn_back.TabIndex = 79;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_vwall
            // 
            this.btn_vwall.Location = new System.Drawing.Point(1025, 81);
            this.btn_vwall.Name = "btn_vwall";
            this.btn_vwall.Size = new System.Drawing.Size(75, 23);
            this.btn_vwall.TabIndex = 80;
            this.btn_vwall.Text = "View All";
            this.btn_vwall.UseVisualStyleBackColor = true;
            this.btn_vwall.Click += new System.EventHandler(this.btn_vwall_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(840, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Category";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(613, 122);
            this.txt_search.Name = "txt_search";
            this.txt_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 82;
            this.txt_search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_search_MouseClick);
            // 
            // PHview_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_vwall);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_vw);
            this.Controls.Add(this.btn_outStock_Find);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbx_cat);
            this.Controls.Add(this.cmbx_chooseTyp);
            this.Controls.Add(this.dgv_viwstk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "PHview_stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Stock";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_viwstk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_outStock_Find;
        private System.Windows.Forms.DateTimePicker dtp_firstDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_outStockRpt;
        private System.Windows.Forms.Button btn_expItmRpt;
        private System.Windows.Forms.Button btn_monthStockRpt;
        private System.Windows.Forms.DataGridView dgv_viwstk;
        private System.Windows.Forms.Button btn_vw;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbx_cat;
        private System.Windows.Forms.ComboBox cmbx_chooseTyp;
        private System.Windows.Forms.DateTimePicker dtp_secondDate;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_vwall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_search;
    }
}