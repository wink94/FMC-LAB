namespace FamilyCareHospital.Interfaces
{
    partial class TestDetailsEntry
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPatientTest = new System.Windows.Forms.DataGridView();
            this.dgvtestNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUniqueTestStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchAppmntByDate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvAppointmentList = new System.Windows.Forms.DataGridView();
            this.dgvAppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTestStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbvAppointmentPrintReport = new System.Windows.Forms.DataGridViewImageColumn();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.txtAppointmentSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientTest)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPatientTest);
            this.groupBox2.Location = new System.Drawing.Point(35, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 620);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dgvPatientTest
            // 
            this.dgvPatientTest.AllowUserToDeleteRows = false;
            this.dgvPatientTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtestNum,
            this.dgvtestName,
            this.dgvUniqueTestStatus});
            this.dgvPatientTest.Location = new System.Drawing.Point(25, 130);
            this.dgvPatientTest.Name = "dgvPatientTest";
            this.dgvPatientTest.RowHeadersVisible = false;
            this.dgvPatientTest.Size = new System.Drawing.Size(305, 208);
            this.dgvPatientTest.TabIndex = 0;
            // 
            // dgvtestNum
            // 
            this.dgvtestNum.DataPropertyName = "Test_Number";
            this.dgvtestNum.HeaderText = "Test Number";
            this.dgvtestNum.Name = "dgvtestNum";
            // 
            // dgvtestName
            // 
            this.dgvtestName.DataPropertyName = "Test_Name";
            this.dgvtestName.HeaderText = "Test Name";
            this.dgvtestName.Name = "dgvtestName";
            // 
            // dgvUniqueTestStatus
            // 
            this.dgvUniqueTestStatus.DataPropertyName = "Test_Status";
            this.dgvUniqueTestStatus.HeaderText = "Test Status";
            this.dgvUniqueTestStatus.Name = "dgvUniqueTestStatus";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnSearchAppmntByDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dgvAppointmentList);
            this.groupBox1.Controls.Add(this.dateTo);
            this.groupBox1.Controls.Add(this.dateFrom);
            this.groupBox1.Controls.Add(this.txtAppointmentSearch);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(512, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 620);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Appointment";
            // 
            // btnSearchAppmntByDate
            // 
            this.btnSearchAppmntByDate.Image = global::FamilyCareHospital.Properties.Resources.search_35px;
            this.btnSearchAppmntByDate.Location = new System.Drawing.Point(598, 67);
            this.btnSearchAppmntByDate.Name = "btnSearchAppmntByDate";
            this.btnSearchAppmntByDate.Size = new System.Drawing.Size(36, 36);
            this.btnSearchAppmntByDate.TabIndex = 16;
            this.btnSearchAppmntByDate.UseVisualStyleBackColor = true;
            this.btnSearchAppmntByDate.Click += new System.EventHandler(this.btnSearchAppmntByDate_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Aqua;
            this.label11.Location = new System.Drawing.Point(7, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "From";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Aqua;
            this.label9.Location = new System.Drawing.Point(327, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "To";
            // 
            // dgvAppointmentList
            // 
            this.dgvAppointmentList.AllowUserToDeleteRows = false;
            this.dgvAppointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvAppointmentID,
            this.dgvPatientID,
            this.dgvPatientName,
            this.dgvAppointmentDate,
            this.dgvTestStatus,
            this.dbvAppointmentPrintReport});
            this.dgvAppointmentList.Location = new System.Drawing.Point(19, 130);
            this.dgvAppointmentList.Name = "dgvAppointmentList";
            this.dgvAppointmentList.ReadOnly = true;
            this.dgvAppointmentList.RowHeadersVisible = false;
            this.dgvAppointmentList.Size = new System.Drawing.Size(604, 208);
            this.dgvAppointmentList.TabIndex = 8;
            this.dgvAppointmentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointmentList_CellClick);
            // 
            // dgvAppointmentID
            // 
            this.dgvAppointmentID.DataPropertyName = "AppointmentID";
            this.dgvAppointmentID.HeaderText = "Appointment ID";
            this.dgvAppointmentID.Name = "dgvAppointmentID";
            this.dgvAppointmentID.ReadOnly = true;
            this.dgvAppointmentID.Width = 115;
            // 
            // dgvPatientID
            // 
            this.dgvPatientID.DataPropertyName = "PatientID";
            this.dgvPatientID.HeaderText = "Patient ID";
            this.dgvPatientID.Name = "dgvPatientID";
            this.dgvPatientID.ReadOnly = true;
            // 
            // dgvPatientName
            // 
            this.dgvPatientName.DataPropertyName = "PatientName";
            this.dgvPatientName.HeaderText = "Patient Name";
            this.dgvPatientName.Name = "dgvPatientName";
            this.dgvPatientName.ReadOnly = true;
            this.dgvPatientName.Width = 120;
            // 
            // dgvAppointmentDate
            // 
            this.dgvAppointmentDate.DataPropertyName = "AppointmentDate";
            this.dgvAppointmentDate.HeaderText = "Date";
            this.dgvAppointmentDate.Name = "dgvAppointmentDate";
            this.dgvAppointmentDate.ReadOnly = true;
            // 
            // dgvTestStatus
            // 
            this.dgvTestStatus.DataPropertyName = "TestStatus";
            this.dgvTestStatus.HeaderText = "Test Status";
            this.dgvTestStatus.Name = "dgvTestStatus";
            this.dgvTestStatus.ReadOnly = true;
            // 
            // dbvAppointmentPrintReport
            // 
            this.dbvAppointmentPrintReport.HeaderText = "Print Report";
            this.dbvAppointmentPrintReport.Image = global::FamilyCareHospital.Properties.Resources.cancel_25px;
            this.dbvAppointmentPrintReport.Name = "dbvAppointmentPrintReport";
            this.dbvAppointmentPrintReport.ReadOnly = true;
            this.dbvAppointmentPrintReport.Width = 60;
            // 
            // dateTo
            // 
            this.dateTo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Location = new System.Drawing.Point(367, 81);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 22);
            this.dateTo.TabIndex = 13;
            // 
            // dateFrom
            // 
            this.dateFrom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Location = new System.Drawing.Point(66, 81);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(200, 22);
            this.dateFrom.TabIndex = 12;
            // 
            // txtAppointmentSearch
            // 
            this.txtAppointmentSearch.Location = new System.Drawing.Point(227, 29);
            this.txtAppointmentSearch.Name = "txtAppointmentSearch";
            this.txtAppointmentSearch.Size = new System.Drawing.Size(100, 25);
            this.txtAppointmentSearch.TabIndex = 10;
            this.txtAppointmentSearch.TextChanged += new System.EventHandler(this.txtAppointmentSearch_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Search Appointments";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Print Report";
            this.dataGridViewImageColumn1.Image = global::FamilyCareHospital.Properties.Resources.cancel_25px;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 60;
            // 
            // TestDetailsEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "TestDetailsEntry";
            this.Text = "TestDetailsEntry";
            this.Load += new System.EventHandler(this.TestDetailsEntry_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientTest)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchAppmntByDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvAppointmentList;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.TextBox txtAppointmentSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvPatientTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTestStatus;
        private System.Windows.Forms.DataGridViewImageColumn dbvAppointmentPrintReport;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtestNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUniqueTestStatus;
    }
}