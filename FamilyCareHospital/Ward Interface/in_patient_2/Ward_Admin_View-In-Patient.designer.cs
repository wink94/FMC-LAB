namespace FamilyCareHospital
{
    partial class Ward_Admin_View_In_Patient
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1_ViewInPa = new System.Windows.Forms.Panel();
            this.btn_LoadChart = new System.Windows.Forms.Button();
            this.btnRefresh_ViewPa = new System.Windows.Forms.Button();
            this.dataGridView1_viewPatient = new System.Windows.Forms.DataGridView();
            this.groupBox3_View_InPa = new System.Windows.Forms.GroupBox();
            this.txt_Search_ViewInPa = new System.Windows.Forms.TextBox();
            this.cmb_Search_ViewInPa = new System.Windows.Forms.ComboBox();
            this.btn_Search_ViewInPa = new System.Windows.Forms.Button();
            this.groupBox2_View_InPa = new System.Windows.Forms.GroupBox();
            this.txt_BedNo_ViewInPa = new System.Windows.Forms.TextBox();
            this.lbl_BedNo_ViewInPa = new System.Windows.Forms.Label();
            this.txt_RoomNo_ViewInPa = new System.Windows.Forms.TextBox();
            this.lbl_RoomNo_ViewInPa = new System.Windows.Forms.Label();
            this.txt_WardName_ViewInPa = new System.Windows.Forms.TextBox();
            this.lbl_WardName_ViewInPa = new System.Windows.Forms.Label();
            this.txt_gender_ViewInPa = new System.Windows.Forms.TextBox();
            this.pictureBox1__View_InPa = new System.Windows.Forms.PictureBox();
            this.lbl_gender_ViewInPa = new System.Windows.Forms.Label();
            this.txt_Lname_ViewInPa = new System.Windows.Forms.TextBox();
            this.lbl_PaID_ViewInPa = new System.Windows.Forms.Label();
            this.txt_Fname_ViewInPa = new System.Windows.Forms.TextBox();
            this.lbl_Fname_ViewInPa = new System.Windows.Forms.Label();
            this.lbl_Lname_ViewInPa = new System.Windows.Forms.Label();
            this.txt_PaID_ViewInPa = new System.Windows.Forms.TextBox();
            this.lbl_ViewInPa = new System.Windows.Forms.Label();
            this.btn_Back_ViewInPa = new System.Windows.Forms.Button();
            this.chart1_view = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1_ViewInPa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_viewPatient)).BeginInit();
            this.groupBox3_View_InPa.SuspendLayout();
            this.groupBox2_View_InPa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1__View_InPa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1_view)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_ViewInPa
            // 
            this.panel1_ViewInPa.BackColor = System.Drawing.Color.Azure;
            this.panel1_ViewInPa.Controls.Add(this.chart1_view);
            this.panel1_ViewInPa.Controls.Add(this.btn_LoadChart);
            this.panel1_ViewInPa.Controls.Add(this.btnRefresh_ViewPa);
            this.panel1_ViewInPa.Controls.Add(this.dataGridView1_viewPatient);
            this.panel1_ViewInPa.Controls.Add(this.groupBox3_View_InPa);
            this.panel1_ViewInPa.Controls.Add(this.groupBox2_View_InPa);
            this.panel1_ViewInPa.Location = new System.Drawing.Point(12, 63);
            this.panel1_ViewInPa.Name = "panel1_ViewInPa";
            this.panel1_ViewInPa.Size = new System.Drawing.Size(969, 541);
            this.panel1_ViewInPa.TabIndex = 21;
            // 
            // btn_LoadChart
            // 
            this.btn_LoadChart.BackColor = System.Drawing.Color.Teal;
            this.btn_LoadChart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_LoadChart.Location = new System.Drawing.Point(822, 481);
            this.btn_LoadChart.Name = "btn_LoadChart";
            this.btn_LoadChart.Size = new System.Drawing.Size(84, 44);
            this.btn_LoadChart.TabIndex = 61;
            this.btn_LoadChart.Text = "LOAD";
            this.btn_LoadChart.UseVisualStyleBackColor = false;
            this.btn_LoadChart.Click += new System.EventHandler(this.btn_LoadChart_Click);
            // 
            // btnRefresh_ViewPa
            // 
            this.btnRefresh_ViewPa.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh_ViewPa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh_ViewPa.Image = global::FamilyCareHospital.Properties.Resources.REFRESH_refresh_32px;
            this.btnRefresh_ViewPa.Location = new System.Drawing.Point(839, 244);
            this.btnRefresh_ViewPa.Name = "btnRefresh_ViewPa";
            this.btnRefresh_ViewPa.Size = new System.Drawing.Size(84, 44);
            this.btnRefresh_ViewPa.TabIndex = 59;
            this.btnRefresh_ViewPa.UseVisualStyleBackColor = false;
            this.btnRefresh_ViewPa.Click += new System.EventHandler(this.btnRefresh_ViewPa_Click);
            // 
            // dataGridView1_viewPatient
            // 
            this.dataGridView1_viewPatient.AllowUserToAddRows = false;
            this.dataGridView1_viewPatient.AllowUserToDeleteRows = false;
            this.dataGridView1_viewPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1_viewPatient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1_viewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_viewPatient.Location = new System.Drawing.Point(275, 102);
            this.dataGridView1_viewPatient.Name = "dataGridView1_viewPatient";
            this.dataGridView1_viewPatient.ReadOnly = true;
            this.dataGridView1_viewPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_viewPatient.Size = new System.Drawing.Size(648, 136);
            this.dataGridView1_viewPatient.TabIndex = 58;
            this.dataGridView1_viewPatient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_viewPatient_MouseClick);
            // 
            // groupBox3_View_InPa
            // 
            this.groupBox3_View_InPa.Controls.Add(this.txt_Search_ViewInPa);
            this.groupBox3_View_InPa.Controls.Add(this.cmb_Search_ViewInPa);
            this.groupBox3_View_InPa.Controls.Add(this.btn_Search_ViewInPa);
            this.groupBox3_View_InPa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3_View_InPa.Location = new System.Drawing.Point(275, 19);
            this.groupBox3_View_InPa.Name = "groupBox3_View_InPa";
            this.groupBox3_View_InPa.Size = new System.Drawing.Size(648, 72);
            this.groupBox3_View_InPa.TabIndex = 56;
            this.groupBox3_View_InPa.TabStop = false;
            this.groupBox3_View_InPa.Text = "Search By";
            // 
            // txt_Search_ViewInPa
            // 
            this.txt_Search_ViewInPa.Location = new System.Drawing.Point(219, 29);
            this.txt_Search_ViewInPa.Name = "txt_Search_ViewInPa";
            this.txt_Search_ViewInPa.Size = new System.Drawing.Size(272, 23);
            this.txt_Search_ViewInPa.TabIndex = 13;
            // 
            // cmb_Search_ViewInPa
            // 
            this.cmb_Search_ViewInPa.FormattingEnabled = true;
            this.cmb_Search_ViewInPa.Items.AddRange(new object[] {
            "Patient ID",
            "First Name",
            "Last Name",
            "Ward Name",
            "Room No",
            "Bed No"});
            this.cmb_Search_ViewInPa.Location = new System.Drawing.Point(6, 29);
            this.cmb_Search_ViewInPa.Name = "cmb_Search_ViewInPa";
            this.cmb_Search_ViewInPa.Size = new System.Drawing.Size(199, 23);
            this.cmb_Search_ViewInPa.TabIndex = 16;
            this.cmb_Search_ViewInPa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Search_ViewInPa_KeyPress);
            // 
            // btn_Search_ViewInPa
            // 
            this.btn_Search_ViewInPa.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_Search_ViewInPa.Image = global::FamilyCareHospital.Properties.Resources.SEARCH_search_32px;
            this.btn_Search_ViewInPa.Location = new System.Drawing.Point(506, 17);
            this.btn_Search_ViewInPa.Name = "btn_Search_ViewInPa";
            this.btn_Search_ViewInPa.Size = new System.Drawing.Size(84, 44);
            this.btn_Search_ViewInPa.TabIndex = 14;
            this.btn_Search_ViewInPa.UseVisualStyleBackColor = false;
            this.btn_Search_ViewInPa.Click += new System.EventHandler(this.btn_Search_ViewInPa_Click);
            // 
            // groupBox2_View_InPa
            // 
            this.groupBox2_View_InPa.Controls.Add(this.txt_BedNo_ViewInPa);
            this.groupBox2_View_InPa.Controls.Add(this.lbl_BedNo_ViewInPa);
            this.groupBox2_View_InPa.Controls.Add(this.txt_RoomNo_ViewInPa);
            this.groupBox2_View_InPa.Controls.Add(this.lbl_RoomNo_ViewInPa);
            this.groupBox2_View_InPa.Controls.Add(this.txt_WardName_ViewInPa);
            this.groupBox2_View_InPa.Controls.Add(this.lbl_WardName_ViewInPa);
            this.groupBox2_View_InPa.Controls.Add(this.txt_gender_ViewInPa);
            this.groupBox2_View_InPa.Controls.Add(this.pictureBox1__View_InPa);
            this.groupBox2_View_InPa.Controls.Add(this.lbl_gender_ViewInPa);
            this.groupBox2_View_InPa.Controls.Add(this.txt_Lname_ViewInPa);
            this.groupBox2_View_InPa.Controls.Add(this.lbl_PaID_ViewInPa);
            this.groupBox2_View_InPa.Controls.Add(this.txt_Fname_ViewInPa);
            this.groupBox2_View_InPa.Controls.Add(this.lbl_Fname_ViewInPa);
            this.groupBox2_View_InPa.Controls.Add(this.lbl_Lname_ViewInPa);
            this.groupBox2_View_InPa.Controls.Add(this.txt_PaID_ViewInPa);
            this.groupBox2_View_InPa.Location = new System.Drawing.Point(11, 6);
            this.groupBox2_View_InPa.Name = "groupBox2_View_InPa";
            this.groupBox2_View_InPa.Size = new System.Drawing.Size(238, 461);
            this.groupBox2_View_InPa.TabIndex = 55;
            this.groupBox2_View_InPa.TabStop = false;
            // 
            // txt_BedNo_ViewInPa
            // 
            this.txt_BedNo_ViewInPa.BackColor = System.Drawing.Color.OldLace;
            this.txt_BedNo_ViewInPa.Enabled = false;
            this.txt_BedNo_ViewInPa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BedNo_ViewInPa.Location = new System.Drawing.Point(80, 411);
            this.txt_BedNo_ViewInPa.Name = "txt_BedNo_ViewInPa";
            this.txt_BedNo_ViewInPa.Size = new System.Drawing.Size(149, 22);
            this.txt_BedNo_ViewInPa.TabIndex = 59;
            // 
            // lbl_BedNo_ViewInPa
            // 
            this.lbl_BedNo_ViewInPa.AutoSize = true;
            this.lbl_BedNo_ViewInPa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BedNo_ViewInPa.Location = new System.Drawing.Point(7, 420);
            this.lbl_BedNo_ViewInPa.Name = "lbl_BedNo_ViewInPa";
            this.lbl_BedNo_ViewInPa.Size = new System.Drawing.Size(45, 13);
            this.lbl_BedNo_ViewInPa.TabIndex = 58;
            this.lbl_BedNo_ViewInPa.Text = "Bed No";
            // 
            // txt_RoomNo_ViewInPa
            // 
            this.txt_RoomNo_ViewInPa.BackColor = System.Drawing.Color.OldLace;
            this.txt_RoomNo_ViewInPa.Enabled = false;
            this.txt_RoomNo_ViewInPa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RoomNo_ViewInPa.Location = new System.Drawing.Point(80, 383);
            this.txt_RoomNo_ViewInPa.Name = "txt_RoomNo_ViewInPa";
            this.txt_RoomNo_ViewInPa.Size = new System.Drawing.Size(149, 22);
            this.txt_RoomNo_ViewInPa.TabIndex = 57;
            // 
            // lbl_RoomNo_ViewInPa
            // 
            this.lbl_RoomNo_ViewInPa.AutoSize = true;
            this.lbl_RoomNo_ViewInPa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoomNo_ViewInPa.Location = new System.Drawing.Point(7, 392);
            this.lbl_RoomNo_ViewInPa.Name = "lbl_RoomNo_ViewInPa";
            this.lbl_RoomNo_ViewInPa.Size = new System.Drawing.Size(55, 13);
            this.lbl_RoomNo_ViewInPa.TabIndex = 56;
            this.lbl_RoomNo_ViewInPa.Text = "Room No";
            // 
            // txt_WardName_ViewInPa
            // 
            this.txt_WardName_ViewInPa.BackColor = System.Drawing.Color.OldLace;
            this.txt_WardName_ViewInPa.Enabled = false;
            this.txt_WardName_ViewInPa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_WardName_ViewInPa.Location = new System.Drawing.Point(80, 355);
            this.txt_WardName_ViewInPa.Name = "txt_WardName_ViewInPa";
            this.txt_WardName_ViewInPa.Size = new System.Drawing.Size(149, 22);
            this.txt_WardName_ViewInPa.TabIndex = 55;
            // 
            // lbl_WardName_ViewInPa
            // 
            this.lbl_WardName_ViewInPa.AutoSize = true;
            this.lbl_WardName_ViewInPa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WardName_ViewInPa.Location = new System.Drawing.Point(7, 364);
            this.lbl_WardName_ViewInPa.Name = "lbl_WardName_ViewInPa";
            this.lbl_WardName_ViewInPa.Size = new System.Drawing.Size(67, 13);
            this.lbl_WardName_ViewInPa.TabIndex = 54;
            this.lbl_WardName_ViewInPa.Text = "Ward Name";
            // 
            // txt_gender_ViewInPa
            // 
            this.txt_gender_ViewInPa.BackColor = System.Drawing.Color.OldLace;
            this.txt_gender_ViewInPa.Enabled = false;
            this.txt_gender_ViewInPa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gender_ViewInPa.Location = new System.Drawing.Point(80, 327);
            this.txt_gender_ViewInPa.Name = "txt_gender_ViewInPa";
            this.txt_gender_ViewInPa.Size = new System.Drawing.Size(149, 22);
            this.txt_gender_ViewInPa.TabIndex = 53;
            // 
            // pictureBox1__View_InPa
            // 
            this.pictureBox1__View_InPa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1__View_InPa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1__View_InPa.Image = global::FamilyCareHospital.Properties.Resources.PaDEATAILS_homem_mulher_1246140257;
            this.pictureBox1__View_InPa.Location = new System.Drawing.Point(7, 21);
            this.pictureBox1__View_InPa.Name = "pictureBox1__View_InPa";
            this.pictureBox1__View_InPa.Size = new System.Drawing.Size(219, 209);
            this.pictureBox1__View_InPa.TabIndex = 44;
            this.pictureBox1__View_InPa.TabStop = false;
            // 
            // lbl_gender_ViewInPa
            // 
            this.lbl_gender_ViewInPa.AutoSize = true;
            this.lbl_gender_ViewInPa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender_ViewInPa.Location = new System.Drawing.Point(7, 336);
            this.lbl_gender_ViewInPa.Name = "lbl_gender_ViewInPa";
            this.lbl_gender_ViewInPa.Size = new System.Drawing.Size(45, 13);
            this.lbl_gender_ViewInPa.TabIndex = 46;
            this.lbl_gender_ViewInPa.Text = "Gender";
            // 
            // txt_Lname_ViewInPa
            // 
            this.txt_Lname_ViewInPa.BackColor = System.Drawing.Color.OldLace;
            this.txt_Lname_ViewInPa.Enabled = false;
            this.txt_Lname_ViewInPa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lname_ViewInPa.Location = new System.Drawing.Point(80, 299);
            this.txt_Lname_ViewInPa.Name = "txt_Lname_ViewInPa";
            this.txt_Lname_ViewInPa.Size = new System.Drawing.Size(149, 22);
            this.txt_Lname_ViewInPa.TabIndex = 52;
            // 
            // lbl_PaID_ViewInPa
            // 
            this.lbl_PaID_ViewInPa.AutoSize = true;
            this.lbl_PaID_ViewInPa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PaID_ViewInPa.Location = new System.Drawing.Point(7, 252);
            this.lbl_PaID_ViewInPa.Name = "lbl_PaID_ViewInPa";
            this.lbl_PaID_ViewInPa.Size = new System.Drawing.Size(57, 13);
            this.lbl_PaID_ViewInPa.TabIndex = 49;
            this.lbl_PaID_ViewInPa.Text = "Patient ID";
            // 
            // txt_Fname_ViewInPa
            // 
            this.txt_Fname_ViewInPa.BackColor = System.Drawing.Color.OldLace;
            this.txt_Fname_ViewInPa.Enabled = false;
            this.txt_Fname_ViewInPa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fname_ViewInPa.Location = new System.Drawing.Point(80, 271);
            this.txt_Fname_ViewInPa.Name = "txt_Fname_ViewInPa";
            this.txt_Fname_ViewInPa.Size = new System.Drawing.Size(149, 22);
            this.txt_Fname_ViewInPa.TabIndex = 51;
            // 
            // lbl_Fname_ViewInPa
            // 
            this.lbl_Fname_ViewInPa.AutoSize = true;
            this.lbl_Fname_ViewInPa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fname_ViewInPa.Location = new System.Drawing.Point(7, 280);
            this.lbl_Fname_ViewInPa.Name = "lbl_Fname_ViewInPa";
            this.lbl_Fname_ViewInPa.Size = new System.Drawing.Size(61, 13);
            this.lbl_Fname_ViewInPa.TabIndex = 48;
            this.lbl_Fname_ViewInPa.Text = "First Name";
            // 
            // lbl_Lname_ViewInPa
            // 
            this.lbl_Lname_ViewInPa.AutoSize = true;
            this.lbl_Lname_ViewInPa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lname_ViewInPa.Location = new System.Drawing.Point(7, 308);
            this.lbl_Lname_ViewInPa.Name = "lbl_Lname_ViewInPa";
            this.lbl_Lname_ViewInPa.Size = new System.Drawing.Size(59, 13);
            this.lbl_Lname_ViewInPa.TabIndex = 47;
            this.lbl_Lname_ViewInPa.Text = "Last Name";
            // 
            // txt_PaID_ViewInPa
            // 
            this.txt_PaID_ViewInPa.BackColor = System.Drawing.Color.OldLace;
            this.txt_PaID_ViewInPa.Enabled = false;
            this.txt_PaID_ViewInPa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PaID_ViewInPa.Location = new System.Drawing.Point(80, 243);
            this.txt_PaID_ViewInPa.Name = "txt_PaID_ViewInPa";
            this.txt_PaID_ViewInPa.Size = new System.Drawing.Size(149, 22);
            this.txt_PaID_ViewInPa.TabIndex = 50;
            // 
            // lbl_ViewInPa
            // 
            this.lbl_ViewInPa.AutoSize = true;
            this.lbl_ViewInPa.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ViewInPa.ForeColor = System.Drawing.Color.White;
            this.lbl_ViewInPa.Location = new System.Drawing.Point(15, 16);
            this.lbl_ViewInPa.Name = "lbl_ViewInPa";
            this.lbl_ViewInPa.Size = new System.Drawing.Size(317, 37);
            this.lbl_ViewInPa.TabIndex = 22;
            this.lbl_ViewInPa.Text = "View In Patient Details";
            // 
            // btn_Back_ViewInPa
            // 
            this.btn_Back_ViewInPa.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Back_ViewInPa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Back_ViewInPa.FlatAppearance.BorderSize = 5;
            this.btn_Back_ViewInPa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Back_ViewInPa.Image = global::FamilyCareHospital.Properties.Resources.BACK_undo_32px;
            this.btn_Back_ViewInPa.Location = new System.Drawing.Point(897, 16);
            this.btn_Back_ViewInPa.Name = "btn_Back_ViewInPa";
            this.btn_Back_ViewInPa.Size = new System.Drawing.Size(74, 41);
            this.btn_Back_ViewInPa.TabIndex = 23;
            this.btn_Back_ViewInPa.UseVisualStyleBackColor = false;
            this.btn_Back_ViewInPa.Click += new System.EventHandler(this.btn_Back_ViewInPa_Click);
            // 
            // chart1_view
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1_view.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1_view.Legends.Add(legend1);
            this.chart1_view.Location = new System.Drawing.Point(275, 262);
            this.chart1_view.Name = "chart1_view";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Condition";
            this.chart1_view.Series.Add(series1);
            this.chart1_view.Size = new System.Drawing.Size(541, 263);
            this.chart1_view.TabIndex = 62;
            this.chart1_view.Text = "chart1";
            // 
            // Ward_Admin_View_In_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(993, 616);
            this.Controls.Add(this.btn_Back_ViewInPa);
            this.Controls.Add(this.lbl_ViewInPa);
            this.Controls.Add(this.panel1_ViewInPa);
            this.Name = "Ward_Admin_View_In_Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ward_Admin_View_In_Patient";
            this.panel1_ViewInPa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_viewPatient)).EndInit();
            this.groupBox3_View_InPa.ResumeLayout(false);
            this.groupBox3_View_InPa.PerformLayout();
            this.groupBox2_View_InPa.ResumeLayout(false);
            this.groupBox2_View_InPa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1__View_InPa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1_ViewInPa;
        private System.Windows.Forms.Label lbl_ViewInPa;
        private System.Windows.Forms.Button btn_Back_ViewInPa;
        private System.Windows.Forms.GroupBox groupBox2_View_InPa;
        private System.Windows.Forms.TextBox txt_BedNo_ViewInPa;
        private System.Windows.Forms.Label lbl_BedNo_ViewInPa;
        private System.Windows.Forms.TextBox txt_RoomNo_ViewInPa;
        private System.Windows.Forms.Label lbl_RoomNo_ViewInPa;
        private System.Windows.Forms.TextBox txt_WardName_ViewInPa;
        private System.Windows.Forms.Label lbl_WardName_ViewInPa;
        private System.Windows.Forms.TextBox txt_gender_ViewInPa;
        private System.Windows.Forms.PictureBox pictureBox1__View_InPa;
        private System.Windows.Forms.Label lbl_gender_ViewInPa;
        private System.Windows.Forms.TextBox txt_Lname_ViewInPa;
        private System.Windows.Forms.Label lbl_PaID_ViewInPa;
        private System.Windows.Forms.TextBox txt_Fname_ViewInPa;
        private System.Windows.Forms.Label lbl_Fname_ViewInPa;
        private System.Windows.Forms.Label lbl_Lname_ViewInPa;
        private System.Windows.Forms.TextBox txt_PaID_ViewInPa;
        private System.Windows.Forms.GroupBox groupBox3_View_InPa;
        private System.Windows.Forms.TextBox txt_Search_ViewInPa;
        private System.Windows.Forms.ComboBox cmb_Search_ViewInPa;
        private System.Windows.Forms.Button btn_Search_ViewInPa;
        private System.Windows.Forms.DataGridView dataGridView1_viewPatient;
        private System.Windows.Forms.Button btnRefresh_ViewPa;
        private System.Windows.Forms.Button btn_LoadChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1_view;
    }
}