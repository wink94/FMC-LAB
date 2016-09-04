namespace FamilyCareHospital.interfaces_HR
{
    partial class assign_workHR
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dtp_day2half2 = new System.Windows.Forms.DateTimePicker();
            this.dtp_day2half1 = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtp_day1half2 = new System.Windows.Forms.DateTimePicker();
            this.label28 = new System.Windows.Forms.Label();
            this.dtp_day1half1 = new System.Windows.Forms.DateTimePicker();
            this.cmbx_day = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dgv_assignWork = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_emp_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_assign = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbx_dept = new System.Windows.Forms.TextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_updt = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_assignWork)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 18);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(402, 39);
            this.label14.TabIndex = 86;
            this.label14.Text = "Work details";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.cmbx_day);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(12, 232);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(396, 216);
            this.groupBox5.TabIndex = 87;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Time allocation";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dtp_day2half2);
            this.groupBox7.Controls.Add(this.dtp_day2half1);
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Location = new System.Drawing.Point(111, 143);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(265, 53);
            this.groupBox7.TabIndex = 54;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "2nd half";
            // 
            // dtp_day2half2
            // 
            this.dtp_day2half2.CustomFormat = "HH:mm";
            this.dtp_day2half2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_day2half2.Location = new System.Drawing.Point(166, 19);
            this.dtp_day2half2.Name = "dtp_day2half2";
            this.dtp_day2half2.Size = new System.Drawing.Size(88, 20);
            this.dtp_day2half2.TabIndex = 58;
            // 
            // dtp_day2half1
            // 
            this.dtp_day2half1.CustomFormat = "HH:mm";
            this.dtp_day2half1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_day2half1.Location = new System.Drawing.Point(6, 19);
            this.dtp_day2half1.Name = "dtp_day2half1";
            this.dtp_day2half1.Size = new System.Drawing.Size(88, 20);
            this.dtp_day2half1.TabIndex = 59;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(122, 25);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(16, 13);
            this.label29.TabIndex = 56;
            this.label29.Text = "to";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtp_day1half2);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Controls.Add(this.dtp_day1half1);
            this.groupBox6.Location = new System.Drawing.Point(111, 84);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(265, 53);
            this.groupBox6.TabIndex = 51;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "1st half";
            // 
            // dtp_day1half2
            // 
            this.dtp_day1half2.CustomFormat = "HH:mm";
            this.dtp_day1half2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_day1half2.Location = new System.Drawing.Point(166, 21);
            this.dtp_day1half2.Name = "dtp_day1half2";
            this.dtp_day1half2.Size = new System.Drawing.Size(88, 20);
            this.dtp_day1half2.TabIndex = 57;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(122, 27);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(16, 13);
            this.label28.TabIndex = 53;
            this.label28.Text = "to";
            // 
            // dtp_day1half1
            // 
            this.dtp_day1half1.CustomFormat = "HH:mm";
            this.dtp_day1half1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_day1half1.Location = new System.Drawing.Point(7, 21);
            this.dtp_day1half1.Name = "dtp_day1half1";
            this.dtp_day1half1.Size = new System.Drawing.Size(88, 20);
            this.dtp_day1half1.TabIndex = 56;
            // 
            // cmbx_day
            // 
            this.cmbx_day.FormattingEnabled = true;
            this.cmbx_day.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friaday",
            "Saturday",
            "Sunday"});
            this.cmbx_day.Location = new System.Drawing.Point(111, 37);
            this.cmbx_day.Name = "cmbx_day";
            this.cmbx_day.Size = new System.Drawing.Size(270, 21);
            this.cmbx_day.TabIndex = 53;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(11, 96);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(73, 16);
            this.label30.TabIndex = 51;
            this.label30.Text = "Schedule";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(11, 41);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(67, 13);
            this.label31.TabIndex = 52;
            this.label31.Text = "Day of week";
            // 
            // txt_position
            // 
            this.txt_position.Location = new System.Drawing.Point(123, 150);
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(265, 20);
            this.txt_position.TabIndex = 84;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 194);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 83;
            this.label15.Text = "Department";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 82;
            this.label18.Text = "Position";
            // 
            // dgv_assignWork
            // 
            this.dgv_assignWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_assignWork.Location = new System.Drawing.Point(432, 138);
            this.dgv_assignWork.Name = "dgv_assignWork";
            this.dgv_assignWork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_assignWork.Size = new System.Drawing.Size(740, 373);
            this.dgv_assignWork.TabIndex = 88;
            this.dgv_assignWork.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_assignWork_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Employee ID";
            // 
            // txt_emp_ID
            // 
            this.txt_emp_ID.Location = new System.Drawing.Point(123, 108);
            this.txt_emp_ID.Name = "txt_emp_ID";
            this.txt_emp_ID.Size = new System.Drawing.Size(265, 20);
            this.txt_emp_ID.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Search employee";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(574, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 92;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(737, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 93;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_assign
            // 
            this.txt_assign.Location = new System.Drawing.Point(123, 69);
            this.txt_assign.Name = "txt_assign";
            this.txt_assign.Size = new System.Drawing.Size(265, 20);
            this.txt_assign.TabIndex = 94;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 95;
            this.label10.Text = "Assign ID";
            // 
            // cmbx_dept
            // 
            this.cmbx_dept.Location = new System.Drawing.Point(123, 191);
            this.cmbx_dept.Name = "cmbx_dept";
            this.cmbx_dept.Size = new System.Drawing.Size(265, 20);
            this.cmbx_dept.TabIndex = 96;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(1097, 94);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 97;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_updt
            // 
            this.btn_updt.Location = new System.Drawing.Point(1004, 94);
            this.btn_updt.Name = "btn_updt";
            this.btn_updt.Size = new System.Drawing.Size(75, 23);
            this.btn_updt.TabIndex = 98;
            this.btn_updt.Text = "Update";
            this.btn_updt.UseVisualStyleBackColor = true;
            this.btn_updt.Click += new System.EventHandler(this.btn_updt_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(911, 94);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 99;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // assign_workHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_updt);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.cmbx_dept);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_assign);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_emp_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_assignWork);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txt_position);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label18);
            this.Name = "assign_workHR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "assign_workHR";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_assignWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cmbx_day;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txt_position;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgv_assignWork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_emp_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_assign;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cmbx_dept;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_updt;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DateTimePicker dtp_day2half2;
        private System.Windows.Forms.DateTimePicker dtp_day2half1;
        private System.Windows.Forms.DateTimePicker dtp_day1half2;
        private System.Windows.Forms.DateTimePicker dtp_day1half1;
    }
}