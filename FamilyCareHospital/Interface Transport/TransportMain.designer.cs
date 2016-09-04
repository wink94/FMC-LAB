namespace FamilyCareHospital
{
    partial class TransportMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransportMain));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.HM = new System.Windows.Forms.Button();
            this.ST = new System.Windows.Forms.Button();
            this.PD = new System.Windows.Forms.Button();
            this.V_D = new System.Windows.Forms.Button();
            this.D_D = new System.Windows.Forms.Button();
            this.P_D = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_user = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome to Transport Management system ";
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.Image = global::FamilyCareHospital.Properties.Resources.logout_rounded_up_filled_25px;
            this.btn_logout.Location = new System.Drawing.Point(1132, 0);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(50, 50);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // HM
            // 
            this.HM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HM.Image = global::FamilyCareHospital.Properties.Resources.home_48px;
            this.HM.Location = new System.Drawing.Point(1079, 0);
            this.HM.Name = "HM";
            this.HM.Size = new System.Drawing.Size(50, 50);
            this.HM.TabIndex = 5;
            this.HM.UseVisualStyleBackColor = true;
            // 
            // ST
            // 
            this.ST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ST.BackColor = System.Drawing.Color.Orange;
            this.ST.BackgroundImage = global::FamilyCareHospital.Properties.Resources.transaction_list_100px;
            this.ST.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ST.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ST.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ST.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ST.Location = new System.Drawing.Point(965, 283);
            this.ST.Name = "ST";
            this.ST.Size = new System.Drawing.Size(160, 150);
            this.ST.TabIndex = 4;
            this.ST.Text = "Statement";
            this.ST.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ST.UseVisualStyleBackColor = false;
            this.ST.Click += new System.EventHandler(this.ST_Click);
            // 
            // PD
            // 
            this.PD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PD.BackgroundImage = global::FamilyCareHospital.Properties.Resources.banknotes_100px;
            this.PD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PD.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PD.Location = new System.Drawing.Point(739, 283);
            this.PD.Name = "PD";
            this.PD.Size = new System.Drawing.Size(160, 150);
            this.PD.TabIndex = 3;
            this.PD.Text = "Payment Details";
            this.PD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PD.UseVisualStyleBackColor = false;
            this.PD.Click += new System.EventHandler(this.PD_Click);
            // 
            // V_D
            // 
            this.V_D.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.V_D.BackColor = System.Drawing.Color.LightSalmon;
            this.V_D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.V_D.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_D.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.V_D.Image = global::FamilyCareHospital.Properties.Resources.ambulance_100px;
            this.V_D.Location = new System.Drawing.Point(513, 283);
            this.V_D.Name = "V_D";
            this.V_D.Size = new System.Drawing.Size(160, 150);
            this.V_D.TabIndex = 2;
            this.V_D.Text = "Vehcile Details";
            this.V_D.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.V_D.UseVisualStyleBackColor = false;
            this.V_D.Click += new System.EventHandler(this.V_D_Click);
            // 
            // D_D
            // 
            this.D_D.BackColor = System.Drawing.Color.DarkOrange;
            this.D_D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D_D.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_D.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.D_D.Image = global::FamilyCareHospital.Properties.Resources.driver_100px_1;
            this.D_D.Location = new System.Drawing.Point(287, 283);
            this.D_D.Name = "D_D";
            this.D_D.Size = new System.Drawing.Size(160, 150);
            this.D_D.TabIndex = 1;
            this.D_D.Text = "Drivers Details";
            this.D_D.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.D_D.UseVisualStyleBackColor = false;
            this.D_D.Click += new System.EventHandler(this.D_D_Click);
            // 
            // P_D
            // 
            this.P_D.BackColor = System.Drawing.Color.Gold;
            this.P_D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.P_D.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_D.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.P_D.Image = global::FamilyCareHospital.Properties.Resources.add_user_male_100px;
            this.P_D.Location = new System.Drawing.Point(61, 283);
            this.P_D.Name = "P_D";
            this.P_D.Size = new System.Drawing.Size(160, 150);
            this.P_D.TabIndex = 0;
            this.P_D.Text = "Patient Details";
            this.P_D.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.P_D.UseVisualStyleBackColor = false;
            this.P_D.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.HM);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 51);
            this.panel1.TabIndex = 8;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(1086, 82);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(44, 20);
            this.lbl_user.TabIndex = 9;
            this.lbl_user.Text = "user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1022, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "User  :";
            // 
            // TransportMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ST);
            this.Controls.Add(this.PD);
            this.Controls.Add(this.V_D);
            this.Controls.Add(this.D_D);
            this.Controls.Add(this.P_D);
            this.Name = "TransportMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.TransportMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button P_D;
        private System.Windows.Forms.Button D_D;
        private System.Windows.Forms.Button V_D;
        private System.Windows.Forms.Button PD;
        private System.Windows.Forms.Button ST;
        private System.Windows.Forms.Button HM;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label label2;
    }
}