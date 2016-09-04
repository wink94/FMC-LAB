namespace FamilyCareHospital
{
    partial class Clinicview
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dgvClinic_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRegistration_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFirst_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLast_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcivil_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvblood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvContactNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvupdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvdelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Back_ManageInPa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::FamilyCareHospital.Properties.Resources.OPDREFRESH;
            this.btnRefresh.Location = new System.Drawing.Point(447, 141);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 43);
            this.btnRefresh.TabIndex = 38;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::FamilyCareHospital.Properties.Resources.OPDSEARCH;
            this.btnSearch.Location = new System.Drawing.Point(323, 141);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 43);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(165, 164);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 36;
            this.txtSearch.Tag = "fdg";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvClinic_ID,
            this.dgvRegistration_Date,
            this.dgvFirst_Name,
            this.dgvLast_Name,
            this.dgvNIC,
            this.dgvGender,
            this.dgvAge,
            this.dgvcivil_status,
            this.dgvblood,
            this.dgvAddress,
            this.dgvCity,
            this.dgvContactNO,
            this.dgvupdate,
            this.dgvdelete});
            this.dataGridView2.Location = new System.Drawing.Point(56, 222);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1019, 369);
            this.dataGridView2.TabIndex = 34;
            // 
            // dgvClinic_ID
            // 
            this.dgvClinic_ID.DataPropertyName = "ClinicID";
            this.dgvClinic_ID.HeaderText = "Clinic ID";
            this.dgvClinic_ID.Name = "dgvClinic_ID";
            // 
            // dgvRegistration_Date
            // 
            this.dgvRegistration_Date.DataPropertyName = "Date";
            this.dgvRegistration_Date.HeaderText = "Date";
            this.dgvRegistration_Date.Name = "dgvRegistration_Date";
            // 
            // dgvFirst_Name
            // 
            this.dgvFirst_Name.DataPropertyName = "Fname";
            this.dgvFirst_Name.HeaderText = "First Name";
            this.dgvFirst_Name.Name = "dgvFirst_Name";
            // 
            // dgvLast_Name
            // 
            this.dgvLast_Name.DataPropertyName = "Lname";
            this.dgvLast_Name.HeaderText = "Last Name";
            this.dgvLast_Name.Name = "dgvLast_Name";
            // 
            // dgvNIC
            // 
            this.dgvNIC.DataPropertyName = "NIC";
            this.dgvNIC.HeaderText = "NIC";
            this.dgvNIC.Name = "dgvNIC";
            // 
            // dgvGender
            // 
            this.dgvGender.DataPropertyName = "Gender";
            this.dgvGender.HeaderText = "Gender";
            this.dgvGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.dgvGender.Name = "dgvGender";
            this.dgvGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvAge
            // 
            this.dgvAge.DataPropertyName = "Age";
            this.dgvAge.HeaderText = "Age";
            this.dgvAge.Name = "dgvAge";
            // 
            // dgvcivil_status
            // 
            this.dgvcivil_status.DataPropertyName = "CivilStatus";
            this.dgvcivil_status.HeaderText = "Civil Status";
            this.dgvcivil_status.Name = "dgvcivil_status";
            // 
            // dgvblood
            // 
            this.dgvblood.DataPropertyName = "BloodGroup";
            this.dgvblood.HeaderText = "Blood Group";
            this.dgvblood.Name = "dgvblood";
            // 
            // dgvAddress
            // 
            this.dgvAddress.DataPropertyName = "Address";
            this.dgvAddress.HeaderText = "Address";
            this.dgvAddress.Name = "dgvAddress";
            // 
            // dgvCity
            // 
            this.dgvCity.DataPropertyName = "City";
            this.dgvCity.HeaderText = "City";
            this.dgvCity.Name = "dgvCity";
            // 
            // dgvContactNO
            // 
            this.dgvContactNO.DataPropertyName = "ContactNO";
            this.dgvContactNO.HeaderText = "Contact NO";
            this.dgvContactNO.Name = "dgvContactNO";
            // 
            // dgvupdate
            // 
            this.dgvupdate.HeaderText = "Update";
            this.dgvupdate.Name = "dgvupdate";
            this.dgvupdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvupdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvupdate.Text = "Update";
            this.dgvupdate.UseColumnTextForButtonValue = true;
            // 
            // dgvdelete
            // 
            this.dgvdelete.DataPropertyName = "Delete";
            this.dgvdelete.HeaderText = "Delete";
            this.dgvdelete.Name = "dgvdelete";
            this.dgvdelete.Text = "Delete";
            this.dgvdelete.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_Back_ManageInPa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 100);
            this.panel1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "View Clinic-Patient Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Clinic ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Back_ManageInPa
            // 
            this.btn_Back_ManageInPa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Back_ManageInPa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Back_ManageInPa.FlatAppearance.BorderSize = 5;
            this.btn_Back_ManageInPa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Back_ManageInPa.Image = global::FamilyCareHospital.Properties.Resources.OPDBACK;
            this.btn_Back_ManageInPa.Location = new System.Drawing.Point(1151, 37);
            this.btn_Back_ManageInPa.Name = "btn_Back_ManageInPa";
            this.btn_Back_ManageInPa.Size = new System.Drawing.Size(74, 41);
            this.btn_Back_ManageInPa.TabIndex = 25;
            this.btn_Back_ManageInPa.UseVisualStyleBackColor = false;
            this.btn_Back_ManageInPa.Click += new System.EventHandler(this.btn_Back_ManageInPa_Click);
            // 
            // Clinicview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1268, 685);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Clinicview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinicview";
            this.Load += new System.EventHandler(this.Clinicview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClinic_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRegistration_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFirst_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLast_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNIC;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcivil_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvblood;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvContactNO;
        private System.Windows.Forms.DataGridViewButtonColumn dgvupdate;
        private System.Windows.Forms.DataGridViewButtonColumn dgvdelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Back_ManageInPa;
    }
}