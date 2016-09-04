namespace FamilyCareHospital
{
    partial class Ward_Admin_Manage_Drug_Store
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_ManaDrugStore = new System.Windows.Forms.Label();
            this.btn_Back_ManaDrugStr = new System.Windows.Forms.Button();
            this.panel1_Manag_Drug_Store = new System.Windows.Forms.Panel();
            this.btnRefresh_MangDrugStore = new System.Windows.Forms.Button();
            this.dataGridView1_MangDrugStore = new System.Windows.Forms.DataGridView();
            this.btn_clickForUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpBox_MangDrugStore = new System.Windows.Forms.GroupBox();
            this.lbl_search_DrugName = new System.Windows.Forms.Label();
            this.txtSearchKeyWord_MangDrugStore = new System.Windows.Forms.TextBox();
            this.btnSearch_MangDrugStore = new System.Windows.Forms.Button();
            this.grpBox1_MangDrugStore = new System.Windows.Forms.GroupBox();
            this.btnClear_Content_MangDrugStore = new System.Windows.Forms.Button();
            this.panel2_MangDrugStore = new System.Windows.Forms.Panel();
            this.dateTimePicker1_ManageDrugs = new System.Windows.Forms.DateTimePicker();
            this.lbl_ExDate = new System.Windows.Forms.Label();
            this.lbl_DrugName = new System.Windows.Forms.Label();
            this.txt_DrugName = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.btnDelete_MangDrugStore = new System.Windows.Forms.Button();
            this.btnUpdate_MangDrugStore = new System.Windows.Forms.Button();
            this.btn_Save_MangDrugStore = new System.Windows.Forms.Button();
            this.panel1_Manag_Drug_Store.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_MangDrugStore)).BeginInit();
            this.grpBox_MangDrugStore.SuspendLayout();
            this.grpBox1_MangDrugStore.SuspendLayout();
            this.panel2_MangDrugStore.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ManaDrugStore
            // 
            this.lbl_ManaDrugStore.AutoSize = true;
            this.lbl_ManaDrugStore.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManaDrugStore.ForeColor = System.Drawing.Color.White;
            this.lbl_ManaDrugStore.Location = new System.Drawing.Point(21, 35);
            this.lbl_ManaDrugStore.Name = "lbl_ManaDrugStore";
            this.lbl_ManaDrugStore.Size = new System.Drawing.Size(275, 37);
            this.lbl_ManaDrugStore.TabIndex = 17;
            this.lbl_ManaDrugStore.Text = "Manage Drug Store";
            // 
            // btn_Back_ManaDrugStr
            // 
            this.btn_Back_ManaDrugStr.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Back_ManaDrugStr.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Back_ManaDrugStr.FlatAppearance.BorderSize = 5;
            this.btn_Back_ManaDrugStr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Back_ManaDrugStr.Image = global::FamilyCareHospital.Properties.Resources.BACK_undo_32px;
            this.btn_Back_ManaDrugStr.Location = new System.Drawing.Point(891, 35);
            this.btn_Back_ManaDrugStr.Name = "btn_Back_ManaDrugStr";
            this.btn_Back_ManaDrugStr.Size = new System.Drawing.Size(74, 41);
            this.btn_Back_ManaDrugStr.TabIndex = 19;
            this.btn_Back_ManaDrugStr.UseVisualStyleBackColor = false;
            this.btn_Back_ManaDrugStr.Click += new System.EventHandler(this.btn_Back_ManaDrugStr_Click);
            // 
            // panel1_Manag_Drug_Store
            // 
            this.panel1_Manag_Drug_Store.BackColor = System.Drawing.Color.Azure;
            this.panel1_Manag_Drug_Store.Controls.Add(this.btnRefresh_MangDrugStore);
            this.panel1_Manag_Drug_Store.Controls.Add(this.dataGridView1_MangDrugStore);
            this.panel1_Manag_Drug_Store.Controls.Add(this.grpBox_MangDrugStore);
            this.panel1_Manag_Drug_Store.Controls.Add(this.grpBox1_MangDrugStore);
            this.panel1_Manag_Drug_Store.Location = new System.Drawing.Point(28, 105);
            this.panel1_Manag_Drug_Store.Name = "panel1_Manag_Drug_Store";
            this.panel1_Manag_Drug_Store.Size = new System.Drawing.Size(937, 484);
            this.panel1_Manag_Drug_Store.TabIndex = 20;
            // 
            // btnRefresh_MangDrugStore
            // 
            this.btnRefresh_MangDrugStore.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh_MangDrugStore.Image = global::FamilyCareHospital.Properties.Resources.REFRESH_refresh_32px;
            this.btnRefresh_MangDrugStore.Location = new System.Drawing.Point(837, 386);
            this.btnRefresh_MangDrugStore.Name = "btnRefresh_MangDrugStore";
            this.btnRefresh_MangDrugStore.Size = new System.Drawing.Size(84, 44);
            this.btnRefresh_MangDrugStore.TabIndex = 22;
            this.btnRefresh_MangDrugStore.UseVisualStyleBackColor = false;
            this.btnRefresh_MangDrugStore.Click += new System.EventHandler(this.btnRefresh_MangDrugStore_Click);
            // 
            // dataGridView1_MangDrugStore
            // 
            this.dataGridView1_MangDrugStore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_MangDrugStore.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1_MangDrugStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_MangDrugStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_clickForUpdate});
            this.dataGridView1_MangDrugStore.Location = new System.Drawing.Point(419, 125);
            this.dataGridView1_MangDrugStore.Name = "dataGridView1_MangDrugStore";
            this.dataGridView1_MangDrugStore.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1_MangDrugStore.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1_MangDrugStore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_MangDrugStore.Size = new System.Drawing.Size(502, 255);
            this.dataGridView1_MangDrugStore.TabIndex = 21;
            this.dataGridView1_MangDrugStore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_MangDrugStore_CellContentClick);
            this.dataGridView1_MangDrugStore.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_MangDrugStore_CellFormatting);
            this.dataGridView1_MangDrugStore.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MangDrugStore_MouseClick);
            // 
            // btn_clickForUpdate
            // 
            this.btn_clickForUpdate.HeaderText = "";
            this.btn_clickForUpdate.Name = "btn_clickForUpdate";
            this.btn_clickForUpdate.ReadOnly = true;
            // 
            // grpBox_MangDrugStore
            // 
            this.grpBox_MangDrugStore.Controls.Add(this.lbl_search_DrugName);
            this.grpBox_MangDrugStore.Controls.Add(this.txtSearchKeyWord_MangDrugStore);
            this.grpBox_MangDrugStore.Controls.Add(this.btnSearch_MangDrugStore);
            this.grpBox_MangDrugStore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_MangDrugStore.Location = new System.Drawing.Point(419, 18);
            this.grpBox_MangDrugStore.Name = "grpBox_MangDrugStore";
            this.grpBox_MangDrugStore.Size = new System.Drawing.Size(502, 79);
            this.grpBox_MangDrugStore.TabIndex = 20;
            this.grpBox_MangDrugStore.TabStop = false;
            this.grpBox_MangDrugStore.Text = "Search By";
            // 
            // lbl_search_DrugName
            // 
            this.lbl_search_DrugName.AutoSize = true;
            this.lbl_search_DrugName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search_DrugName.Location = new System.Drawing.Point(45, 35);
            this.lbl_search_DrugName.Name = "lbl_search_DrugName";
            this.lbl_search_DrugName.Size = new System.Drawing.Size(91, 21);
            this.lbl_search_DrugName.TabIndex = 15;
            this.lbl_search_DrugName.Text = "Drug Name";
            // 
            // txtSearchKeyWord_MangDrugStore
            // 
            this.txtSearchKeyWord_MangDrugStore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKeyWord_MangDrugStore.Location = new System.Drawing.Point(153, 32);
            this.txtSearchKeyWord_MangDrugStore.Name = "txtSearchKeyWord_MangDrugStore";
            this.txtSearchKeyWord_MangDrugStore.Size = new System.Drawing.Size(229, 29);
            this.txtSearchKeyWord_MangDrugStore.TabIndex = 13;
            this.txtSearchKeyWord_MangDrugStore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchKeyWord_MangDrugStore_KeyPress);
            // 
            // btnSearch_MangDrugStore
            // 
            this.btnSearch_MangDrugStore.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnSearch_MangDrugStore.Image = global::FamilyCareHospital.Properties.Resources.SEARCH_search_32px;
            this.btnSearch_MangDrugStore.Location = new System.Drawing.Point(400, 22);
            this.btnSearch_MangDrugStore.Name = "btnSearch_MangDrugStore";
            this.btnSearch_MangDrugStore.Size = new System.Drawing.Size(84, 44);
            this.btnSearch_MangDrugStore.TabIndex = 14;
            this.btnSearch_MangDrugStore.UseVisualStyleBackColor = false;
            this.btnSearch_MangDrugStore.Click += new System.EventHandler(this.btnSearch_MangDrugStore_Click);
            // 
            // grpBox1_MangDrugStore
            // 
            this.grpBox1_MangDrugStore.Controls.Add(this.btnClear_Content_MangDrugStore);
            this.grpBox1_MangDrugStore.Controls.Add(this.panel2_MangDrugStore);
            this.grpBox1_MangDrugStore.Controls.Add(this.btnDelete_MangDrugStore);
            this.grpBox1_MangDrugStore.Controls.Add(this.btnUpdate_MangDrugStore);
            this.grpBox1_MangDrugStore.Controls.Add(this.btn_Save_MangDrugStore);
            this.grpBox1_MangDrugStore.Location = new System.Drawing.Point(16, 27);
            this.grpBox1_MangDrugStore.Margin = new System.Windows.Forms.Padding(0);
            this.grpBox1_MangDrugStore.Name = "grpBox1_MangDrugStore";
            this.grpBox1_MangDrugStore.Padding = new System.Windows.Forms.Padding(0);
            this.grpBox1_MangDrugStore.Size = new System.Drawing.Size(387, 423);
            this.grpBox1_MangDrugStore.TabIndex = 19;
            this.grpBox1_MangDrugStore.TabStop = false;
            // 
            // btnClear_Content_MangDrugStore
            // 
            this.btnClear_Content_MangDrugStore.BackColor = System.Drawing.Color.Teal;
            this.btnClear_Content_MangDrugStore.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear_Content_MangDrugStore.FlatAppearance.BorderSize = 5;
            this.btnClear_Content_MangDrugStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear_Content_MangDrugStore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear_Content_MangDrugStore.Location = new System.Drawing.Point(103, 353);
            this.btnClear_Content_MangDrugStore.Name = "btnClear_Content_MangDrugStore";
            this.btnClear_Content_MangDrugStore.Size = new System.Drawing.Size(84, 44);
            this.btnClear_Content_MangDrugStore.TabIndex = 12;
            this.btnClear_Content_MangDrugStore.Text = "CANCEL";
            this.btnClear_Content_MangDrugStore.UseVisualStyleBackColor = false;
            this.btnClear_Content_MangDrugStore.Click += new System.EventHandler(this.btnClear_Content_MangDrugStore_Click);
            // 
            // panel2_MangDrugStore
            // 
            this.panel2_MangDrugStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2_MangDrugStore.Controls.Add(this.dateTimePicker1_ManageDrugs);
            this.panel2_MangDrugStore.Controls.Add(this.lbl_ExDate);
            this.panel2_MangDrugStore.Controls.Add(this.lbl_DrugName);
            this.panel2_MangDrugStore.Controls.Add(this.txt_DrugName);
            this.panel2_MangDrugStore.Controls.Add(this.txt_Quantity);
            this.panel2_MangDrugStore.Controls.Add(this.lbl_Quantity);
            this.panel2_MangDrugStore.Location = new System.Drawing.Point(12, 38);
            this.panel2_MangDrugStore.Name = "panel2_MangDrugStore";
            this.panel2_MangDrugStore.Size = new System.Drawing.Size(357, 272);
            this.panel2_MangDrugStore.TabIndex = 11;
            // 
            // dateTimePicker1_ManageDrugs
            // 
            this.dateTimePicker1_ManageDrugs.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1_ManageDrugs.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1_ManageDrugs.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1_ManageDrugs.Location = new System.Drawing.Point(133, 196);
            this.dateTimePicker1_ManageDrugs.Name = "dateTimePicker1_ManageDrugs";
            this.dateTimePicker1_ManageDrugs.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1_ManageDrugs.TabIndex = 5;
            // 
            // lbl_ExDate
            // 
            this.lbl_ExDate.AutoSize = true;
            this.lbl_ExDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ExDate.Location = new System.Drawing.Point(14, 196);
            this.lbl_ExDate.Name = "lbl_ExDate";
            this.lbl_ExDate.Size = new System.Drawing.Size(85, 20);
            this.lbl_ExDate.TabIndex = 2;
            this.lbl_ExDate.Text = "Expiry Date";
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
            this.txt_DrugName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DrugName.Location = new System.Drawing.Point(133, 34);
            this.txt_DrugName.Name = "txt_DrugName";
            this.txt_DrugName.Size = new System.Drawing.Size(209, 27);
            this.txt_DrugName.TabIndex = 3;
            this.txt_DrugName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DrugName_KeyPress);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(133, 113);
            this.txt_Quantity.MaxLength = 4;
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(209, 27);
            this.txt_Quantity.TabIndex = 4;
            this.txt_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Quantity_KeyPress);
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(14, 120);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(65, 20);
            this.lbl_Quantity.TabIndex = 1;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // btnDelete_MangDrugStore
            // 
            this.btnDelete_MangDrugStore.BackColor = System.Drawing.Color.Teal;
            this.btnDelete_MangDrugStore.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete_MangDrugStore.FlatAppearance.BorderSize = 5;
            this.btnDelete_MangDrugStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete_MangDrugStore.Image = global::FamilyCareHospital.Properties.Resources.DELETE_trash_32px;
            this.btnDelete_MangDrugStore.Location = new System.Drawing.Point(287, 353);
            this.btnDelete_MangDrugStore.Name = "btnDelete_MangDrugStore";
            this.btnDelete_MangDrugStore.Size = new System.Drawing.Size(84, 44);
            this.btnDelete_MangDrugStore.TabIndex = 8;
            this.btnDelete_MangDrugStore.UseVisualStyleBackColor = false;
            this.btnDelete_MangDrugStore.Click += new System.EventHandler(this.btnDelete_MangDrugStore_Click);
            // 
            // btnUpdate_MangDrugStore
            // 
            this.btnUpdate_MangDrugStore.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate_MangDrugStore.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate_MangDrugStore.FlatAppearance.BorderSize = 5;
            this.btnUpdate_MangDrugStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate_MangDrugStore.Image = global::FamilyCareHospital.Properties.Resources.EDIT_edit_32px;
            this.btnUpdate_MangDrugStore.Location = new System.Drawing.Point(195, 353);
            this.btnUpdate_MangDrugStore.Name = "btnUpdate_MangDrugStore";
            this.btnUpdate_MangDrugStore.Size = new System.Drawing.Size(84, 44);
            this.btnUpdate_MangDrugStore.TabIndex = 7;
            this.btnUpdate_MangDrugStore.UseVisualStyleBackColor = false;
            this.btnUpdate_MangDrugStore.Click += new System.EventHandler(this.btnUpdate_MangDrugStore_Click);
            // 
            // btn_Save_MangDrugStore
            // 
            this.btn_Save_MangDrugStore.BackColor = System.Drawing.Color.Teal;
            this.btn_Save_MangDrugStore.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Save_MangDrugStore.FlatAppearance.BorderSize = 5;
            this.btn_Save_MangDrugStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Save_MangDrugStore.Image = global::FamilyCareHospital.Properties.Resources.ADD_add_file_32px;
            this.btn_Save_MangDrugStore.Location = new System.Drawing.Point(12, 353);
            this.btn_Save_MangDrugStore.Name = "btn_Save_MangDrugStore";
            this.btn_Save_MangDrugStore.Size = new System.Drawing.Size(84, 44);
            this.btn_Save_MangDrugStore.TabIndex = 3;
            this.btn_Save_MangDrugStore.UseVisualStyleBackColor = false;
            this.btn_Save_MangDrugStore.Click += new System.EventHandler(this.btn_Save_MangDrugStore_Click);
            // 
            // Ward_Admin_Manage_Drug_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(993, 616);
            this.Controls.Add(this.panel1_Manag_Drug_Store);
            this.Controls.Add(this.btn_Back_ManaDrugStr);
            this.Controls.Add(this.lbl_ManaDrugStore);
            this.Name = "Ward_Admin_Manage_Drug_Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drug Store";
            this.panel1_Manag_Drug_Store.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_MangDrugStore)).EndInit();
            this.grpBox_MangDrugStore.ResumeLayout(false);
            this.grpBox_MangDrugStore.PerformLayout();
            this.grpBox1_MangDrugStore.ResumeLayout(false);
            this.panel2_MangDrugStore.ResumeLayout(false);
            this.panel2_MangDrugStore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ManaDrugStore;
        private System.Windows.Forms.Button btn_Back_ManaDrugStr;
        private System.Windows.Forms.Panel panel1_Manag_Drug_Store;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_DrugName;
        private System.Windows.Forms.Label lbl_ExDate;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_DrugName;
        private System.Windows.Forms.GroupBox grpBox1_MangDrugStore;
        private System.Windows.Forms.Button btnClear_Content_MangDrugStore;
        private System.Windows.Forms.Panel panel2_MangDrugStore;
        private System.Windows.Forms.Button btnDelete_MangDrugStore;
        private System.Windows.Forms.Button btnUpdate_MangDrugStore;
        private System.Windows.Forms.Button btn_Save_MangDrugStore;
        private System.Windows.Forms.GroupBox grpBox_MangDrugStore;
        private System.Windows.Forms.TextBox txtSearchKeyWord_MangDrugStore;
        private System.Windows.Forms.Button btnSearch_MangDrugStore;
        private System.Windows.Forms.DataGridView dataGridView1_MangDrugStore;
        private System.Windows.Forms.Button btnRefresh_MangDrugStore;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_ManageDrugs;
        private System.Windows.Forms.DataGridViewImageColumn btn_clickForUpdate;
        private System.Windows.Forms.Label lbl_search_DrugName;
    }
}