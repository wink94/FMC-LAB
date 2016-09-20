namespace FamilyCareHospital.Interfaces
{
    partial class LabPatientBill
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPNameTag = new System.Windows.Forms.Label();
            this.lblPName = new System.Windows.Forms.Label();
            this.lblPAgeTag = new System.Windows.Forms.Label();
            this.lblPAge = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPGender = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPEmail = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPAppDate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpBxTestPrices = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPTele = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpBxTestPrices.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Purple;
            this.btnSubmit.Image = global::FamilyCareHospital.Properties.Resources.ADD_add_file_64px;
            this.btnSubmit.Location = new System.Drawing.Point(665, 547);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(65, 65);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::FamilyCareHospital.Properties.Resources.cancel_48px;
            this.btnCancel.Location = new System.Drawing.Point(771, 547);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 65);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(547, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = " Bill";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpBxTestPrices);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(231, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 470);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblPNameTag
            // 
            this.lblPNameTag.AutoSize = true;
            this.lblPNameTag.Location = new System.Drawing.Point(41, 26);
            this.lblPNameTag.Name = "lblPNameTag";
            this.lblPNameTag.Size = new System.Drawing.Size(56, 21);
            this.lblPNameTag.TabIndex = 0;
            this.lblPNameTag.Text = "Name";
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPName.Location = new System.Drawing.Point(239, 25);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(57, 21);
            this.lblPName.TabIndex = 0;
            this.lblPName.Text = "label2";
            // 
            // lblPAgeTag
            // 
            this.lblPAgeTag.AutoSize = true;
            this.lblPAgeTag.Location = new System.Drawing.Point(41, 65);
            this.lblPAgeTag.Name = "lblPAgeTag";
            this.lblPAgeTag.Size = new System.Drawing.Size(40, 21);
            this.lblPAgeTag.TabIndex = 0;
            this.lblPAgeTag.Text = "Age";
            // 
            // lblPAge
            // 
            this.lblPAge.AutoSize = true;
            this.lblPAge.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPAge.Location = new System.Drawing.Point(239, 64);
            this.lblPAge.Name = "lblPAge";
            this.lblPAge.Size = new System.Drawing.Size(57, 21);
            this.lblPAge.TabIndex = 0;
            this.lblPAge.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gender";
            // 
            // lblPGender
            // 
            this.lblPGender.AutoSize = true;
            this.lblPGender.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPGender.Location = new System.Drawing.Point(239, 102);
            this.lblPGender.Name = "lblPGender";
            this.lblPGender.Size = new System.Drawing.Size(57, 21);
            this.lblPGender.TabIndex = 0;
            this.lblPGender.Text = "label2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Email";
            // 
            // lblPEmail
            // 
            this.lblPEmail.AutoSize = true;
            this.lblPEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPEmail.Location = new System.Drawing.Point(239, 154);
            this.lblPEmail.Name = "lblPEmail";
            this.lblPEmail.Size = new System.Drawing.Size(57, 21);
            this.lblPEmail.TabIndex = 0;
            this.lblPEmail.Text = "label2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Apponitment Date";
            // 
            // lblPAppDate
            // 
            this.lblPAppDate.AutoSize = true;
            this.lblPAppDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPAppDate.Location = new System.Drawing.Point(239, 241);
            this.lblPAppDate.Name = "lblPAppDate";
            this.lblPAppDate.Size = new System.Drawing.Size(57, 21);
            this.lblPAppDate.TabIndex = 0;
            this.lblPAppDate.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.lblPNameTag);
            this.groupBox2.Controls.Add(this.lblPTele);
            this.groupBox2.Controls.Add(this.lblPAppDate);
            this.groupBox2.Controls.Add(this.lblPAgeTag);
            this.groupBox2.Controls.Add(this.lblPEmail);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblPGender);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblPAge);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblPName);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 281);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Details";
            // 
            // grpBxTestPrices
            // 
            this.grpBxTestPrices.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.grpBxTestPrices.Controls.Add(this.label4);
            this.grpBxTestPrices.Controls.Add(this.label3);
            this.grpBxTestPrices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxTestPrices.Location = new System.Drawing.Point(458, 34);
            this.grpBxTestPrices.Name = "grpBxTestPrices";
            this.grpBxTestPrices.Size = new System.Drawing.Size(322, 416);
            this.grpBxTestPrices.TabIndex = 2;
            this.grpBxTestPrices.TabStop = false;
            this.grpBxTestPrices.Text = "Total Test Prices";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phone Number";
            // 
            // lblPTele
            // 
            this.lblPTele.AutoSize = true;
            this.lblPTele.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPTele.Location = new System.Drawing.Point(239, 203);
            this.lblPTele.Name = "lblPTele";
            this.lblPTele.Size = new System.Drawing.Size(57, 21);
            this.lblPTele.TabIndex = 0;
            this.lblPTele.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(26, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Test Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(209, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Test Price";
            // 
            // LabPatientBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.MaximizeBox = false;
            this.Name = "LabPatientBill";
            this.Text = "LabPatientBill";
            this.Load += new System.EventHandler(this.LabPatientBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpBxTestPrices.ResumeLayout(false);
            this.grpBxTestPrices.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpBxTestPrices;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPNameTag;
        private System.Windows.Forms.Label lblPAppDate;
        private System.Windows.Forms.Label lblPAgeTag;
        private System.Windows.Forms.Label lblPEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPAge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.Label lblPTele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}