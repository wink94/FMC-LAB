namespace FamilyCareHospital
{
    partial class Prescriptionview
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dgvClinic_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRegistration_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFirst_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLast_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvChistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMedication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Back_ManageInPa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::FamilyCareHospital.Properties.Resources.OPDREFRESH;
            this.btnRefresh.Location = new System.Drawing.Point(570, 159);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 42);
            this.btnRefresh.TabIndex = 42;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::FamilyCareHospital.Properties.Resources.OPDSEARCH;
            this.btnSearch.Location = new System.Drawing.Point(438, 159);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 42);
            this.btnSearch.TabIndex = 41;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(279, 180);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 40;
            this.txtSearch.Tag = "fdg";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvClinic_ID,
            this.dgvRegistration_Date,
            this.dgvFirst_Name,
            this.dgvLast_Name,
            this.dgvChistory,
            this.dgvMedication,
            this.dgvNote,
            this.dgvdelete});
            this.dataGridView2.Location = new System.Drawing.Point(169, 252);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(842, 398);
            this.dataGridView2.TabIndex = 39;
            // 
            // dgvClinic_ID
            // 
            this.dgvClinic_ID.DataPropertyName = "ClinicID";
            this.dgvClinic_ID.HeaderText = "Clinic ID";
            this.dgvClinic_ID.Name = "dgvClinic_ID";
            // 
            // dgvRegistration_Date
            // 
            this.dgvRegistration_Date.DataPropertyName = "Date";
            this.dgvRegistration_Date.HeaderText = "Date";
            this.dgvRegistration_Date.Name = "dgvRegistration_Date";
            // 
            // dgvFirst_Name
            // 
            this.dgvFirst_Name.DataPropertyName = "Fname";
            this.dgvFirst_Name.HeaderText = "First Name";
            this.dgvFirst_Name.Name = "dgvFirst_Name";
            // 
            // dgvLast_Name
            // 
            this.dgvLast_Name.DataPropertyName = "Lname";
            this.dgvLast_Name.HeaderText = "Last Name";
            this.dgvLast_Name.Name = "dgvLast_Name";
            // 
            // dgvChistory
            // 
            this.dgvChistory.DataPropertyName = "Chistory";
            this.dgvChistory.HeaderText = "Case History";
            this.dgvChistory.Name = "dgvChistory";
            // 
            // dgvMedication
            // 
            this.dgvMedication.DataPropertyName = "Medication";
            this.dgvMedication.HeaderText = "Medication";
            this.dgvMedication.Name = "dgvMedication";
            // 
            // dgvNote
            // 
            this.dgvNote.DataPropertyName = "Note";
            this.dgvNote.HeaderText = "Note";
            this.dgvNote.Name = "dgvNote";
            // 
            // dgvdelete
            // 
            this.dgvdelete.DataPropertyName = "Delete";
            this.dgvdelete.HeaderText = "Delete";
            this.dgvdelete.Name = "dgvdelete";
            this.dgvdelete.Text = "Delete";
            this.dgvdelete.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_Back_ManageInPa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 100);
            this.panel1.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "View Prescription Details";
            // 
            // btn_Back_ManageInPa
            // 
            this.btn_Back_ManageInPa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Back_ManageInPa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Back_ManageInPa.FlatAppearance.BorderSize = 5;
            this.btn_Back_ManageInPa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Back_ManageInPa.Image = global::FamilyCareHospital.Properties.Resources.OPDBACK;
            this.btn_Back_ManageInPa.Location = new System.Drawing.Point(1138, 36);
            this.btn_Back_ManageInPa.Name = "btn_Back_ManageInPa";
            this.btn_Back_ManageInPa.Size = new System.Drawing.Size(74, 41);
            this.btn_Back_ManageInPa.TabIndex = 26;
            this.btn_Back_ManageInPa.UseVisualStyleBackColor = false;
            this.btn_Back_ManageInPa.Click += new System.EventHandler(this.btn_Back_ManageInPa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Presc ID";
            // 
            // Prescriptionview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1276, 693);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Prescriptionview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prescriptionview";
            this.Load += new System.EventHandler(this.Prescriptionview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClinic_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRegistration_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFirst_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLast_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvChistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMedication;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNote;
        private System.Windows.Forms.DataGridViewButtonColumn dgvdelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Back_ManageInPa;
        private System.Windows.Forms.Label label1;
    }
}