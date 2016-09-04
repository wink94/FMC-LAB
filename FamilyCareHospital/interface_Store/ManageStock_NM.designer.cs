﻿namespace FamilyCareHospital
{
    partial class ManageStock_NM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dtp_Entry = new System.Windows.Forms.DateTimePicker();
            this.dtp_Pro = new System.Windows.Forms.DateTimePicker();
            this.dtp_expier = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_itemID = new System.Windows.Forms.TextBox();
            this.txt_BN = new System.Windows.Forms.TextBox();
            this.txt_M = new System.Windows.Forms.TextBox();
            this.txt_Qn = new System.Windows.Forms.TextBox();
            this.txt_UP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_viewAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.dtp_Entry);
            this.groupBox1.Controls.Add(this.dtp_Pro);
            this.groupBox1.Controls.Add(this.dtp_expier);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txt_itemID);
            this.groupBox1.Controls.Add(this.txt_BN);
            this.groupBox1.Controls.Add(this.txt_M);
            this.groupBox1.Controls.Add(this.txt_Qn);
            this.groupBox1.Controls.Add(this.txt_UP);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(23, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 596);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Info";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_add.Image = global::FamilyCareHospital.Properties.Resources.add_file_32px;
            this.btn_add.Location = new System.Drawing.Point(15, 513);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 40);
            this.btn_add.TabIndex = 2;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_update.Image = global::FamilyCareHospital.Properties.Resources.edit_32px;
            this.btn_update.Location = new System.Drawing.Point(115, 513);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 40);
            this.btn_update.TabIndex = 3;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_delete.Image = global::FamilyCareHospital.Properties.Resources.delete_32px;
            this.btn_delete.Location = new System.Drawing.Point(215, 513);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 40);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dtp_Entry
            // 
            this.dtp_Entry.CustomFormat = "yyyy-MM-dd";
            this.dtp_Entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Entry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Entry.Location = new System.Drawing.Point(115, 264);
            this.dtp_Entry.Name = "dtp_Entry";
            this.dtp_Entry.Size = new System.Drawing.Size(100, 20);
            this.dtp_Entry.TabIndex = 5;
            // 
            // dtp_Pro
            // 
            this.dtp_Pro.CustomFormat = "yyyy-MM-dd";
            this.dtp_Pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Pro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Pro.Location = new System.Drawing.Point(115, 309);
            this.dtp_Pro.Name = "dtp_Pro";
            this.dtp_Pro.Size = new System.Drawing.Size(100, 20);
            this.dtp_Pro.TabIndex = 6;
            // 
            // dtp_expier
            // 
            this.dtp_expier.CustomFormat = "yyyy-MM-dd";
            this.dtp_expier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_expier.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_expier.Location = new System.Drawing.Point(115, 360);
            this.dtp_expier.Name = "dtp_expier";
            this.dtp_expier.Size = new System.Drawing.Size(100, 20);
            this.dtp_expier.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "select";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(115, 87);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(162, 20);
            this.txt_name.TabIndex = 1;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // txt_itemID
            // 
            this.txt_itemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemID.Location = new System.Drawing.Point(115, 42);
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.Size = new System.Drawing.Size(162, 20);
            this.txt_itemID.TabIndex = 2;
            // 
            // txt_BN
            // 
            this.txt_BN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BN.Location = new System.Drawing.Point(115, 177);
            this.txt_BN.Name = "txt_BN";
            this.txt_BN.Size = new System.Drawing.Size(162, 20);
            this.txt_BN.TabIndex = 3;
            // 
            // txt_M
            // 
            this.txt_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_M.Location = new System.Drawing.Point(115, 222);
            this.txt_M.Name = "txt_M";
            this.txt_M.Size = new System.Drawing.Size(162, 20);
            this.txt_M.TabIndex = 4;
            // 
            // txt_Qn
            // 
            this.txt_Qn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Qn.Location = new System.Drawing.Point(115, 402);
            this.txt_Qn.Name = "txt_Qn";
            this.txt_Qn.Size = new System.Drawing.Size(162, 20);
            this.txt_Qn.TabIndex = 5;
            this.txt_Qn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Qn_KeyPress);
            // 
            // txt_UP
            // 
            this.txt_UP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UP.Location = new System.Drawing.Point(115, 447);
            this.txt_UP.Name = "txt_UP";
            this.txt_UP.Size = new System.Drawing.Size(162, 20);
            this.txt_UP.TabIndex = 6;
            this.txt_UP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_UP_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Unit Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Expier Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Production Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Entry Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Manufacture";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Batch Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(368, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // btn_search
            // 
            this.btn_search.Image = global::FamilyCareHospital.Properties.Resources.search_32px;
            this.btn_search.Location = new System.Drawing.Point(383, 21);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 40);
            this.btn_search.TabIndex = 3;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(264, 38);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 2;
            this.txt_search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_search_MouseClick);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ItemID",
            "Name",
            "Batch Number"});
            this.comboBox2.Location = new System.Drawing.Point(116, 37);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "select";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Choose Type";
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_back.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.Image = global::FamilyCareHospital.Properties.Resources.undo_32px;
            this.btn_back.Location = new System.Drawing.Point(1097, 14);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 40);
            this.btn_back.TabIndex = 4;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(941, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Category";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(944, 156);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.Text = "select";
            // 
            // btn_view
            // 
            this.btn_view.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_view.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_view.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_view.Location = new System.Drawing.Point(1078, 142);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(75, 35);
            this.btn_view.TabIndex = 6;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_viewAll
            // 
            this.btn_viewAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_viewAll.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_viewAll.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_viewAll.Location = new System.Drawing.Point(1078, 91);
            this.btn_viewAll.Name = "btn_viewAll";
            this.btn_viewAll.Size = new System.Drawing.Size(75, 33);
            this.btn_viewAll.TabIndex = 7;
            this.btn_viewAll.Text = "View All";
            this.btn_viewAll.UseVisualStyleBackColor = false;
            this.btn_viewAll.Click += new System.EventHandler(this.btn_viewAll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(368, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(785, 427);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(550, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 24);
            this.label13.TabIndex = 9;
            this.label13.Text = "Non Medical Store";
            // 
            // ManageStock_NM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_viewAll);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageStock_NM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Stock Non Medical ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_itemID;
        private System.Windows.Forms.TextBox txt_BN;
        private System.Windows.Forms.TextBox txt_M;
        private System.Windows.Forms.TextBox txt_Qn;
        private System.Windows.Forms.TextBox txt_UP;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DateTimePicker dtp_Entry;
        private System.Windows.Forms.DateTimePicker dtp_Pro;
        private System.Windows.Forms.DateTimePicker dtp_expier;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_viewAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label13;
    }
}