namespace FamilyCareHospital
{
    partial class Ward_Admin_ViewWard_WHandling
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
            this.lblViewWard = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1_ViewWard = new System.Windows.Forms.Panel();
            this.btn_AllDetails = new System.Windows.Forms.Button();
            this.btn_BedDetails = new System.Windows.Forms.Button();
            this.btn_RoomDetails = new System.Windows.Forms.Button();
            this.btn_ClassDetails = new System.Windows.Forms.Button();
            this.btn_WardDetails = new System.Windows.Forms.Button();
            this.dataGridView1_ViewWard = new System.Windows.Forms.DataGridView();
            this.panel1_ViewWard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_ViewWard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblViewWard
            // 
            this.lblViewWard.AutoSize = true;
            this.lblViewWard.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewWard.ForeColor = System.Drawing.Color.White;
            this.lblViewWard.Location = new System.Drawing.Point(18, 20);
            this.lblViewWard.Name = "lblViewWard";
            this.lblViewWard.Size = new System.Drawing.Size(260, 37);
            this.lblViewWard.TabIndex = 17;
            this.lblViewWard.Text = "View Ward Details";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGray;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.BorderSize = 5;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBack.Image = global::FamilyCareHospital.Properties.Resources.BACK_undo_32px;
            this.btnBack.Location = new System.Drawing.Point(900, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 41);
            this.btnBack.TabIndex = 19;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1_ViewWard
            // 
            this.panel1_ViewWard.BackColor = System.Drawing.Color.Azure;
            this.panel1_ViewWard.Controls.Add(this.btn_AllDetails);
            this.panel1_ViewWard.Controls.Add(this.btn_BedDetails);
            this.panel1_ViewWard.Controls.Add(this.btn_RoomDetails);
            this.panel1_ViewWard.Controls.Add(this.btn_ClassDetails);
            this.panel1_ViewWard.Controls.Add(this.btn_WardDetails);
            this.panel1_ViewWard.Controls.Add(this.dataGridView1_ViewWard);
            this.panel1_ViewWard.Location = new System.Drawing.Point(25, 98);
            this.panel1_ViewWard.Name = "panel1_ViewWard";
            this.panel1_ViewWard.Size = new System.Drawing.Size(949, 498);
            this.panel1_ViewWard.TabIndex = 20;
            // 
            // btn_AllDetails
            // 
            this.btn_AllDetails.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_AllDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AllDetails.Location = new System.Drawing.Point(23, 47);
            this.btn_AllDetails.Name = "btn_AllDetails";
            this.btn_AllDetails.Size = new System.Drawing.Size(159, 57);
            this.btn_AllDetails.TabIndex = 16;
            this.btn_AllDetails.Text = "All Details";
            this.btn_AllDetails.UseVisualStyleBackColor = false;
            this.btn_AllDetails.Click += new System.EventHandler(this.btn_AllDetails_Click);
            // 
            // btn_BedDetails
            // 
            this.btn_BedDetails.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_BedDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BedDetails.Location = new System.Drawing.Point(764, 47);
            this.btn_BedDetails.Name = "btn_BedDetails";
            this.btn_BedDetails.Size = new System.Drawing.Size(159, 57);
            this.btn_BedDetails.TabIndex = 15;
            this.btn_BedDetails.Text = "Bed Details";
            this.btn_BedDetails.UseVisualStyleBackColor = false;
            this.btn_BedDetails.Click += new System.EventHandler(this.btn_BedDetails_Click);
            // 
            // btn_RoomDetails
            // 
            this.btn_RoomDetails.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_RoomDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RoomDetails.Location = new System.Drawing.Point(576, 47);
            this.btn_RoomDetails.Name = "btn_RoomDetails";
            this.btn_RoomDetails.Size = new System.Drawing.Size(159, 57);
            this.btn_RoomDetails.TabIndex = 14;
            this.btn_RoomDetails.Text = "Room Details";
            this.btn_RoomDetails.UseVisualStyleBackColor = false;
            this.btn_RoomDetails.Click += new System.EventHandler(this.btn_RoomDetails_Click);
            // 
            // btn_ClassDetails
            // 
            this.btn_ClassDetails.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_ClassDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClassDetails.Location = new System.Drawing.Point(389, 47);
            this.btn_ClassDetails.Name = "btn_ClassDetails";
            this.btn_ClassDetails.Size = new System.Drawing.Size(159, 57);
            this.btn_ClassDetails.TabIndex = 13;
            this.btn_ClassDetails.Text = "Class Details";
            this.btn_ClassDetails.UseVisualStyleBackColor = false;
            this.btn_ClassDetails.Click += new System.EventHandler(this.btn_ClassDetails_Click);
            // 
            // btn_WardDetails
            // 
            this.btn_WardDetails.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_WardDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WardDetails.Location = new System.Drawing.Point(205, 47);
            this.btn_WardDetails.Name = "btn_WardDetails";
            this.btn_WardDetails.Size = new System.Drawing.Size(159, 57);
            this.btn_WardDetails.TabIndex = 12;
            this.btn_WardDetails.Text = "Ward Details";
            this.btn_WardDetails.UseVisualStyleBackColor = false;
            this.btn_WardDetails.Click += new System.EventHandler(this.btn_WardDetails_Click);
            // 
            // dataGridView1_ViewWard
            // 
            this.dataGridView1_ViewWard.AllowUserToAddRows = false;
            this.dataGridView1_ViewWard.AllowUserToDeleteRows = false;
            this.dataGridView1_ViewWard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1_ViewWard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1_ViewWard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_ViewWard.Location = new System.Drawing.Point(23, 155);
            this.dataGridView1_ViewWard.Name = "dataGridView1_ViewWard";
            this.dataGridView1_ViewWard.ReadOnly = true;
            this.dataGridView1_ViewWard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_ViewWard.Size = new System.Drawing.Size(900, 320);
            this.dataGridView1_ViewWard.TabIndex = 0;
            // 
            // Ward_Admin_ViewWard_WHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(993, 616);
            this.Controls.Add(this.panel1_ViewWard);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblViewWard);
            this.Name = "Ward_Admin_ViewWard_WHandling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ward Handling";
            this.panel1_ViewWard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_ViewWard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewWard;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1_ViewWard;
        private System.Windows.Forms.DataGridView dataGridView1_ViewWard;
        private System.Windows.Forms.Button btn_BedDetails;
        private System.Windows.Forms.Button btn_RoomDetails;
        private System.Windows.Forms.Button btn_ClassDetails;
        private System.Windows.Forms.Button btn_WardDetails;
        private System.Windows.Forms.Button btn_AllDetails;
    }
}