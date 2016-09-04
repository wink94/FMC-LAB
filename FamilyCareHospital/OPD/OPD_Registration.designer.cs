﻿namespace FamilyCareHospital
{
    partial class OPD_Registration
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
            this.btnBill = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpbxContactDetails = new System.Windows.Forms.GroupBox();
            this.txtContactNO = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblContactNO = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.grpbxpPatirntDetails = new System.Windows.Forms.GroupBox();
            this.txtNic_No = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtRegistrationDate = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Back_ManageInPa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpbxContactDetails.SuspendLayout();
            this.grpbxpPatirntDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBill
            // 
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Location = new System.Drawing.Point(715, 439);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(75, 42);
            this.btnBill.TabIndex = 13;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(568, 439);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 43);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(420, 439);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 43);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpbxContactDetails
            // 
            this.grpbxContactDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpbxContactDetails.Controls.Add(this.txtContactNO);
            this.grpbxContactDetails.Controls.Add(this.txtCity);
            this.grpbxContactDetails.Controls.Add(this.txtAddress);
            this.grpbxContactDetails.Controls.Add(this.lblContactNO);
            this.grpbxContactDetails.Controls.Add(this.lblCity);
            this.grpbxContactDetails.Controls.Add(this.lblAddress);
            this.grpbxContactDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxContactDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpbxContactDetails.Location = new System.Drawing.Point(394, 191);
            this.grpbxContactDetails.Name = "grpbxContactDetails";
            this.grpbxContactDetails.Size = new System.Drawing.Size(423, 137);
            this.grpbxContactDetails.TabIndex = 10;
            this.grpbxContactDetails.TabStop = false;
            this.grpbxContactDetails.Text = "Contact Details";
            this.grpbxContactDetails.Enter += new System.EventHandler(this.grpbxContactDetails_Enter);
            // 
            // txtContactNO
            // 
            this.txtContactNO.Location = new System.Drawing.Point(128, 100);
            this.txtContactNO.Name = "txtContactNO";
            this.txtContactNO.Size = new System.Drawing.Size(124, 22);
            this.txtContactNO.TabIndex = 5;
            this.txtContactNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNO_KeyPress);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(128, 64);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(124, 22);
            this.txtCity.TabIndex = 4;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(128, 29);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(289, 22);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // lblContactNO
            // 
            this.lblContactNO.AutoSize = true;
            this.lblContactNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNO.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblContactNO.Location = new System.Drawing.Point(30, 107);
            this.lblContactNO.Name = "lblContactNO";
            this.lblContactNO.Size = new System.Drawing.Size(76, 16);
            this.lblContactNO.TabIndex = 2;
            this.lblContactNO.Text = "Contact NO";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCity.Location = new System.Drawing.Point(30, 71);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 16);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAddress.Location = new System.Drawing.Point(27, 35);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 16);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            // 
            // grpbxpPatirntDetails
            // 
            this.grpbxpPatirntDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpbxpPatirntDetails.Controls.Add(this.txtNic_No);
            this.grpbxpPatirntDetails.Controls.Add(this.label1);
            this.grpbxpPatirntDetails.Controls.Add(this.cmbGender);
            this.grpbxpPatirntDetails.Controls.Add(this.txtAge);
            this.grpbxpPatirntDetails.Controls.Add(this.txtLastName);
            this.grpbxpPatirntDetails.Controls.Add(this.txtFirstName);
            this.grpbxpPatirntDetails.Controls.Add(this.txtRegistrationDate);
            this.grpbxpPatirntDetails.Controls.Add(this.lblAge);
            this.grpbxpPatirntDetails.Controls.Add(this.lblGender);
            this.grpbxpPatirntDetails.Controls.Add(this.lblLastName);
            this.grpbxpPatirntDetails.Controls.Add(this.lblFirstName);
            this.grpbxpPatirntDetails.Controls.Add(this.lblRegistrationDate);
            this.grpbxpPatirntDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxpPatirntDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpbxpPatirntDetails.Location = new System.Drawing.Point(40, 191);
            this.grpbxpPatirntDetails.Name = "grpbxpPatirntDetails";
            this.grpbxpPatirntDetails.Size = new System.Drawing.Size(285, 291);
            this.grpbxpPatirntDetails.TabIndex = 9;
            this.grpbxpPatirntDetails.TabStop = false;
            this.grpbxpPatirntDetails.Text = "Patient Details";
            this.grpbxpPatirntDetails.Enter += new System.EventHandler(this.grpbxpPatirntDetails_Enter);
            // 
            // txtNic_No
            // 
            this.txtNic_No.Location = new System.Drawing.Point(168, 214);
            this.txtNic_No.Name = "txtNic_No";
            this.txtNic_No.Size = new System.Drawing.Size(100, 22);
            this.txtNic_No.TabIndex = 12;
            this.txtNic_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNic_No_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(53, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "NIC No";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(168, 175);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(100, 24);
            this.cmbGender.TabIndex = 10;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(168, 136);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 9;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(168, 101);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 7;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(168, 65);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 6;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // txtRegistrationDate
            // 
            this.txtRegistrationDate.Location = new System.Drawing.Point(168, 33);
            this.txtRegistrationDate.Name = "txtRegistrationDate";
            this.txtRegistrationDate.Size = new System.Drawing.Size(100, 22);
            this.txtRegistrationDate.TabIndex = 5;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAge.Location = new System.Drawing.Point(69, 143);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 16);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGender.Location = new System.Drawing.Point(56, 183);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(53, 16);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLastName.Location = new System.Drawing.Point(37, 108);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 16);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFirstName.Location = new System.Drawing.Point(38, 72);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Fisrt Name";
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRegistrationDate.Location = new System.Drawing.Point(6, 36);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(115, 16);
            this.lblRegistrationDate.TabIndex = 0;
            this.lblRegistrationDate.Text = "Registration Date ";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(208, 120);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(100, 20);
            this.txtPatientID.TabIndex = 8;
            this.txtPatientID.TextChanged += new System.EventHandler(this.txtPatientID_TextChanged);
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPatientID.Location = new System.Drawing.Point(81, 127);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(65, 16);
            this.lblPatientID.TabIndex = 7;
            this.lblPatientID.Text = "Patient ID";
            this.lblPatientID.Click += new System.EventHandler(this.lblPatientID_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_Back_ManageInPa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 82);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Back_ManageInPa
            // 
            this.btn_Back_ManageInPa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Back_ManageInPa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Back_ManageInPa.FlatAppearance.BorderSize = 5;
            this.btn_Back_ManageInPa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Back_ManageInPa.Image = global::FamilyCareHospital.Properties.Resources.OPDBACK;
            this.btn_Back_ManageInPa.Location = new System.Drawing.Point(745, 22);
            this.btn_Back_ManageInPa.Name = "btn_Back_ManageInPa";
            this.btn_Back_ManageInPa.Size = new System.Drawing.Size(74, 41);
            this.btn_Back_ManageInPa.TabIndex = 25;
            this.btn_Back_ManageInPa.UseVisualStyleBackColor = false;
            this.btn_Back_ManageInPa.Click += new System.EventHandler(this.btn_Back_ManageInPa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "OPD Registration Form";
            // 
            // OPD_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(868, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpbxContactDetails);
            this.Controls.Add(this.grpbxpPatirntDetails);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.lblPatientID);
            this.Name = "OPD_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPD_Registration";
            this.Load += new System.EventHandler(this.OPD_Registration_Load);
            this.grpbxContactDetails.ResumeLayout(false);
            this.grpbxContactDetails.PerformLayout();
            this.grpbxpPatirntDetails.ResumeLayout(false);
            this.grpbxpPatirntDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpbxContactDetails;
        private System.Windows.Forms.TextBox txtContactNO;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblContactNO;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox grpbxpPatirntDetails;
        private System.Windows.Forms.TextBox txtNic_No;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtRegistrationDate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Back_ManageInPa;
    }
}