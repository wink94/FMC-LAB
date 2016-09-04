namespace FamilyCareHospital
{
    partial class Ward_Admin_View_Drugs
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
            this.panel1_ViewDrugs = new System.Windows.Forms.Panel();
            this.grpBox_search = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.grpBox1_ViewDrugs = new System.Windows.Forms.GroupBox();
            this.panel2_ViewDrugs = new System.Windows.Forms.Panel();
            this.lbl_DrugName = new System.Windows.Forms.Label();
            this.txt_DrugName = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.btn_Prin_ViewDrugs = new System.Windows.Forms.Button();
            this.dataGridView1_ViewDrugs = new System.Windows.Forms.DataGridView();
            this.lbl_ViewDrugs = new System.Windows.Forms.Label();
            this.btn_Back_ViewDrugs = new System.Windows.Forms.Button();
            this.panel1_ViewDrugs.SuspendLayout();
            this.grpBox_search.SuspendLayout();
            this.grpBox1_ViewDrugs.SuspendLayout();
            this.panel2_ViewDrugs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_ViewDrugs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_ViewDrugs
            // 
            this.panel1_ViewDrugs.BackColor = System.Drawing.Color.Azure;
            this.panel1_ViewDrugs.Controls.Add(this.grpBox_search);
            this.panel1_ViewDrugs.Controls.Add(this.grpBox1_ViewDrugs);
            this.panel1_ViewDrugs.Controls.Add(this.dataGridView1_ViewDrugs);
            this.panel1_ViewDrugs.Location = new System.Drawing.Point(31, 101);
            this.panel1_ViewDrugs.Name = "panel1_ViewDrugs";
            this.panel1_ViewDrugs.Size = new System.Drawing.Size(937, 484);
            this.panel1_ViewDrugs.TabIndex = 23;
            // 
            // grpBox_search
            // 
            this.grpBox_search.Controls.Add(this.txt_search);
            this.grpBox_search.Controls.Add(this.cmb_search);
            this.grpBox_search.Controls.Add(this.btn_Search);
            this.grpBox_search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_search.Location = new System.Drawing.Point(12, 26);
            this.grpBox_search.Name = "grpBox_search";
            this.grpBox_search.Size = new System.Drawing.Size(511, 79);
            this.grpBox_search.TabIndex = 62;
            this.grpBox_search.TabStop = false;
            this.grpBox_search.Text = "Search By";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(177, 33);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(232, 23);
            this.txt_search.TabIndex = 13;
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // cmb_search
            // 
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Items.AddRange(new object[] {
            "Drug Name",
            "Quantity",
            "Expiry Date"});
            this.cmb_search.Location = new System.Drawing.Point(6, 33);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(165, 23);
            this.cmb_search.TabIndex = 16;
            this.cmb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_search_KeyPress);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_Search.Image = global::FamilyCareHospital.Properties.Resources.SEARCH_search_32px;
            this.btn_Search.Location = new System.Drawing.Point(415, 22);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(84, 44);
            this.btn_Search.TabIndex = 14;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // grpBox1_ViewDrugs
            // 
            this.grpBox1_ViewDrugs.Controls.Add(this.panel2_ViewDrugs);
            this.grpBox1_ViewDrugs.Controls.Add(this.btn_Prin_ViewDrugs);
            this.grpBox1_ViewDrugs.Location = new System.Drawing.Point(545, 61);
            this.grpBox1_ViewDrugs.Margin = new System.Windows.Forms.Padding(0);
            this.grpBox1_ViewDrugs.Name = "grpBox1_ViewDrugs";
            this.grpBox1_ViewDrugs.Padding = new System.Windows.Forms.Padding(0);
            this.grpBox1_ViewDrugs.Size = new System.Drawing.Size(383, 375);
            this.grpBox1_ViewDrugs.TabIndex = 61;
            this.grpBox1_ViewDrugs.TabStop = false;
            this.grpBox1_ViewDrugs.Text = "Request Drugs";
            // 
            // panel2_ViewDrugs
            // 
            this.panel2_ViewDrugs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2_ViewDrugs.Controls.Add(this.lbl_DrugName);
            this.panel2_ViewDrugs.Controls.Add(this.txt_DrugName);
            this.panel2_ViewDrugs.Controls.Add(this.txt_Quantity);
            this.panel2_ViewDrugs.Controls.Add(this.lbl_Quantity);
            this.panel2_ViewDrugs.Location = new System.Drawing.Point(12, 38);
            this.panel2_ViewDrugs.Name = "panel2_ViewDrugs";
            this.panel2_ViewDrugs.Size = new System.Drawing.Size(357, 170);
            this.panel2_ViewDrugs.TabIndex = 11;
            // 
            // lbl_DrugName
            // 
            this.lbl_DrugName.AutoSize = true;
            this.lbl_DrugName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DrugName.Location = new System.Drawing.Point(13, 41);
            this.lbl_DrugName.Name = "lbl_DrugName";
            this.lbl_DrugName.Size = new System.Drawing.Size(86, 20);
            this.lbl_DrugName.TabIndex = 0;
            this.lbl_DrugName.Text = "Drug Name";
            // 
            // txt_DrugName
            // 
            this.txt_DrugName.Enabled = false;
            this.txt_DrugName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DrugName.Location = new System.Drawing.Point(133, 34);
            this.txt_DrugName.Name = "txt_DrugName";
            this.txt_DrugName.Size = new System.Drawing.Size(209, 27);
            this.txt_DrugName.TabIndex = 3;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Enabled = false;
            this.txt_Quantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(133, 100);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(209, 27);
            this.txt_Quantity.TabIndex = 4;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(14, 107);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(65, 20);
            this.lbl_Quantity.TabIndex = 1;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // btn_Prin_ViewDrugs
            // 
            this.btn_Prin_ViewDrugs.BackColor = System.Drawing.Color.Teal;
            this.btn_Prin_ViewDrugs.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Prin_ViewDrugs.FlatAppearance.BorderSize = 5;
            this.btn_Prin_ViewDrugs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Prin_ViewDrugs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prin_ViewDrugs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Prin_ViewDrugs.Image = global::FamilyCareHospital.Properties.Resources.PRINT_print_48px;
            this.btn_Prin_ViewDrugs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Prin_ViewDrugs.Location = new System.Drawing.Point(132, 254);
            this.btn_Prin_ViewDrugs.Name = "btn_Prin_ViewDrugs";
            this.btn_Prin_ViewDrugs.Size = new System.Drawing.Size(138, 85);
            this.btn_Prin_ViewDrugs.TabIndex = 60;
            this.btn_Prin_ViewDrugs.Text = "Request For Durgs";
            this.btn_Prin_ViewDrugs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Prin_ViewDrugs.UseVisualStyleBackColor = false;
            this.btn_Prin_ViewDrugs.Click += new System.EventHandler(this.btn_Prin_ViewDrugs_Click);
            // 
            // dataGridView1_ViewDrugs
            // 
            this.dataGridView1_ViewDrugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_ViewDrugs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1_ViewDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_ViewDrugs.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1_ViewDrugs.Name = "dataGridView1_ViewDrugs";
            this.dataGridView1_ViewDrugs.ReadOnly = true;
            this.dataGridView1_ViewDrugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_ViewDrugs.Size = new System.Drawing.Size(511, 315);
            this.dataGridView1_ViewDrugs.TabIndex = 21;
            this.dataGridView1_ViewDrugs.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_ViewDrugs_CellFormatting);
            this.dataGridView1_ViewDrugs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_ViewDrugs_MouseClick);
            // 
            // lbl_ViewDrugs
            // 
            this.lbl_ViewDrugs.AutoSize = true;
            this.lbl_ViewDrugs.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ViewDrugs.ForeColor = System.Drawing.Color.White;
            this.lbl_ViewDrugs.Location = new System.Drawing.Point(24, 31);
            this.lbl_ViewDrugs.Name = "lbl_ViewDrugs";
            this.lbl_ViewDrugs.Size = new System.Drawing.Size(169, 37);
            this.lbl_ViewDrugs.TabIndex = 21;
            this.lbl_ViewDrugs.Text = "View Drugs";
            // 
            // btn_Back_ViewDrugs
            // 
            this.btn_Back_ViewDrugs.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Back_ViewDrugs.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Back_ViewDrugs.FlatAppearance.BorderSize = 5;
            this.btn_Back_ViewDrugs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Back_ViewDrugs.Image = global::FamilyCareHospital.Properties.Resources.BACK_undo_32px;
            this.btn_Back_ViewDrugs.Location = new System.Drawing.Point(894, 31);
            this.btn_Back_ViewDrugs.Name = "btn_Back_ViewDrugs";
            this.btn_Back_ViewDrugs.Size = new System.Drawing.Size(74, 41);
            this.btn_Back_ViewDrugs.TabIndex = 22;
            this.btn_Back_ViewDrugs.UseVisualStyleBackColor = false;
            this.btn_Back_ViewDrugs.Click += new System.EventHandler(this.btn_Back_ViewDrugs_Click);
            // 
            // Ward_Admin_View_Drugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(993, 616);
            this.Controls.Add(this.panel1_ViewDrugs);
            this.Controls.Add(this.btn_Back_ViewDrugs);
            this.Controls.Add(this.lbl_ViewDrugs);
            this.Name = "Ward_Admin_View_Drugs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drug Store";
            this.panel1_ViewDrugs.ResumeLayout(false);
            this.grpBox_search.ResumeLayout(false);
            this.grpBox_search.PerformLayout();
            this.grpBox1_ViewDrugs.ResumeLayout(false);
            this.panel2_ViewDrugs.ResumeLayout(false);
            this.panel2_ViewDrugs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_ViewDrugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1_ViewDrugs;
        private System.Windows.Forms.DataGridView dataGridView1_ViewDrugs;
        private System.Windows.Forms.Button btn_Back_ViewDrugs;
        private System.Windows.Forms.Label lbl_ViewDrugs;
        private System.Windows.Forms.Button btn_Prin_ViewDrugs;
        private System.Windows.Forms.GroupBox grpBox1_ViewDrugs;
        private System.Windows.Forms.Panel panel2_ViewDrugs;
        private System.Windows.Forms.Label lbl_DrugName;
        private System.Windows.Forms.TextBox txt_DrugName;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.GroupBox grpBox_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cmb_search;
        private System.Windows.Forms.Button btn_Search;
    }
}