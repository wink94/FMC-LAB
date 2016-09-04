namespace FamilyCareHospital
{
    partial class OPDmain
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnadvance_bill = new System.Windows.Forms.Button();
            this.btnopd_bill = new System.Windows.Forms.Button();
            this.btnclinic_bill = new System.Windows.Forms.Button();
            this.btnfull_bill = new System.Windows.Forms.Button();
            this.btnview_presc = new System.Windows.Forms.Button();
            this.btnpresc_manage = new System.Windows.Forms.Button();
            this.btnview_clinic = new System.Windows.Forms.Button();
            this.btnmanage_clinic = new System.Windows.Forms.Button();
            this.btnmanage_opd = new System.Windows.Forms.Button();
            this.btnview_opd = new System.Windows.Forms.Button();
            this.panel3CurDate = new System.Windows.Forms.Panel();
            this.lblCurrentFullDate = new System.Windows.Forms.Label();
            this.panel2CurTime = new System.Windows.Forms.Panel();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblCurrentDayName = new System.Windows.Forms.Label();
            this.panel1CurUser = new System.Windows.Forms.Panel();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3CurDate.SuspendLayout();
            this.panel2CurTime.SuspendLayout();
            this.panel1CurUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(633, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Payments";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Prescription";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Clinic";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "OPD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(37, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "OPD,Clinic And Billing";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 84);
            this.panel1.TabIndex = 28;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::FamilyCareHospital.Properties.Resources.OPDlogout;
            this.btnLogOut.Location = new System.Drawing.Point(1207, 23);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(58, 52);
            this.btnLogOut.TabIndex = 17;
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Image = global::FamilyCareHospital.Properties.Resources.OPDHOME;
            this.btnHome.Location = new System.Drawing.Point(1143, 23);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(58, 52);
            this.btnHome.TabIndex = 16;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnadvance_bill
            // 
            this.btnadvance_bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnadvance_bill.Image = global::FamilyCareHospital.Properties.Resources.banknotes_64px;
            this.btnadvance_bill.Location = new System.Drawing.Point(633, 393);
            this.btnadvance_bill.Name = "btnadvance_bill";
            this.btnadvance_bill.Size = new System.Drawing.Size(121, 97);
            this.btnadvance_bill.TabIndex = 23;
            this.btnadvance_bill.Text = "Advance Payment";
            this.btnadvance_bill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadvance_bill.UseVisualStyleBackColor = false;
            this.btnadvance_bill.Click += new System.EventHandler(this.btnadvance_bill_Click);
            // 
            // btnopd_bill
            // 
            this.btnopd_bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnopd_bill.Image = global::FamilyCareHospital.Properties.Resources.banknotes_64px;
            this.btnopd_bill.Location = new System.Drawing.Point(787, 268);
            this.btnopd_bill.Name = "btnopd_bill";
            this.btnopd_bill.Size = new System.Drawing.Size(121, 97);
            this.btnopd_bill.TabIndex = 22;
            this.btnopd_bill.Text = "OPD Bill";
            this.btnopd_bill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnopd_bill.UseVisualStyleBackColor = false;
            this.btnopd_bill.Click += new System.EventHandler(this.btnopd_bill_Click);
            // 
            // btnclinic_bill
            // 
            this.btnclinic_bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnclinic_bill.Image = global::FamilyCareHospital.Properties.Resources.banknotes_64px;
            this.btnclinic_bill.Location = new System.Drawing.Point(787, 393);
            this.btnclinic_bill.Name = "btnclinic_bill";
            this.btnclinic_bill.Size = new System.Drawing.Size(121, 97);
            this.btnclinic_bill.TabIndex = 21;
            this.btnclinic_bill.Text = "Clinic Bill";
            this.btnclinic_bill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnclinic_bill.UseVisualStyleBackColor = false;
            this.btnclinic_bill.Click += new System.EventHandler(this.btnclinic_bill_Click);
            // 
            // btnfull_bill
            // 
            this.btnfull_bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnfull_bill.Image = global::FamilyCareHospital.Properties.Resources.banknotes_64px;
            this.btnfull_bill.Location = new System.Drawing.Point(633, 268);
            this.btnfull_bill.Name = "btnfull_bill";
            this.btnfull_bill.Size = new System.Drawing.Size(121, 97);
            this.btnfull_bill.TabIndex = 20;
            this.btnfull_bill.Text = "Full Bill";
            this.btnfull_bill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnfull_bill.UseVisualStyleBackColor = false;
            this.btnfull_bill.Click += new System.EventHandler(this.btnfull_bill_Click);
            // 
            // btnview_presc
            // 
            this.btnview_presc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(165)))), ((int)(((byte)(215)))));
            this.btnview_presc.Image = global::FamilyCareHospital.Properties.Resources.survey_64px;
            this.btnview_presc.Location = new System.Drawing.Point(478, 393);
            this.btnview_presc.Name = "btnview_presc";
            this.btnview_presc.Size = new System.Drawing.Size(121, 97);
            this.btnview_presc.TabIndex = 19;
            this.btnview_presc.Text = "View Prescription";
            this.btnview_presc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnview_presc.UseVisualStyleBackColor = false;
            this.btnview_presc.Click += new System.EventHandler(this.btnview_presc_Click);
            // 
            // btnpresc_manage
            // 
            this.btnpresc_manage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnpresc_manage.Image = global::FamilyCareHospital.Properties.Resources.document_64px;
            this.btnpresc_manage.Location = new System.Drawing.Point(478, 268);
            this.btnpresc_manage.Name = "btnpresc_manage";
            this.btnpresc_manage.Size = new System.Drawing.Size(121, 97);
            this.btnpresc_manage.TabIndex = 18;
            this.btnpresc_manage.Text = "Manage Prescription";
            this.btnpresc_manage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnpresc_manage.UseVisualStyleBackColor = false;
            this.btnpresc_manage.Click += new System.EventHandler(this.btnpresc_manage_Click);
            // 
            // btnview_clinic
            // 
            this.btnview_clinic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(190)))), ((int)(((byte)(180)))));
            this.btnview_clinic.Image = global::FamilyCareHospital.Properties.Resources.survey_64px;
            this.btnview_clinic.Location = new System.Drawing.Point(320, 393);
            this.btnview_clinic.Name = "btnview_clinic";
            this.btnview_clinic.Size = new System.Drawing.Size(121, 97);
            this.btnview_clinic.TabIndex = 17;
            this.btnview_clinic.Text = "View Clinic Patient";
            this.btnview_clinic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnview_clinic.UseVisualStyleBackColor = false;
            this.btnview_clinic.Click += new System.EventHandler(this.btnview_clinic_Click);
            // 
            // btnmanage_clinic
            // 
            this.btnmanage_clinic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.btnmanage_clinic.Image = global::FamilyCareHospital.Properties.Resources.wheelchair_72px;
            this.btnmanage_clinic.Location = new System.Drawing.Point(320, 268);
            this.btnmanage_clinic.Name = "btnmanage_clinic";
            this.btnmanage_clinic.Size = new System.Drawing.Size(121, 97);
            this.btnmanage_clinic.TabIndex = 16;
            this.btnmanage_clinic.Text = "Manage Clinic Patient ";
            this.btnmanage_clinic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmanage_clinic.UseVisualStyleBackColor = false;
            this.btnmanage_clinic.Click += new System.EventHandler(this.btnmanage_clinic_Click);
            // 
            // btnmanage_opd
            // 
            this.btnmanage_opd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmanage_opd.Image = global::FamilyCareHospital.Properties.Resources.outpatient_icon_49432;
            this.btnmanage_opd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmanage_opd.Location = new System.Drawing.Point(158, 268);
            this.btnmanage_opd.Name = "btnmanage_opd";
            this.btnmanage_opd.Size = new System.Drawing.Size(121, 97);
            this.btnmanage_opd.TabIndex = 15;
            this.btnmanage_opd.Text = "Manage Out-Patient";
            this.btnmanage_opd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmanage_opd.UseVisualStyleBackColor = false;
            this.btnmanage_opd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnview_opd
            // 
            this.btnview_opd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnview_opd.Image = global::FamilyCareHospital.Properties.Resources.survey_64px;
            this.btnview_opd.Location = new System.Drawing.Point(158, 393);
            this.btnview_opd.Name = "btnview_opd";
            this.btnview_opd.Size = new System.Drawing.Size(121, 97);
            this.btnview_opd.TabIndex = 14;
            this.btnview_opd.Text = "View Out-Patient ";
            this.btnview_opd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnview_opd.UseVisualStyleBackColor = false;
            this.btnview_opd.Click += new System.EventHandler(this.button11_Click);
            // 
            // panel3CurDate
            // 
            this.panel3CurDate.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3CurDate.Controls.Add(this.lblCurrentFullDate);
            this.panel3CurDate.Location = new System.Drawing.Point(987, 340);
            this.panel3CurDate.Name = "panel3CurDate";
            this.panel3CurDate.Size = new System.Drawing.Size(264, 38);
            this.panel3CurDate.TabIndex = 33;
            // 
            // lblCurrentFullDate
            // 
            this.lblCurrentFullDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentFullDate.ForeColor = System.Drawing.Color.White;
            this.lblCurrentFullDate.Location = new System.Drawing.Point(8, 3);
            this.lblCurrentFullDate.Name = "lblCurrentFullDate";
            this.lblCurrentFullDate.Size = new System.Drawing.Size(240, 27);
            this.lblCurrentFullDate.TabIndex = 29;
            this.lblCurrentFullDate.Text = "Date";
            this.lblCurrentFullDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2CurTime
            // 
            this.panel2CurTime.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2CurTime.Controls.Add(this.lblCurrentTime);
            this.panel2CurTime.Controls.Add(this.lblCurrentDayName);
            this.panel2CurTime.Location = new System.Drawing.Point(987, 257);
            this.panel2CurTime.Name = "panel2CurTime";
            this.panel2CurTime.Size = new System.Drawing.Size(264, 83);
            this.panel2CurTime.TabIndex = 32;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(12, 41);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(236, 23);
            this.lblCurrentTime.TabIndex = 27;
            this.lblCurrentTime.Text = "00:00:00";
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentDayName
            // 
            this.lblCurrentDayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDayName.Location = new System.Drawing.Point(51, 3);
            this.lblCurrentDayName.Name = "lblCurrentDayName";
            this.lblCurrentDayName.Size = new System.Drawing.Size(160, 29);
            this.lblCurrentDayName.TabIndex = 26;
            this.lblCurrentDayName.Text = "DayName";
            this.lblCurrentDayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1CurUser
            // 
            this.panel1CurUser.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1CurUser.Controls.Add(this.lblCurrentUser);
            this.panel1CurUser.Location = new System.Drawing.Point(987, 224);
            this.panel1CurUser.Name = "panel1CurUser";
            this.panel1CurUser.Size = new System.Drawing.Size(264, 33);
            this.panel1CurUser.TabIndex = 31;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.Location = new System.Drawing.Point(89, 9);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(72, 18);
            this.lblCurrentUser.TabIndex = 24;
            this.lblCurrentUser.Text = "Welcome";
            // 
            // OPDmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1276, 693);
            this.Controls.Add(this.panel3CurDate);
            this.Controls.Add(this.panel2CurTime);
            this.Controls.Add(this.panel1CurUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadvance_bill);
            this.Controls.Add(this.btnopd_bill);
            this.Controls.Add(this.btnclinic_bill);
            this.Controls.Add(this.btnfull_bill);
            this.Controls.Add(this.btnview_presc);
            this.Controls.Add(this.btnpresc_manage);
            this.Controls.Add(this.btnview_clinic);
            this.Controls.Add(this.btnmanage_clinic);
            this.Controls.Add(this.btnmanage_opd);
            this.Controls.Add(this.btnview_opd);
            this.Name = "OPDmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPDmain";
            this.Load += new System.EventHandler(this.OPDmain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3CurDate.ResumeLayout(false);
            this.panel2CurTime.ResumeLayout(false);
            this.panel1CurUser.ResumeLayout(false);
            this.panel1CurUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadvance_bill;
        private System.Windows.Forms.Button btnopd_bill;
        private System.Windows.Forms.Button btnclinic_bill;
        private System.Windows.Forms.Button btnfull_bill;
        private System.Windows.Forms.Button btnview_presc;
        private System.Windows.Forms.Button btnpresc_manage;
        private System.Windows.Forms.Button btnview_clinic;
        private System.Windows.Forms.Button btnmanage_clinic;
        private System.Windows.Forms.Button btnmanage_opd;
        private System.Windows.Forms.Button btnview_opd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel3CurDate;
        private System.Windows.Forms.Label lblCurrentFullDate;
        private System.Windows.Forms.Panel panel2CurTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblCurrentDayName;
        private System.Windows.Forms.Panel panel1CurUser;
        private System.Windows.Forms.Label lblCurrentUser;
    }
}