namespace FamilyCareHospital
{
    partial class In_Patient_Transfer_Form
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
            this.lbl_Transfer_InPa = new System.Windows.Forms.Label();
            this.panel1_Transfer_InPa = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1_Transfer_InPa = new System.Windows.Forms.DataGridView();
            this.btn_Refresh_Transfer = new System.Windows.Forms.Button();
            this.btn_Check_Transfer = new System.Windows.Forms.Button();
            this.groupBox1_Transfer_InPa = new System.Windows.Forms.GroupBox();
            this.btnUpdate_Transfer = new System.Windows.Forms.Button();
            this.panel2_Transfer_InPa = new System.Windows.Forms.Panel();
            this.txt_Transfer_InPa_LName = new System.Windows.Forms.TextBox();
            this.lbl_Transfer_InPa_LName = new System.Windows.Forms.Label();
            this.txt_Transfer_InPa_ID = new System.Windows.Forms.TextBox();
            this.txt_Transfer_InPa_FName = new System.Windows.Forms.TextBox();
            this.lbl_Transfer_InPa_ID = new System.Windows.Forms.Label();
            this.lbl_Transfer_InPa_FName = new System.Windows.Forms.Label();
            this.panel3_Transfer_InPa = new System.Windows.Forms.Panel();
            this.txt_Transfer_Floor = new System.Windows.Forms.TextBox();
            this.txt_Transfer_Status = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Transfer_BedNo = new System.Windows.Forms.TextBox();
            this.txt_Transfer_RoomNo = new System.Windows.Forms.TextBox();
            this.txt_Transfer_WardID = new System.Windows.Forms.TextBox();
            this.txt_Transfer_WardName = new System.Windows.Forms.TextBox();
            this.lbl_Transfer_WardID = new System.Windows.Forms.Label();
            this.lbl_Transfer_WardName = new System.Windows.Forms.Label();
            this.lbl_Transfer_Floor = new System.Windows.Forms.Label();
            this.lbl_Transfer_RoomNo = new System.Windows.Forms.Label();
            this.lbl_Transfer_BedNo = new System.Windows.Forms.Label();
            this.grpBox2_Transfer_InPa = new System.Windows.Forms.GroupBox();
            this.cmb_Transfer_Search = new System.Windows.Forms.ComboBox();
            this.btn_Back_Transfer_InPa = new System.Windows.Forms.Button();
            this.clickToBookBed_Transfer = new System.Windows.Forms.DataGridViewImageColumn();
            this.txt_RoomNo_from_ManageInPaForm_To_Transfer = new System.Windows.Forms.TextBox();
            this.txt_BedNo_from_ManageInPaForm_To_Transfer = new System.Windows.Forms.TextBox();
            this.btn_Transfer_cancel = new System.Windows.Forms.Button();
            this.panel1_Transfer_InPa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Transfer_InPa)).BeginInit();
            this.groupBox1_Transfer_InPa.SuspendLayout();
            this.panel2_Transfer_InPa.SuspendLayout();
            this.panel3_Transfer_InPa.SuspendLayout();
            this.grpBox2_Transfer_InPa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Transfer_InPa
            // 
            this.lbl_Transfer_InPa.AutoSize = true;
            this.lbl_Transfer_InPa.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Transfer_InPa.ForeColor = System.Drawing.Color.White;
            this.lbl_Transfer_InPa.Location = new System.Drawing.Point(12, 16);
            this.lbl_Transfer_InPa.Name = "lbl_Transfer_InPa";
            this.lbl_Transfer_InPa.Size = new System.Drawing.Size(267, 37);
            this.lbl_Transfer_InPa.TabIndex = 18;
            this.lbl_Transfer_InPa.Text = "Transfer In Patient";
            // 
            // panel1_Transfer_InPa
            // 
            this.panel1_Transfer_InPa.BackColor = System.Drawing.Color.Azure;
            this.panel1_Transfer_InPa.Controls.Add(this.groupBox1);
            this.panel1_Transfer_InPa.Controls.Add(this.groupBox1_Transfer_InPa);
            this.panel1_Transfer_InPa.Controls.Add(this.grpBox2_Transfer_InPa);
            this.panel1_Transfer_InPa.Location = new System.Drawing.Point(12, 71);
            this.panel1_Transfer_InPa.Name = "panel1_Transfer_InPa";
            this.panel1_Transfer_InPa.Size = new System.Drawing.Size(969, 533);
            this.panel1_Transfer_InPa.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_BedNo_from_ManageInPaForm_To_Transfer);
            this.groupBox1.Controls.Add(this.txt_RoomNo_from_ManageInPaForm_To_Transfer);
            this.groupBox1.Controls.Add(this.dataGridView1_Transfer_InPa);
            this.groupBox1.Controls.Add(this.btn_Refresh_Transfer);
            this.groupBox1.Controls.Add(this.btn_Check_Transfer);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(359, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 504);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check Availability";
            // 
            // dataGridView1_Transfer_InPa
            // 
            this.dataGridView1_Transfer_InPa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1_Transfer_InPa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1_Transfer_InPa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Transfer_InPa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clickToBookBed_Transfer});
            this.dataGridView1_Transfer_InPa.Location = new System.Drawing.Point(101, 51);
            this.dataGridView1_Transfer_InPa.Name = "dataGridView1_Transfer_InPa";
            this.dataGridView1_Transfer_InPa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_Transfer_InPa.Size = new System.Drawing.Size(479, 384);
            this.dataGridView1_Transfer_InPa.TabIndex = 43;
            this.dataGridView1_Transfer_InPa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_Transfer_InPa_CellContentClick);
            this.dataGridView1_Transfer_InPa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_Transfer_InPa_CellFormatting);
            this.dataGridView1_Transfer_InPa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_Transfer_InPa_MouseClick);
            // 
            // btn_Refresh_Transfer
            // 
            this.btn_Refresh_Transfer.BackColor = System.Drawing.Color.Teal;
            this.btn_Refresh_Transfer.Image = global::FamilyCareHospital.Properties.Resources.REFRESH_refresh_32px;
            this.btn_Refresh_Transfer.Location = new System.Drawing.Point(496, 441);
            this.btn_Refresh_Transfer.Name = "btn_Refresh_Transfer";
            this.btn_Refresh_Transfer.Size = new System.Drawing.Size(84, 44);
            this.btn_Refresh_Transfer.TabIndex = 37;
            this.btn_Refresh_Transfer.UseVisualStyleBackColor = false;
            this.btn_Refresh_Transfer.Click += new System.EventHandler(this.btn_Refresh_Transfer_Click);
            // 
            // btn_Check_Transfer
            // 
            this.btn_Check_Transfer.BackColor = System.Drawing.Color.Teal;
            this.btn_Check_Transfer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Check_Transfer.FlatAppearance.BorderSize = 5;
            this.btn_Check_Transfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Check_Transfer.Image = global::FamilyCareHospital.Properties.Resources.AVAILABILITY_CHECK_arrow_32px;
            this.btn_Check_Transfer.Location = new System.Drawing.Point(11, 51);
            this.btn_Check_Transfer.Name = "btn_Check_Transfer";
            this.btn_Check_Transfer.Size = new System.Drawing.Size(84, 44);
            this.btn_Check_Transfer.TabIndex = 41;
            this.btn_Check_Transfer.UseVisualStyleBackColor = false;
            this.btn_Check_Transfer.Click += new System.EventHandler(this.btn_Check_Transfer_Click);
            // 
            // groupBox1_Transfer_InPa
            // 
            this.groupBox1_Transfer_InPa.Controls.Add(this.btn_Transfer_cancel);
            this.groupBox1_Transfer_InPa.Controls.Add(this.btnUpdate_Transfer);
            this.groupBox1_Transfer_InPa.Controls.Add(this.panel2_Transfer_InPa);
            this.groupBox1_Transfer_InPa.Controls.Add(this.panel3_Transfer_InPa);
            this.groupBox1_Transfer_InPa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1_Transfer_InPa.Location = new System.Drawing.Point(17, 97);
            this.groupBox1_Transfer_InPa.Name = "groupBox1_Transfer_InPa";
            this.groupBox1_Transfer_InPa.Size = new System.Drawing.Size(319, 425);
            this.groupBox1_Transfer_InPa.TabIndex = 47;
            this.groupBox1_Transfer_InPa.TabStop = false;
            this.groupBox1_Transfer_InPa.Text = "In-Patient Details";
            // 
            // btnUpdate_Transfer
            // 
            this.btnUpdate_Transfer.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate_Transfer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate_Transfer.FlatAppearance.BorderSize = 5;
            this.btnUpdate_Transfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate_Transfer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate_Transfer.Image = global::FamilyCareHospital.Properties.Resources.EDIT_edit_32px;
            this.btnUpdate_Transfer.Location = new System.Drawing.Point(155, 371);
            this.btnUpdate_Transfer.Name = "btnUpdate_Transfer";
            this.btnUpdate_Transfer.Size = new System.Drawing.Size(84, 44);
            this.btnUpdate_Transfer.TabIndex = 48;
            this.btnUpdate_Transfer.UseVisualStyleBackColor = false;
            this.btnUpdate_Transfer.Click += new System.EventHandler(this.btnUpdate_Transfer_Click);
            // 
            // panel2_Transfer_InPa
            // 
            this.panel2_Transfer_InPa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2_Transfer_InPa.Controls.Add(this.txt_Transfer_InPa_LName);
            this.panel2_Transfer_InPa.Controls.Add(this.lbl_Transfer_InPa_LName);
            this.panel2_Transfer_InPa.Controls.Add(this.txt_Transfer_InPa_ID);
            this.panel2_Transfer_InPa.Controls.Add(this.txt_Transfer_InPa_FName);
            this.panel2_Transfer_InPa.Controls.Add(this.lbl_Transfer_InPa_ID);
            this.panel2_Transfer_InPa.Controls.Add(this.lbl_Transfer_InPa_FName);
            this.panel2_Transfer_InPa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2_Transfer_InPa.Location = new System.Drawing.Point(6, 25);
            this.panel2_Transfer_InPa.Name = "panel2_Transfer_InPa";
            this.panel2_Transfer_InPa.Size = new System.Drawing.Size(294, 119);
            this.panel2_Transfer_InPa.TabIndex = 39;
            // 
            // txt_Transfer_InPa_LName
            // 
            this.txt_Transfer_InPa_LName.Enabled = false;
            this.txt_Transfer_InPa_LName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Transfer_InPa_LName.Location = new System.Drawing.Point(114, 81);
            this.txt_Transfer_InPa_LName.Name = "txt_Transfer_InPa_LName";
            this.txt_Transfer_InPa_LName.Size = new System.Drawing.Size(169, 25);
            this.txt_Transfer_InPa_LName.TabIndex = 28;
            // 
            // lbl_Transfer_InPa_LName
            // 
            this.lbl_Transfer_InPa_LName.AutoSize = true;
            this.lbl_Transfer_InPa_LName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Transfer_InPa_LName.Location = new System.Drawing.Point(6, 86);
            this.lbl_Transfer_InPa_LName.Name = "lbl_Transfer_InPa_LName";
            this.lbl_Transfer_InPa_LName.Size = new System.Drawing.Size(70, 17);
            this.lbl_Transfer_InPa_LName.TabIndex = 27;
            this.lbl_Transfer_InPa_LName.Text = "Last Name";
            // 
            // txt_Transfer_InPa_ID
            // 
            this.txt_Transfer_InPa_ID.Enabled = false;
            this.txt_Transfer_InPa_ID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Transfer_InPa_ID.Location = new System.Drawing.Point(114, 9);
            this.txt_Transfer_InPa_ID.Name = "txt_Transfer_InPa_ID";
            this.txt_Transfer_InPa_ID.Size = new System.Drawing.Size(169, 25);
            this.txt_Transfer_InPa_ID.TabIndex = 26;
            // 
            // txt_Transfer_InPa_FName
            // 
            this.txt_Transfer_InPa_FName.Enabled = false;
            this.txt_Transfer_InPa_FName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Transfer_InPa_FName.Location = new System.Drawing.Point(114, 44);
            this.txt_Transfer_InPa_FName.Name = "txt_Transfer_InPa_FName";
            this.txt_Transfer_InPa_FName.Size = new System.Drawing.Size(169, 25);
            this.txt_Transfer_InPa_FName.TabIndex = 25;
            // 
            // lbl_Transfer_InPa_ID
            // 
            this.lbl_Transfer_InPa_ID.AutoSize = true;
            this.lbl_Transfer_InPa_ID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Transfer_InPa_ID.Location = new System.Drawing.Point(6, 14);
            this.lbl_Transfer_InPa_ID.Name = "lbl_Transfer_InPa_ID";
            this.lbl_Transfer_InPa_ID.Size = new System.Drawing.Size(63, 17);
            this.lbl_Transfer_InPa_ID.TabIndex = 23;
            this.lbl_Transfer_InPa_ID.Text = "Patient ID";
            // 
            // lbl_Transfer_InPa_FName
            // 
            this.lbl_Transfer_InPa_FName.AutoSize = true;
            this.lbl_Transfer_InPa_FName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Transfer_InPa_FName.Location = new System.Drawing.Point(6, 49);
            this.lbl_Transfer_InPa_FName.Name = "lbl_Transfer_InPa_FName";
            this.lbl_Transfer_InPa_FName.Size = new System.Drawing.Size(71, 17);
            this.lbl_Transfer_InPa_FName.TabIndex = 22;
            this.lbl_Transfer_InPa_FName.Text = "First Name";
            // 
            // panel3_Transfer_InPa
            // 
            this.panel3_Transfer_InPa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3_Transfer_InPa.Controls.Add(this.txt_Transfer_Floor);
            this.panel3_Transfer_InPa.Controls.Add(this.txt_Transfer_Status);
            this.panel3_Transfer_InPa.Controls.Add(this.label1);
            this.panel3_Transfer_InPa.Controls.Add(this.txt_Transfer_BedNo);
            this.panel3_Transfer_InPa.Controls.Add(this.txt_Transfer_RoomNo);
            this.panel3_Transfer_InPa.Controls.Add(this.txt_Transfer_WardID);
            this.panel3_Transfer_InPa.Controls.Add(this.txt_Transfer_WardName);
            this.panel3_Transfer_InPa.Controls.Add(this.lbl_Transfer_WardID);
            this.panel3_Transfer_InPa.Controls.Add(this.lbl_Transfer_WardName);
            this.panel3_Transfer_InPa.Controls.Add(this.lbl_Transfer_Floor);
            this.panel3_Transfer_InPa.Controls.Add(this.lbl_Transfer_RoomNo);
            this.panel3_Transfer_InPa.Controls.Add(this.lbl_Transfer_BedNo);
            this.panel3_Transfer_InPa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3_Transfer_InPa.Location = new System.Drawing.Point(6, 150);
            this.panel3_Transfer_InPa.Name = "panel3_Transfer_InPa";
            this.panel3_Transfer_InPa.Size = new System.Drawing.Size(294, 215);
            this.panel3_Transfer_InPa.TabIndex = 38;
            // 
            // txt_Transfer_Floor
            // 
            this.txt_Transfer_Floor.Enabled = false;
            this.txt_Transfer_Floor.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txt_Transfer_Floor.Location = new System.Drawing.Point(114, 77);
            this.txt_Transfer_Floor.Name = "txt_Transfer_Floor";
            this.txt_Transfer_Floor.Size = new System.Drawing.Size(169, 27);
            this.txt_Transfer_Floor.TabIndex = 31;
            // 
            // txt_Transfer_Status
            // 
            this.txt_Transfer_Status.Enabled = false;
            this.txt_Transfer_Status.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txt_Transfer_Status.Location = new System.Drawing.Point(114, 177);
            this.txt_Transfer_Status.Name = "txt_Transfer_Status";
            this.txt_Transfer_Status.Size = new System.Drawing.Size(169, 27);
            this.txt_Transfer_Status.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Status";
            // 
            // txt_Transfer_BedNo
            // 
            this.txt_Transfer_BedNo.Enabled = false;
            this.txt_Transfer_BedNo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txt_Transfer_BedNo.Location = new System.Drawing.Point(114, 142);
            this.txt_Transfer_BedNo.Name = "txt_Transfer_BedNo";
            this.txt_Transfer_BedNo.Size = new System.Drawing.Size(169, 27);
            this.txt_Transfer_BedNo.TabIndex = 28;
            // 
            // txt_Transfer_RoomNo
            // 
            this.txt_Transfer_RoomNo.Enabled = false;
            this.txt_Transfer_RoomNo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txt_Transfer_RoomNo.Location = new System.Drawing.Point(114, 109);
            this.txt_Transfer_RoomNo.Name = "txt_Transfer_RoomNo";
            this.txt_Transfer_RoomNo.Size = new System.Drawing.Size(169, 27);
            this.txt_Transfer_RoomNo.TabIndex = 27;
            // 
            // txt_Transfer_WardID
            // 
            this.txt_Transfer_WardID.Enabled = false;
            this.txt_Transfer_WardID.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txt_Transfer_WardID.Location = new System.Drawing.Point(114, 9);
            this.txt_Transfer_WardID.Name = "txt_Transfer_WardID";
            this.txt_Transfer_WardID.Size = new System.Drawing.Size(169, 27);
            this.txt_Transfer_WardID.TabIndex = 26;
            // 
            // txt_Transfer_WardName
            // 
            this.txt_Transfer_WardName.Enabled = false;
            this.txt_Transfer_WardName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txt_Transfer_WardName.Location = new System.Drawing.Point(114, 44);
            this.txt_Transfer_WardName.Name = "txt_Transfer_WardName";
            this.txt_Transfer_WardName.Size = new System.Drawing.Size(169, 27);
            this.txt_Transfer_WardName.TabIndex = 25;
            // 
            // lbl_Transfer_WardID
            // 
            this.lbl_Transfer_WardID.AutoSize = true;
            this.lbl_Transfer_WardID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Transfer_WardID.Location = new System.Drawing.Point(6, 17);
            this.lbl_Transfer_WardID.Name = "lbl_Transfer_WardID";
            this.lbl_Transfer_WardID.Size = new System.Drawing.Size(63, 20);
            this.lbl_Transfer_WardID.TabIndex = 23;
            this.lbl_Transfer_WardID.Text = "Ward ID";
            // 
            // lbl_Transfer_WardName
            // 
            this.lbl_Transfer_WardName.AutoSize = true;
            this.lbl_Transfer_WardName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Transfer_WardName.Location = new System.Drawing.Point(6, 52);
            this.lbl_Transfer_WardName.Name = "lbl_Transfer_WardName";
            this.lbl_Transfer_WardName.Size = new System.Drawing.Size(88, 20);
            this.lbl_Transfer_WardName.TabIndex = 22;
            this.lbl_Transfer_WardName.Text = "Ward Name";
            // 
            // lbl_Transfer_Floor
            // 
            this.lbl_Transfer_Floor.AutoSize = true;
            this.lbl_Transfer_Floor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Transfer_Floor.Location = new System.Drawing.Point(6, 85);
            this.lbl_Transfer_Floor.Name = "lbl_Transfer_Floor";
            this.lbl_Transfer_Floor.Size = new System.Drawing.Size(43, 20);
            this.lbl_Transfer_Floor.TabIndex = 21;
            this.lbl_Transfer_Floor.Text = "Floor";
            // 
            // lbl_Transfer_RoomNo
            // 
            this.lbl_Transfer_RoomNo.AutoSize = true;
            this.lbl_Transfer_RoomNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Transfer_RoomNo.Location = new System.Drawing.Point(6, 117);
            this.lbl_Transfer_RoomNo.Name = "lbl_Transfer_RoomNo";
            this.lbl_Transfer_RoomNo.Size = new System.Drawing.Size(73, 20);
            this.lbl_Transfer_RoomNo.TabIndex = 20;
            this.lbl_Transfer_RoomNo.Text = "Room No";
            // 
            // lbl_Transfer_BedNo
            // 
            this.lbl_Transfer_BedNo.AutoSize = true;
            this.lbl_Transfer_BedNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Transfer_BedNo.Location = new System.Drawing.Point(6, 149);
            this.lbl_Transfer_BedNo.Name = "lbl_Transfer_BedNo";
            this.lbl_Transfer_BedNo.Size = new System.Drawing.Size(59, 20);
            this.lbl_Transfer_BedNo.TabIndex = 19;
            this.lbl_Transfer_BedNo.Text = "Bed No";
            // 
            // grpBox2_Transfer_InPa
            // 
            this.grpBox2_Transfer_InPa.Controls.Add(this.cmb_Transfer_Search);
            this.grpBox2_Transfer_InPa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox2_Transfer_InPa.Location = new System.Drawing.Point(17, 11);
            this.grpBox2_Transfer_InPa.Name = "grpBox2_Transfer_InPa";
            this.grpBox2_Transfer_InPa.Size = new System.Drawing.Size(319, 79);
            this.grpBox2_Transfer_InPa.TabIndex = 46;
            this.grpBox2_Transfer_InPa.TabStop = false;
            this.grpBox2_Transfer_InPa.Text = "Transfer Ward";
            // 
            // cmb_Transfer_Search
            // 
            this.cmb_Transfer_Search.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmb_Transfer_Search.FormattingEnabled = true;
            this.cmb_Transfer_Search.Location = new System.Drawing.Point(20, 30);
            this.cmb_Transfer_Search.Name = "cmb_Transfer_Search";
            this.cmb_Transfer_Search.Size = new System.Drawing.Size(280, 28);
            this.cmb_Transfer_Search.TabIndex = 16;
            this.cmb_Transfer_Search.SelectedIndexChanged += new System.EventHandler(this.cmb_Transfer_Search_SelectedIndexChanged);
            this.cmb_Transfer_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Transfer_Search_KeyPress);
            // 
            // btn_Back_Transfer_InPa
            // 
            this.btn_Back_Transfer_InPa.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Back_Transfer_InPa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Back_Transfer_InPa.FlatAppearance.BorderSize = 5;
            this.btn_Back_Transfer_InPa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Back_Transfer_InPa.Image = global::FamilyCareHospital.Properties.Resources.BACK_undo_32px;
            this.btn_Back_Transfer_InPa.Location = new System.Drawing.Point(907, 12);
            this.btn_Back_Transfer_InPa.Name = "btn_Back_Transfer_InPa";
            this.btn_Back_Transfer_InPa.Size = new System.Drawing.Size(74, 41);
            this.btn_Back_Transfer_InPa.TabIndex = 20;
            this.btn_Back_Transfer_InPa.UseVisualStyleBackColor = false;
            this.btn_Back_Transfer_InPa.Click += new System.EventHandler(this.btn_Back_Transfer_InPa_Click);
            // 
            // clickToBookBed_Transfer
            // 
            this.clickToBookBed_Transfer.HeaderText = "Book";
            this.clickToBookBed_Transfer.Name = "clickToBookBed_Transfer";
            this.clickToBookBed_Transfer.Width = 43;
            // 
            // txt_RoomNo_from_ManageInPaForm_To_Transfer
            // 
            this.txt_RoomNo_from_ManageInPaForm_To_Transfer.Location = new System.Drawing.Point(39, 457);
            this.txt_RoomNo_from_ManageInPaForm_To_Transfer.Name = "txt_RoomNo_from_ManageInPaForm_To_Transfer";
            this.txt_RoomNo_from_ManageInPaForm_To_Transfer.Size = new System.Drawing.Size(138, 25);
            this.txt_RoomNo_from_ManageInPaForm_To_Transfer.TabIndex = 44;
            this.txt_RoomNo_from_ManageInPaForm_To_Transfer.Visible = false;
            // 
            // txt_BedNo_from_ManageInPaForm_To_Transfer
            // 
            this.txt_BedNo_from_ManageInPaForm_To_Transfer.Location = new System.Drawing.Point(207, 457);
            this.txt_BedNo_from_ManageInPaForm_To_Transfer.Name = "txt_BedNo_from_ManageInPaForm_To_Transfer";
            this.txt_BedNo_from_ManageInPaForm_To_Transfer.Size = new System.Drawing.Size(138, 25);
            this.txt_BedNo_from_ManageInPaForm_To_Transfer.TabIndex = 45;
            this.txt_BedNo_from_ManageInPaForm_To_Transfer.Visible = false;
            // 
            // btn_Transfer_cancel
            // 
            this.btn_Transfer_cancel.BackColor = System.Drawing.Color.Teal;
            this.btn_Transfer_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Transfer_cancel.FlatAppearance.BorderSize = 5;
            this.btn_Transfer_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Transfer_cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Transfer_cancel.Location = new System.Drawing.Point(65, 371);
            this.btn_Transfer_cancel.Name = "btn_Transfer_cancel";
            this.btn_Transfer_cancel.Size = new System.Drawing.Size(84, 44);
            this.btn_Transfer_cancel.TabIndex = 49;
            this.btn_Transfer_cancel.Text = "CANCEL";
            this.btn_Transfer_cancel.UseVisualStyleBackColor = false;
            this.btn_Transfer_cancel.Click += new System.EventHandler(this.btn_Transfer_cancel_Click);
            // 
            // In_Patient_Transfer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(993, 616);
            this.Controls.Add(this.btn_Back_Transfer_InPa);
            this.Controls.Add(this.panel1_Transfer_InPa);
            this.Controls.Add(this.lbl_Transfer_InPa);
            this.Name = "In_Patient_Transfer_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In- Patient Transfer";
            this.panel1_Transfer_InPa.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Transfer_InPa)).EndInit();
            this.groupBox1_Transfer_InPa.ResumeLayout(false);
            this.panel2_Transfer_InPa.ResumeLayout(false);
            this.panel2_Transfer_InPa.PerformLayout();
            this.panel3_Transfer_InPa.ResumeLayout(false);
            this.panel3_Transfer_InPa.PerformLayout();
            this.grpBox2_Transfer_InPa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Transfer_InPa;
        private System.Windows.Forms.Panel panel1_Transfer_InPa;
        private System.Windows.Forms.DataGridView dataGridView1_Transfer_InPa;
        private System.Windows.Forms.Button btn_Refresh_Transfer;
        private System.Windows.Forms.Button btn_Check_Transfer;
        private System.Windows.Forms.GroupBox grpBox2_Transfer_InPa;
        private System.Windows.Forms.ComboBox cmb_Transfer_Search;
        private System.Windows.Forms.GroupBox groupBox1_Transfer_InPa;
        private System.Windows.Forms.Panel panel3_Transfer_InPa;
        private System.Windows.Forms.TextBox txt_Transfer_BedNo;
        private System.Windows.Forms.TextBox txt_Transfer_RoomNo;
        private System.Windows.Forms.TextBox txt_Transfer_WardID;
        private System.Windows.Forms.TextBox txt_Transfer_WardName;
        private System.Windows.Forms.Label lbl_Transfer_WardID;
        private System.Windows.Forms.Label lbl_Transfer_WardName;
        private System.Windows.Forms.Label lbl_Transfer_Floor;
        private System.Windows.Forms.Label lbl_Transfer_RoomNo;
        private System.Windows.Forms.Label lbl_Transfer_BedNo;
        private System.Windows.Forms.Panel panel2_Transfer_InPa;
        private System.Windows.Forms.TextBox txt_Transfer_InPa_ID;
        private System.Windows.Forms.TextBox txt_Transfer_InPa_FName;
        private System.Windows.Forms.Label lbl_Transfer_InPa_ID;
        private System.Windows.Forms.Label lbl_Transfer_InPa_FName;
        private System.Windows.Forms.Button btn_Back_Transfer_InPa;
        private System.Windows.Forms.TextBox txt_Transfer_InPa_LName;
        private System.Windows.Forms.Label lbl_Transfer_InPa_LName;
        private System.Windows.Forms.Button btnUpdate_Transfer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Transfer_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Transfer_Floor;
        private System.Windows.Forms.DataGridViewImageColumn clickToBookBed_Transfer;
        private System.Windows.Forms.TextBox txt_BedNo_from_ManageInPaForm_To_Transfer;
        private System.Windows.Forms.TextBox txt_RoomNo_from_ManageInPaForm_To_Transfer;
        private System.Windows.Forms.Button btn_Transfer_cancel;
    }
}