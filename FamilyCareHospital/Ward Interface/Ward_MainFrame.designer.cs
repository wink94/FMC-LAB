namespace FamilyCareHospital
{
    partial class Ward_MainFrame
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
            this.components = new System.ComponentModel.Container();
            this.panel1_MainFrame_Ward = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lblWardManagement = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewWard = new System.Windows.Forms.Button();
            this.panel3CurDate = new System.Windows.Forms.Panel();
            this.lblCurrentFullDate = new System.Windows.Forms.Label();
            this.panel2CurTime = new System.Windows.Forms.Panel();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblCurrentDayName = new System.Windows.Forms.Label();
            this.btnViewInPatient = new System.Windows.Forms.Button();
            this.panel1CurUser = new System.Windows.Forms.Panel();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.btnViewDrugStore = new System.Windows.Forms.Button();
            this.btnManageDrugStore = new System.Windows.Forms.Button();
            this.lblWardDrugStore = new System.Windows.Forms.Label();
            this.btnManageInPatient = new System.Windows.Forms.Button();
            this.btnRegisterInPatient = new System.Windows.Forms.Button();
            this.lblInPatient = new System.Windows.Forms.Label();
            this.lblWardHandling = new System.Windows.Forms.Label();
            this.btnWardHandling = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1_MainFrame_Ward.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3CurDate.SuspendLayout();
            this.panel2CurTime.SuspendLayout();
            this.panel1CurUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1_MainFrame_Ward
            // 
            this.panel1_MainFrame_Ward.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1_MainFrame_Ward.Controls.Add(this.btn_logout);
            this.panel1_MainFrame_Ward.Controls.Add(this.lblWardManagement);
            this.panel1_MainFrame_Ward.Controls.Add(this.btnHome);
            this.panel1_MainFrame_Ward.Location = new System.Drawing.Point(29, 12);
            this.panel1_MainFrame_Ward.Name = "panel1_MainFrame_Ward";
            this.panel1_MainFrame_Ward.Size = new System.Drawing.Size(1119, 61);
            this.panel1_MainFrame_Ward.TabIndex = 24;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.White;
            this.btn_logout.Image = global::FamilyCareHospital.Properties.Resources.shutdown_logout_Correct_48px;
            this.btn_logout.Location = new System.Drawing.Point(1051, 3);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(58, 52);
            this.btn_logout.TabIndex = 9;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lblWardManagement
            // 
            this.lblWardManagement.AutoSize = true;
            this.lblWardManagement.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWardManagement.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblWardManagement.Location = new System.Drawing.Point(12, 16);
            this.lblWardManagement.Name = "lblWardManagement";
            this.lblWardManagement.Size = new System.Drawing.Size(212, 30);
            this.lblWardManagement.TabIndex = 7;
            this.lblWardManagement.Text = "Ward Management";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Image = global::FamilyCareHospital.Properties.Resources.home_48px_HOME_ICON_Corrct;
            this.btnHome.Location = new System.Drawing.Point(987, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(58, 52);
            this.btnHome.TabIndex = 8;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnViewWard);
            this.panel1.Controls.Add(this.panel3CurDate);
            this.panel1.Controls.Add(this.panel2CurTime);
            this.panel1.Controls.Add(this.btnViewInPatient);
            this.panel1.Controls.Add(this.panel1CurUser);
            this.panel1.Controls.Add(this.btnViewDrugStore);
            this.panel1.Controls.Add(this.btnManageDrugStore);
            this.panel1.Controls.Add(this.lblWardDrugStore);
            this.panel1.Controls.Add(this.btnManageInPatient);
            this.panel1.Controls.Add(this.btnRegisterInPatient);
            this.panel1.Controls.Add(this.lblInPatient);
            this.panel1.Controls.Add(this.lblWardHandling);
            this.panel1.Controls.Add(this.btnWardHandling);
            this.panel1.Location = new System.Drawing.Point(29, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 554);
            this.panel1.TabIndex = 32;
            // 
            // btnViewWard
            // 
            this.btnViewWard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnViewWard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewWard.Image = global::FamilyCareHospital.Properties.Resources.VIEW_WARD_physical_therapy_filled_100px_copy;
            this.btnViewWard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewWard.Location = new System.Drawing.Point(80, 232);
            this.btnViewWard.Name = "btnViewWard";
            this.btnViewWard.Size = new System.Drawing.Size(163, 148);
            this.btnViewWard.TabIndex = 31;
            this.btnViewWard.Text = "View Ward";
            this.btnViewWard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewWard.UseVisualStyleBackColor = false;
            this.btnViewWard.Click += new System.EventHandler(this.btnViewWard_Click);
            // 
            // panel3CurDate
            // 
            this.panel3CurDate.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3CurDate.Controls.Add(this.lblCurrentFullDate);
            this.panel3CurDate.Location = new System.Drawing.Point(834, 179);
            this.panel3CurDate.Name = "panel3CurDate";
            this.panel3CurDate.Size = new System.Drawing.Size(264, 38);
            this.panel3CurDate.TabIndex = 30;
            // 
            // lblCurrentFullDate
            // 
            this.lblCurrentFullDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel2CurTime.Location = new System.Drawing.Point(834, 96);
            this.panel2CurTime.Name = "panel2CurTime";
            this.panel2CurTime.Size = new System.Drawing.Size(264, 83);
            this.panel2CurTime.TabIndex = 28;
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
            this.lblCurrentDayName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDayName.Location = new System.Drawing.Point(51, 3);
            this.lblCurrentDayName.Name = "lblCurrentDayName";
            this.lblCurrentDayName.Size = new System.Drawing.Size(160, 29);
            this.lblCurrentDayName.TabIndex = 26;
            this.lblCurrentDayName.Text = "DayName";
            this.lblCurrentDayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnViewInPatient
            // 
            this.btnViewInPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnViewInPatient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInPatient.Image = global::FamilyCareHospital.Properties.Resources.VIEW_IN_PA_wheelchair_96px_extra_c_copy;
            this.btnViewInPatient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewInPatient.Location = new System.Drawing.Point(311, 386);
            this.btnViewInPatient.Name = "btnViewInPatient";
            this.btnViewInPatient.Size = new System.Drawing.Size(163, 148);
            this.btnViewInPatient.TabIndex = 14;
            this.btnViewInPatient.Text = "View In-Patient";
            this.btnViewInPatient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewInPatient.UseVisualStyleBackColor = false;
            this.btnViewInPatient.Click += new System.EventHandler(this.btnViewInPatient_Click);
            // 
            // panel1CurUser
            // 
            this.panel1CurUser.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1CurUser.Controls.Add(this.lblCurrentUser);
            this.panel1CurUser.Location = new System.Drawing.Point(834, 63);
            this.panel1CurUser.Name = "panel1CurUser";
            this.panel1CurUser.Size = new System.Drawing.Size(264, 33);
            this.panel1CurUser.TabIndex = 25;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.Location = new System.Drawing.Point(89, 9);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(79, 21);
            this.lblCurrentUser.TabIndex = 24;
            this.lblCurrentUser.Text = "Welcome";
            // 
            // btnViewDrugStore
            // 
            this.btnViewDrugStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnViewDrugStore.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDrugStore.Image = global::FamilyCareHospital.Properties.Resources.VIEW_DRUG_STORE_pill_78px_copycopy;
            this.btnViewDrugStore.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewDrugStore.Location = new System.Drawing.Point(558, 232);
            this.btnViewDrugStore.Name = "btnViewDrugStore";
            this.btnViewDrugStore.Size = new System.Drawing.Size(163, 148);
            this.btnViewDrugStore.TabIndex = 17;
            this.btnViewDrugStore.Text = "View Drug Store";
            this.btnViewDrugStore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewDrugStore.UseVisualStyleBackColor = false;
            this.btnViewDrugStore.Click += new System.EventHandler(this.btnViewDrugStore_Click);
            // 
            // btnManageDrugStore
            // 
            this.btnManageDrugStore.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnManageDrugStore.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageDrugStore.Image = global::FamilyCareHospital.Properties.Resources.MANAGE_DRUG_STORE_pill_78px_copy;
            this.btnManageDrugStore.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManageDrugStore.Location = new System.Drawing.Point(558, 78);
            this.btnManageDrugStore.Name = "btnManageDrugStore";
            this.btnManageDrugStore.Size = new System.Drawing.Size(163, 148);
            this.btnManageDrugStore.TabIndex = 16;
            this.btnManageDrugStore.Text = "Manage Drug Store";
            this.btnManageDrugStore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManageDrugStore.UseVisualStyleBackColor = false;
            this.btnManageDrugStore.Click += new System.EventHandler(this.btnManageDrugStore_Click);
            // 
            // lblWardDrugStore
            // 
            this.lblWardDrugStore.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblWardDrugStore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWardDrugStore.Location = new System.Drawing.Point(558, 17);
            this.lblWardDrugStore.Name = "lblWardDrugStore";
            this.lblWardDrugStore.Size = new System.Drawing.Size(163, 21);
            this.lblWardDrugStore.TabIndex = 15;
            this.lblWardDrugStore.Text = "Drug Store";
            // 
            // btnManageInPatient
            // 
            this.btnManageInPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnManageInPatient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageInPatient.Image = global::FamilyCareHospital.Properties.Resources.MANAGE_IN_PA_wheelchair_96px_edit_patient;
            this.btnManageInPatient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManageInPatient.Location = new System.Drawing.Point(311, 232);
            this.btnManageInPatient.Name = "btnManageInPatient";
            this.btnManageInPatient.Size = new System.Drawing.Size(163, 148);
            this.btnManageInPatient.TabIndex = 13;
            this.btnManageInPatient.Text = "Manage In-Patient";
            this.btnManageInPatient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManageInPatient.UseVisualStyleBackColor = false;
            this.btnManageInPatient.Click += new System.EventHandler(this.btnManageInPatient_Click);
            // 
            // btnRegisterInPatient
            // 
            this.btnRegisterInPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegisterInPatient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterInPatient.Image = global::FamilyCareHospital.Properties.Resources.REGISTER_IN_PA_wheelchair_96px_copy;
            this.btnRegisterInPatient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegisterInPatient.Location = new System.Drawing.Point(311, 78);
            this.btnRegisterInPatient.Name = "btnRegisterInPatient";
            this.btnRegisterInPatient.Size = new System.Drawing.Size(163, 148);
            this.btnRegisterInPatient.TabIndex = 12;
            this.btnRegisterInPatient.Text = "Register In-Patient";
            this.btnRegisterInPatient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegisterInPatient.UseVisualStyleBackColor = false;
            this.btnRegisterInPatient.Click += new System.EventHandler(this.btnRegisterInPatient_Click);
            // 
            // lblInPatient
            // 
            this.lblInPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblInPatient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInPatient.Location = new System.Drawing.Point(310, 17);
            this.lblInPatient.Name = "lblInPatient";
            this.lblInPatient.Size = new System.Drawing.Size(163, 21);
            this.lblInPatient.TabIndex = 11;
            this.lblInPatient.Text = "In - Patient";
            // 
            // lblWardHandling
            // 
            this.lblWardHandling.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblWardHandling.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWardHandling.Location = new System.Drawing.Point(80, 17);
            this.lblWardHandling.Name = "lblWardHandling";
            this.lblWardHandling.Size = new System.Drawing.Size(163, 21);
            this.lblWardHandling.TabIndex = 6;
            this.lblWardHandling.Text = "Ward Handling";
            // 
            // btnWardHandling
            // 
            this.btnWardHandling.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnWardHandling.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWardHandling.Image = global::FamilyCareHospital.Properties.Resources.MANAGE_WARD_physical_therapy_filled_100px;
            this.btnWardHandling.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWardHandling.Location = new System.Drawing.Point(80, 78);
            this.btnWardHandling.Name = "btnWardHandling";
            this.btnWardHandling.Size = new System.Drawing.Size(163, 148);
            this.btnWardHandling.TabIndex = 4;
            this.btnWardHandling.Text = "Manage Ward";
            this.btnWardHandling.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWardHandling.UseVisualStyleBackColor = false;
            this.btnWardHandling.Click += new System.EventHandler(this.btnWardHandling_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Ward_MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel1_MainFrame_Ward);
            this.Name = "Ward_MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Family Care Hospital Pvt.Ltd";
            this.panel1_MainFrame_Ward.ResumeLayout(false);
            this.panel1_MainFrame_Ward.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3CurDate.ResumeLayout(false);
            this.panel2CurTime.ResumeLayout(false);
            this.panel1CurUser.ResumeLayout(false);
            this.panel1CurUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_MainFrame_Ward;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lblWardManagement;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3CurDate;
        private System.Windows.Forms.Label lblCurrentFullDate;
        private System.Windows.Forms.Panel panel2CurTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblCurrentDayName;
        private System.Windows.Forms.Button btnViewInPatient;
        private System.Windows.Forms.Panel panel1CurUser;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Button btnViewDrugStore;
        private System.Windows.Forms.Button btnManageDrugStore;
        private System.Windows.Forms.Label lblWardDrugStore;
        private System.Windows.Forms.Button btnManageInPatient;
        private System.Windows.Forms.Button btnRegisterInPatient;
        private System.Windows.Forms.Label lblInPatient;
        private System.Windows.Forms.Label lblWardHandling;
        private System.Windows.Forms.Button btnWardHandling;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnViewWard;
    }
}