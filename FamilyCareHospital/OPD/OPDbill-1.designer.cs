namespace FamilyCareHospital
{
    partial class OPDbill_1
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
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToken_No = new System.Windows.Forms.TextBox();
            this.txtRoom_No = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblBill_Date = new System.Windows.Forms.Label();
            this.lblBill_No = new System.Windows.Forms.Label();
            this.txtBill_No = new System.Windows.Forms.TextBox();
            this.txtBill_Date = new System.Windows.Forms.TextBox();
            this.txtbill_Amount = new System.Windows.Forms.TextBox();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.grpbxpPatirntDetails = new System.Windows.Forms.GroupBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Back_ManageInPa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpbxpPatirntDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(685, 518);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 42);
            this.button3.TabIndex = 39;
            this.button3.Text = "Preview";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(486, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Token No";
            // 
            // txtToken_No
            // 
            this.txtToken_No.Location = new System.Drawing.Point(627, 153);
            this.txtToken_No.Name = "txtToken_No";
            this.txtToken_No.Size = new System.Drawing.Size(48, 20);
            this.txtToken_No.TabIndex = 37;
            // 
            // txtRoom_No
            // 
            this.txtRoom_No.Location = new System.Drawing.Point(623, 451);
            this.txtRoom_No.Name = "txtRoom_No";
            this.txtRoom_No.Size = new System.Drawing.Size(121, 20);
            this.txtRoom_No.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(498, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Room No";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Items.AddRange(new object[] {
            "shermi",
            "kush",
            "samu"});
            this.cmbDoctor.Location = new System.Drawing.Point(623, 391);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(121, 21);
            this.cmbDoctor.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Doctor";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Image = global::FamilyCareHospital.Properties.Resources.OPDSEARCH;
            this.btnSearch.Location = new System.Drawing.Point(351, 124);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 42);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.lblBill_Date);
            this.groupBox1.Controls.Add(this.lblBill_No);
            this.groupBox1.Controls.Add(this.txtBill_No);
            this.groupBox1.Controls.Add(this.txtBill_Date);
            this.groupBox1.Controls.Add(this.txtbill_Amount);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(445, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 155);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPD Bill Details";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(49, 108);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(53, 16);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount";
            // 
            // lblBill_Date
            // 
            this.lblBill_Date.AutoSize = true;
            this.lblBill_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill_Date.Location = new System.Drawing.Point(49, 76);
            this.lblBill_Date.Name = "lblBill_Date";
            this.lblBill_Date.Size = new System.Drawing.Size(58, 16);
            this.lblBill_Date.TabIndex = 5;
            this.lblBill_Date.Text = "Bill Date";
            // 
            // lblBill_No
            // 
            this.lblBill_No.AutoSize = true;
            this.lblBill_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill_No.Location = new System.Drawing.Point(49, 40);
            this.lblBill_No.Name = "lblBill_No";
            this.lblBill_No.Size = new System.Drawing.Size(47, 16);
            this.lblBill_No.TabIndex = 4;
            this.lblBill_No.Text = "Bill No";
            // 
            // txtBill_No
            // 
            this.txtBill_No.Location = new System.Drawing.Point(182, 33);
            this.txtBill_No.Name = "txtBill_No";
            this.txtBill_No.Size = new System.Drawing.Size(100, 22);
            this.txtBill_No.TabIndex = 1;
            // 
            // txtBill_Date
            // 
            this.txtBill_Date.Location = new System.Drawing.Point(182, 69);
            this.txtBill_Date.Name = "txtBill_Date";
            this.txtBill_Date.Size = new System.Drawing.Size(100, 22);
            this.txtBill_Date.TabIndex = 2;
            // 
            // txtbill_Amount
            // 
            this.txtbill_Amount.Location = new System.Drawing.Point(182, 101);
            this.txtbill_Amount.Name = "txtbill_Amount";
            this.txtbill_Amount.Size = new System.Drawing.Size(100, 22);
            this.txtbill_Amount.TabIndex = 3;
            this.txtbill_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbill_Amount_KeyPress);
            // 
            // txtPatient
            // 
            this.txtPatient.Location = new System.Drawing.Point(222, 146);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(100, 20);
            this.txtPatient.TabIndex = 30;
            // 
            // grpbxpPatirntDetails
            // 
            this.grpbxpPatirntDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpbxpPatirntDetails.Controls.Add(this.txtGender);
            this.grpbxpPatirntDetails.Controls.Add(this.txtAge);
            this.grpbxpPatirntDetails.Controls.Add(this.txtLastName);
            this.grpbxpPatirntDetails.Controls.Add(this.txtFirstName);
            this.grpbxpPatirntDetails.Controls.Add(this.lblAge);
            this.grpbxpPatirntDetails.Controls.Add(this.lblGender);
            this.grpbxpPatirntDetails.Controls.Add(this.lblLastName);
            this.grpbxpPatirntDetails.Controls.Add(this.lblFirstName);
            this.grpbxpPatirntDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxpPatirntDetails.Location = new System.Drawing.Point(54, 203);
            this.grpbxpPatirntDetails.Name = "grpbxpPatirntDetails";
            this.grpbxpPatirntDetails.Size = new System.Drawing.Size(285, 240);
            this.grpbxpPatirntDetails.TabIndex = 29;
            this.grpbxpPatirntDetails.TabStop = false;
            this.grpbxpPatirntDetails.Text = "Patient Details";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(168, 115);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 22);
            this.txtGender.TabIndex = 10;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(168, 149);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(168, 73);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(168, 33);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 6;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(28, 156);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 16);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(28, 118);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(53, 16);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(27, 76);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 16);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(28, 40);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Fisrt Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Image = global::FamilyCareHospital.Properties.Resources.OPDADD;
            this.button1.Location = new System.Drawing.Point(584, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 42);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_Back_ManageInPa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 65);
            this.panel1.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(42, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Out Patient  Bill";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Patient ID";
            // 
            // btn_Back_ManageInPa
            // 
            this.btn_Back_ManageInPa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Back_ManageInPa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Back_ManageInPa.FlatAppearance.BorderSize = 5;
            this.btn_Back_ManageInPa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Back_ManageInPa.Image = global::FamilyCareHospital.Properties.Resources.OPDBACK;
            this.btn_Back_ManageInPa.Location = new System.Drawing.Point(682, 12);
            this.btn_Back_ManageInPa.Name = "btn_Back_ManageInPa";
            this.btn_Back_ManageInPa.Size = new System.Drawing.Size(74, 41);
            this.btn_Back_ManageInPa.TabIndex = 25;
            this.btn_Back_ManageInPa.UseVisualStyleBackColor = false;
            this.btn_Back_ManageInPa.Click += new System.EventHandler(this.btn_Back_ManageInPa_Click);
            // 
            // OPDbill_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(805, 563);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtToken_No);
            this.Controls.Add(this.txtRoom_No);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPatient);
            this.Controls.Add(this.grpbxpPatirntDetails);
            this.Controls.Add(this.button1);
            this.Name = "OPDbill_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPDbill_1";
            this.Load += new System.EventHandler(this.OPDbill_1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbxpPatirntDetails.ResumeLayout(false);
            this.grpbxpPatirntDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToken_No;
        private System.Windows.Forms.TextBox txtRoom_No;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblBill_Date;
        private System.Windows.Forms.Label lblBill_No;
        private System.Windows.Forms.TextBox txtBill_No;
        private System.Windows.Forms.TextBox txtBill_Date;
        private System.Windows.Forms.TextBox txtbill_Amount;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.GroupBox grpbxpPatirntDetails;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Back_ManageInPa;
    }
}