namespace FamilyCareHospital.Interfaces
{
    partial class ManageTest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpBoxTestUpdate = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdateTest = new System.Windows.Forms.Button();
            this.lblTestNamePicErr = new System.Windows.Forms.Label();
            this.lblTestPricePicErr = new System.Windows.Forms.Label();
            this.lblTestPriceErr = new System.Windows.Forms.Label();
            this.lblTestNameErr = new System.Windows.Forms.Label();
            this.lblTestID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTestPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnManageTestBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTests = new System.Windows.Forms.DataGridView();
            this.dgvTestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTestPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTestSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.grpBoxTestUpdate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.grpBoxTestUpdate);
            this.panel1.Controls.Add(this.btnManageTestBack);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 598);
            this.panel1.TabIndex = 0;
            // 
            // grpBoxTestUpdate
            // 
            this.grpBoxTestUpdate.Controls.Add(this.button1);
            this.grpBoxTestUpdate.Controls.Add(this.btnUpdateTest);
            this.grpBoxTestUpdate.Controls.Add(this.lblTestNamePicErr);
            this.grpBoxTestUpdate.Controls.Add(this.lblTestPricePicErr);
            this.grpBoxTestUpdate.Controls.Add(this.lblTestPriceErr);
            this.grpBoxTestUpdate.Controls.Add(this.lblTestNameErr);
            this.grpBoxTestUpdate.Controls.Add(this.lblTestID);
            this.grpBoxTestUpdate.Controls.Add(this.label4);
            this.grpBoxTestUpdate.Controls.Add(this.txtTestPrice);
            this.grpBoxTestUpdate.Controls.Add(this.label3);
            this.grpBoxTestUpdate.Controls.Add(this.txtTestName);
            this.grpBoxTestUpdate.Controls.Add(this.label2);
            this.grpBoxTestUpdate.Location = new System.Drawing.Point(22, 93);
            this.grpBoxTestUpdate.Name = "grpBoxTestUpdate";
            this.grpBoxTestUpdate.Size = new System.Drawing.Size(399, 433);
            this.grpBoxTestUpdate.TabIndex = 16;
            this.grpBoxTestUpdate.TabStop = false;
            this.grpBoxTestUpdate.Text = "groupBox2";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(267, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 82);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTest
            // 
            this.btnUpdateTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdateTest.Image = global::FamilyCareHospital.Properties.Resources.EDIT_edit_64px;
            this.btnUpdateTest.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdateTest.Location = new System.Drawing.Point(171, 339);
            this.btnUpdateTest.Name = "btnUpdateTest";
            this.btnUpdateTest.Size = new System.Drawing.Size(71, 82);
            this.btnUpdateTest.TabIndex = 12;
            this.btnUpdateTest.Text = "Update";
            this.btnUpdateTest.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnUpdateTest.UseVisualStyleBackColor = true;
            this.btnUpdateTest.Click += new System.EventHandler(this.btnUpdateTest_Click);
            // 
            // lblTestNamePicErr
            // 
            this.lblTestNamePicErr.AutoSize = true;
            this.lblTestNamePicErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestNamePicErr.ForeColor = System.Drawing.Color.Red;
            this.lblTestNamePicErr.Location = new System.Drawing.Point(313, 127);
            this.lblTestNamePicErr.Name = "lblTestNamePicErr";
            this.lblTestNamePicErr.Size = new System.Drawing.Size(11, 15);
            this.lblTestNamePicErr.TabIndex = 10;
            this.lblTestNamePicErr.Text = ".";
            // 
            // lblTestPricePicErr
            // 
            this.lblTestPricePicErr.AutoSize = true;
            this.lblTestPricePicErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestPricePicErr.ForeColor = System.Drawing.Color.Red;
            this.lblTestPricePicErr.Location = new System.Drawing.Point(313, 219);
            this.lblTestPricePicErr.Name = "lblTestPricePicErr";
            this.lblTestPricePicErr.Size = new System.Drawing.Size(11, 15);
            this.lblTestPricePicErr.TabIndex = 10;
            this.lblTestPricePicErr.Text = ".";
            // 
            // lblTestPriceErr
            // 
            this.lblTestPriceErr.AutoSize = true;
            this.lblTestPriceErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestPriceErr.ForeColor = System.Drawing.Color.Red;
            this.lblTestPriceErr.Location = new System.Drawing.Point(168, 235);
            this.lblTestPriceErr.Name = "lblTestPriceErr";
            this.lblTestPriceErr.Size = new System.Drawing.Size(11, 15);
            this.lblTestPriceErr.TabIndex = 10;
            this.lblTestPriceErr.Text = ".";
            // 
            // lblTestNameErr
            // 
            this.lblTestNameErr.AutoSize = true;
            this.lblTestNameErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestNameErr.ForeColor = System.Drawing.Color.Red;
            this.lblTestNameErr.Location = new System.Drawing.Point(168, 145);
            this.lblTestNameErr.Name = "lblTestNameErr";
            this.lblTestNameErr.Size = new System.Drawing.Size(11, 15);
            this.lblTestNameErr.TabIndex = 10;
            this.lblTestNameErr.Text = ".";
            // 
            // lblTestID
            // 
            this.lblTestID.AutoSize = true;
            this.lblTestID.Location = new System.Drawing.Point(168, 30);
            this.lblTestID.Name = "lblTestID";
            this.lblTestID.Size = new System.Drawing.Size(35, 13);
            this.lblTestID.TabIndex = 10;
            this.lblTestID.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Test Price";
            // 
            // txtTestPrice
            // 
            this.txtTestPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestPrice.Location = new System.Drawing.Point(171, 212);
            this.txtTestPrice.Name = "txtTestPrice";
            this.txtTestPrice.Size = new System.Drawing.Size(136, 22);
            this.txtTestPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Test Name";
            // 
            // txtTestName
            // 
            this.txtTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestName.Location = new System.Drawing.Point(171, 122);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(136, 22);
            this.txtTestName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Test ID";
            // 
            // btnManageTestBack
            // 
            this.btnManageTestBack.Image = global::FamilyCareHospital.Properties.Resources.BACK_undo_32px1;
            this.btnManageTestBack.Location = new System.Drawing.Point(979, 13);
            this.btnManageTestBack.Name = "btnManageTestBack";
            this.btnManageTestBack.Size = new System.Drawing.Size(59, 50);
            this.btnManageTestBack.TabIndex = 15;
            this.btnManageTestBack.UseVisualStyleBackColor = true;
            this.btnManageTestBack.Click += new System.EventHandler(this.btnManageTestBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.dgvTests);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTestSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(438, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 337);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Appointments";
            // 
            // dgvTests
            // 
            this.dgvTests.AllowUserToAddRows = false;
            this.dgvTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTestID,
            this.dgvTestName,
            this.dgvTestPrice,
            this.dgvDel});
            this.dgvTests.Location = new System.Drawing.Point(46, 138);
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.ReadOnly = true;
            this.dgvTests.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvTests.RowHeadersVisible = false;
            this.dgvTests.Size = new System.Drawing.Size(491, 166);
            this.dgvTests.TabIndex = 0;
            this.dgvTests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTests_CellClick);
            // 
            // dgvTestID
            // 
            this.dgvTestID.DataPropertyName = "labTestID";
            this.dgvTestID.HeaderText = "TestID";
            this.dgvTestID.Name = "dgvTestID";
            this.dgvTestID.ReadOnly = true;
            this.dgvTestID.Width = 120;
            // 
            // dgvTestName
            // 
            this.dgvTestName.DataPropertyName = "labTestName";
            this.dgvTestName.HeaderText = "TestName";
            this.dgvTestName.Name = "dgvTestName";
            this.dgvTestName.ReadOnly = true;
            this.dgvTestName.Width = 170;
            // 
            // dgvTestPrice
            // 
            this.dgvTestPrice.DataPropertyName = "labTestPrice";
            this.dgvTestPrice.HeaderText = "TestPrice";
            this.dgvTestPrice.Name = "dgvTestPrice";
            this.dgvTestPrice.ReadOnly = true;
            this.dgvTestPrice.Width = 120;
            // 
            // dgvDel
            // 
            this.dgvDel.HeaderText = "Delete";
            this.dgvDel.Image = global::FamilyCareHospital.Properties.Resources.cancel_25px;
            this.dgvDel.Name = "dgvDel";
            this.dgvDel.ReadOnly = true;
            this.dgvDel.Width = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Test";
            // 
            // txtTestSearch
            // 
            this.txtTestSearch.Location = new System.Drawing.Point(176, 45);
            this.txtTestSearch.Name = "txtTestSearch";
            this.txtTestSearch.Size = new System.Drawing.Size(123, 24);
            this.txtTestSearch.TabIndex = 1;
            this.txtTestSearch.TextChanged += new System.EventHandler(this.txtTestSearch_TextChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Delete";
            this.dataGridViewImageColumn1.Image = global::FamilyCareHospital.Properties.Resources.cancel_25px;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // ManageTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1092, 661);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ManageTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageTest";
            this.Load += new System.EventHandler(this.ManageTest_Load);
            this.panel1.ResumeLayout(false);
            this.grpBoxTestUpdate.ResumeLayout(false);
            this.grpBoxTestUpdate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTestSearch;
        private System.Windows.Forms.DataGridView dgvTests;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnManageTestBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTestPrice;
        private System.Windows.Forms.DataGridViewImageColumn dgvDel;
        private System.Windows.Forms.GroupBox grpBoxTestUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdateTest;
        private System.Windows.Forms.Label lblTestID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTestPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTestNamePicErr;
        private System.Windows.Forms.Label lblTestPricePicErr;
        private System.Windows.Forms.Label lblTestPriceErr;
        private System.Windows.Forms.Label lblTestNameErr;
    }
}