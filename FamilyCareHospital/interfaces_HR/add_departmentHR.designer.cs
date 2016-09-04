namespace FamilyCareHospital.interfaces_HR
{
    partial class add_departmentHR
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
            this.txt_dep_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dep_id = new System.Windows.Forms.TextBox();
            this.btn_updt = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv_dept = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dept)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_dep_name
            // 
            this.txt_dep_name.Location = new System.Drawing.Point(163, 214);
            this.txt_dep_name.Name = "txt_dep_name";
            this.txt_dep_name.Size = new System.Drawing.Size(158, 20);
            this.txt_dep_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Department name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(33, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Department ID";
            // 
            // txt_dep_id
            // 
            this.txt_dep_id.Location = new System.Drawing.Point(163, 152);
            this.txt_dep_id.Name = "txt_dep_id";
            this.txt_dep_id.Size = new System.Drawing.Size(158, 20);
            this.txt_dep_id.TabIndex = 6;
            // 
            // btn_updt
            // 
            this.btn_updt.Image = global::FamilyCareHospital.Properties.Resources.EDIT_edit_32px;
            this.btn_updt.Location = new System.Drawing.Point(467, 330);
            this.btn_updt.Name = "btn_updt";
            this.btn_updt.Size = new System.Drawing.Size(65, 51);
            this.btn_updt.TabIndex = 7;
            this.btn_updt.UseVisualStyleBackColor = true;
            this.btn_updt.Click += new System.EventHandler(this.btn_updt_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = global::FamilyCareHospital.Properties.Resources.ADD_add_file_32px;
            this.btn_add.Location = new System.Drawing.Point(355, 330);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(65, 51);
            this.btn_add.TabIndex = 8;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::FamilyCareHospital.Properties.Resources.DELETE_trash_32px;
            this.btn_delete.Location = new System.Drawing.Point(579, 330);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(65, 51);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv_dept
            // 
            this.dgv_dept.AllowUserToAddRows = false;
            this.dgv_dept.AllowUserToDeleteRows = false;
            this.dgv_dept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dept.Location = new System.Drawing.Point(355, 123);
            this.dgv_dept.Name = "dgv_dept";
            this.dgv_dept.ReadOnly = true;
            this.dgv_dept.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dept.Size = new System.Drawing.Size(289, 150);
            this.dgv_dept.TabIndex = 10;
            this.dgv_dept.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_dept_MouseClick);
            // 
            // btn_back
            // 
            this.btn_back.Image = global::FamilyCareHospital.Properties.Resources.BACK_undo_32px;
            this.btn_back.Location = new System.Drawing.Point(646, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(65, 51);
            this.btn_back.TabIndex = 108;
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(311, 39);
            this.label8.TabIndex = 109;
            this.label8.Text = "Add Department";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // add_departmentHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 426);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_dept);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_updt);
            this.Controls.Add(this.txt_dep_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_dep_name);
            this.MaximizeBox = false;
            this.Name = "add_departmentHR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_departmentHR";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dept)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_dep_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dep_id;
        private System.Windows.Forms.Button btn_updt;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dgv_dept;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label8;
    }
}