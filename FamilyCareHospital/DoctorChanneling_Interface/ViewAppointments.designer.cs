namespace FamilyCareHospital
{
    partial class View_Appointments
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
            this.appdetailsview = new System.Windows.Forms.DataGridView();
            this.Click1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.appdatetxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phnelbl = new System.Windows.Forms.Label();
            this.panamelbl = new System.Windows.Forms.Label();
            this.appdatelbl = new System.Windows.Forms.Label();
            this.spelbl = new System.Windows.Forms.Label();
            this.dnamelbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dctrnametxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.noOfApp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appdetailsview)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // appdetailsview
            // 
            this.appdetailsview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appdetailsview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Click1});
            this.appdetailsview.Location = new System.Drawing.Point(493, 323);
            this.appdetailsview.Name = "appdetailsview";
            this.appdetailsview.Size = new System.Drawing.Size(386, 150);
            this.appdetailsview.TabIndex = 8;
            this.appdetailsview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appdetailsview_CellContentClick);
            // 
            // Click1
            // 
            this.Click1.HeaderText = "Click";
            this.Click1.Name = "Click1";
            this.Click1.Text = "View";
            this.Click1.UseColumnTextForButtonValue = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.monthCalendar1);
            this.groupBox3.Controls.Add(this.appdatetxt);
            this.groupBox3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(493, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 247);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "label9";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(51, 19);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // appdatetxt
            // 
            this.appdatetxt.Location = new System.Drawing.Point(51, 193);
            this.appdatetxt.Name = "appdatetxt";
            this.appdatetxt.Size = new System.Drawing.Size(199, 28);
            this.appdatetxt.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.phnelbl);
            this.groupBox1.Controls.Add(this.panamelbl);
            this.groupBox1.Controls.Add(this.appdatelbl);
            this.groupBox1.Controls.Add(this.spelbl);
            this.groupBox1.Controls.Add(this.dnamelbl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 252);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Details";
            // 
            // phnelbl
            // 
            this.phnelbl.AutoSize = true;
            this.phnelbl.Location = new System.Drawing.Point(107, 207);
            this.phnelbl.Name = "phnelbl";
            this.phnelbl.Size = new System.Drawing.Size(56, 20);
            this.phnelbl.TabIndex = 16;
            this.phnelbl.Text = "label12";
            // 
            // panamelbl
            // 
            this.panamelbl.AutoSize = true;
            this.panamelbl.Location = new System.Drawing.Point(131, 165);
            this.panamelbl.Name = "panamelbl";
            this.panamelbl.Size = new System.Drawing.Size(56, 20);
            this.panamelbl.TabIndex = 14;
            this.panamelbl.Text = "label10";
            // 
            // appdatelbl
            // 
            this.appdatelbl.AutoSize = true;
            this.appdatelbl.Location = new System.Drawing.Point(166, 126);
            this.appdatelbl.Name = "appdatelbl";
            this.appdatelbl.Size = new System.Drawing.Size(48, 20);
            this.appdatelbl.TabIndex = 13;
            this.appdatelbl.Text = "label9";
            // 
            // spelbl
            // 
            this.spelbl.AutoSize = true;
            this.spelbl.Location = new System.Drawing.Point(105, 89);
            this.spelbl.Name = "spelbl";
            this.spelbl.Size = new System.Drawing.Size(48, 20);
            this.spelbl.TabIndex = 12;
            this.spelbl.Text = "label8";
            // 
            // dnamelbl
            // 
            this.dnamelbl.AutoSize = true;
            this.dnamelbl.Location = new System.Drawing.Point(131, 50);
            this.dnamelbl.Name = "dnamelbl";
            this.dnamelbl.Size = new System.Drawing.Size(48, 20);
            this.dnamelbl.TabIndex = 11;
            this.dnamelbl.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Patient Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Appointment Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Speciality:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Doctor Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dctrnametxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doctor Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "label8";
            // 
            // dctrnametxt
            // 
            this.dctrnametxt.Location = new System.Drawing.Point(157, 42);
            this.dctrnametxt.Name = "dctrnametxt";
            this.dctrnametxt.Size = new System.Drawing.Size(184, 28);
            this.dctrnametxt.TabIndex = 0;
            this.dctrnametxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dctrnametxt_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Enter Doctor Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "No. of Appointments:";
            // 
            // noOfApp
            // 
            this.noOfApp.AutoSize = true;
            this.noOfApp.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfApp.Location = new System.Drawing.Point(165, 456);
            this.noOfApp.Name = "noOfApp";
            this.noOfApp.Size = new System.Drawing.Size(56, 20);
            this.noOfApp.TabIndex = 16;
            this.noOfApp.Text = "label11";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 45);
            this.panel1.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = global::FamilyCareHospital.Properties.Resources.Home12icon;
            this.button2.Location = new System.Drawing.Point(821, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 45);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // View_Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(889, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.noOfApp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.appdetailsview);
            this.MaximizeBox = false;
            this.Name = "View_Appointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAppointments";
            ((System.ComponentModel.ISupportInitialize)(this.appdetailsview)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView appdetailsview;
        private System.Windows.Forms.DataGridViewButtonColumn Click1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox appdatetxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label phnelbl;
        private System.Windows.Forms.Label panamelbl;
        private System.Windows.Forms.Label appdatelbl;
        private System.Windows.Forms.Label spelbl;
        private System.Windows.Forms.Label dnamelbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dctrnametxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label noOfApp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}