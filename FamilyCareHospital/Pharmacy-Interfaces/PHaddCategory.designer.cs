namespace FamilyCareHospital.Pharmacy_Interfaces
{
    partial class PHaddCategory
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
            this.btn_updt = new System.Windows.Forms.Button();
            this.txt_cname = new System.Windows.Forms.TextBox();
            this.txt_cID = new System.Windows.Forms.TextBox();
            this.dgv_addCat = new System.Windows.Forms.DataGridView();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addCat)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_updt
            // 
            this.btn_updt.Image = global::FamilyCareHospital.Properties.Resources.EDIT_edit_32px;
            this.btn_updt.Location = new System.Drawing.Point(152, 236);
            this.btn_updt.Name = "btn_updt";
            this.btn_updt.Size = new System.Drawing.Size(75, 52);
            this.btn_updt.TabIndex = 16;
            this.btn_updt.UseVisualStyleBackColor = true;
            this.btn_updt.Click += new System.EventHandler(this.btn_updt_Click);
            // 
            // txt_cname
            // 
            this.txt_cname.Location = new System.Drawing.Point(143, 144);
            this.txt_cname.Name = "txt_cname";
            this.txt_cname.Size = new System.Drawing.Size(100, 20);
            this.txt_cname.TabIndex = 15;
            this.txt_cname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cname_KeyPress);
            // 
            // txt_cID
            // 
            this.txt_cID.Location = new System.Drawing.Point(143, 93);
            this.txt_cID.Name = "txt_cID";
            this.txt_cID.Size = new System.Drawing.Size(100, 20);
            this.txt_cID.TabIndex = 14;
            // 
            // dgv_addCat
            // 
            this.dgv_addCat.AllowUserToAddRows = false;
            this.dgv_addCat.AllowUserToDeleteRows = false;
            this.dgv_addCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_addCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_addCat.Location = new System.Drawing.Point(369, 93);
            this.dgv_addCat.Name = "dgv_addCat";
            this.dgv_addCat.ReadOnly = true;
            this.dgv_addCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_addCat.Size = new System.Drawing.Size(287, 150);
            this.dgv_addCat.TabIndex = 13;
            this.dgv_addCat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_addCat_MouseClick);
            // 
            // btn_del
            // 
            this.btn_del.Image = global::FamilyCareHospital.Properties.Resources.DELETE_trash_32px;
            this.btn_del.Location = new System.Drawing.Point(244, 236);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 52);
            this.btn_del.TabIndex = 12;
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = global::FamilyCareHospital.Properties.Resources.ADD_add_file_32px;
            this.btn_add.Location = new System.Drawing.Point(60, 236);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 52);
            this.btn_add.TabIndex = 11;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Pharmacy";
            // 
            // btn_back
            // 
            this.btn_back.Image = global::FamilyCareHospital.Properties.Resources.BACK_undo_32px;
            this.btn_back.Location = new System.Drawing.Point(572, 21);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 41);
            this.btn_back.TabIndex = 102;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // PHaddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 300);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_updt);
            this.Controls.Add(this.txt_cname);
            this.Controls.Add(this.txt_cID);
            this.Controls.Add(this.dgv_addCat);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "PHaddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharamacy Add Category";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_updt;
        private System.Windows.Forms.TextBox txt_cname;
        private System.Windows.Forms.TextBox txt_cID;
        private System.Windows.Forms.DataGridView dgv_addCat;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_back;
    }
}