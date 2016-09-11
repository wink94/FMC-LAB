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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPatientTest = new System.Windows.Forms.DataGridView();
            this.dgvtestNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUniqueTestStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAddTestResult = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvUpdateTestResult = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientTest)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.dgvPatientTest);
            this.groupBox2.Location = new System.Drawing.Point(35, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 620);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 239);
            this.panel1.TabIndex = 1;
            // 
            // dgvPatientTest
            // 
            this.dgvPatientTest.AllowUserToAddRows = false;
            this.dgvPatientTest.AllowUserToDeleteRows = false;
            this.dgvPatientTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtestNum,
            this.dgvtestName,
            this.dgvUniqueTestStatus,
            this.dgvAddTestResult,
            this.dgvUpdateTestResult});
            this.dgvPatientTest.Location = new System.Drawing.Point(36, 130);
            this.dgvPatientTest.Name = "dgvPatientTest";
            this.dgvPatientTest.Size = new System.Drawing.Size(394, 208);
            this.dgvPatientTest.TabIndex = 0;
            this.dgvPatientTest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientTest_CellClick);
            // 
            // dgvtestNum
            // 
            this.dgvtestNum.DataPropertyName = "Test_Number";
            this.dgvtestNum.HeaderText = "No.";
            this.dgvtestNum.Name = "dgvtestNum";
            this.dgvtestNum.Width = 30;
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
            // dgvAddTestResult
            // 
            this.dgvAddTestResult.HeaderText = "Add ";
            this.dgvAddTestResult.Name = "dgvAddTestResult";
            this.dgvAddTestResult.Width = 60;
            // 
            // dgvUpdateTestResult
            // 
            this.dgvUpdateTestResult.HeaderText = "Update ";
            this.dgvUpdateTestResult.Name = "dgvUpdateTestResult";
            this.dgvUpdateTestResult.Width = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.groupBox3);
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
            this.dgvAppointmentList.AllowUserToAddRows = false;
            this.dgvAppointmentList.AllowUserToDeleteRows = false;
            this.dgvAppointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvAppointmentID,
            this.dgvPatientID,
            this.dgvPatientName,
            this.dgvAppointmentDate,
            this.dgvTestStatus,
            this.dbvAppointmentPrintReport});
            this.dgvAppointmentList.Location = new System.Drawing.Point(6, 130);
            this.dgvAppointmentList.Name = "dgvAppointmentList";
            this.dgvAppointmentList.ReadOnly = true;
            this.dgvAppointmentList.Size = new System.Drawing.Size(638, 208);
            this.dgvAppointmentList.TabIndex = 8;
            this.dgvAppointmentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointmentList_CellClick);
            this.dgvAppointmentList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAppointmentList_RowHeaderMouseClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(112, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(112, 131);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(68, 20);
            this.textBox4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "label1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(126, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "label1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(126, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "label1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(126, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "label1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(126, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "label1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(34, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(66, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(34, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton1";
            this.radioButton2.UseVisualStyleBackColor = true;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientTest)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.DataGridViewImageColumn dgvAddTestResult;
        private System.Windows.Forms.DataGridViewImageColumn dgvUpdateTestResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}