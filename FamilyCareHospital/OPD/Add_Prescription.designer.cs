namespace FamilyCareHospital
{
    partial class Add_Prescription
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
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.grpbxpPatirntDetails = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblBill_Date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richtxtCase_History = new System.Windows.Forms.RichTextBox();
            this.richtxtMedication = new System.Windows.Forms.RichTextBox();
            this.richtxtNote = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPresciption_ID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Back_ManageInPa = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd_Presc = new System.Windows.Forms.Button();
            this.grpbxpPatirntDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPatient
            // 
            this.txtPatient.Location = new System.Drawing.Point(236, 133);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(100, 20);
            this.txtPatient.TabIndex = 32;
            // 
            // grpbxpPatirntDetails
            // 
            this.grpbxpPatirntDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxpPatirntDetails.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpbxpPatirntDetails.Controls.Add(this.txtLastName);
            this.grpbxpPatirntDetails.Controls.Add(this.txtFirstName);
            this.grpbxpPatirntDetails.Controls.Add(this.lblLastName);
            this.grpbxpPatirntDetails.Controls.Add(this.lblFirstName);
            this.grpbxpPatirntDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxpPatirntDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpbxpPatirntDetails.Location = new System.Drawing.Point(40, 159);
            this.grpbxpPatirntDetails.Name = "grpbxpPatirntDetails";
            this.grpbxpPatirntDetails.Size = new System.Drawing.Size(915, 95);
            this.grpbxpPatirntDetails.TabIndex = 31;
            this.grpbxpPatirntDetails.TabStop = false;
            this.grpbxpPatirntDetails.Text = "Patient Details";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(706, 40);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(332, 40);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(552, 43);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 16);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(193, 43);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Fisrt Name";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(574, 279);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(150, 20);
            this.txtDate.TabIndex = 29;
            this.txtDate.TextChanged += new System.EventHandler(this.txtBill_Date_TextChanged);
            // 
            // lblBill_Date
            // 
            this.lblBill_Date.AutoSize = true;
            this.lblBill_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill_Date.Location = new System.Drawing.Point(449, 282);
            this.lblBill_Date.Name = "lblBill_Date";
            this.lblBill_Date.Size = new System.Drawing.Size(40, 16);
            this.lblBill_Date.TabIndex = 30;
            this.lblBill_Date.Text = " Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Case History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Medication";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Note";
            // 
            // richtxtCase_History
            // 
            this.richtxtCase_History.Location = new System.Drawing.Point(245, 323);
            this.richtxtCase_History.Name = "richtxtCase_History";
            this.richtxtCase_History.Size = new System.Drawing.Size(479, 54);
            this.richtxtCase_History.TabIndex = 38;
            this.richtxtCase_History.Text = "";
            // 
            // richtxtMedication
            // 
            this.richtxtMedication.Location = new System.Drawing.Point(245, 424);
            this.richtxtMedication.Name = "richtxtMedication";
            this.richtxtMedication.Size = new System.Drawing.Size(479, 54);
            this.richtxtMedication.TabIndex = 39;
            this.richtxtMedication.Text = "";
            // 
            // richtxtNote
            // 
            this.richtxtNote.Location = new System.Drawing.Point(245, 524);
            this.richtxtNote.Name = "richtxtNote";
            this.richtxtNote.Size = new System.Drawing.Size(479, 54);
            this.richtxtNote.TabIndex = 40;
            this.richtxtNote.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Prescription ID";
            // 
            // txtPresciption_ID
            // 
            this.txtPresciption_ID.Location = new System.Drawing.Point(245, 275);
            this.txtPresciption_ID.Name = "txtPresciption_ID";
            this.txtPresciption_ID.Size = new System.Drawing.Size(100, 20);
            this.txtPresciption_ID.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_Back_ManageInPa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 84);
            this.panel1.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(37, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Add Prescription";
            // 
            // btn_Back_ManageInPa
            // 
            this.btn_Back_ManageInPa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Back_ManageInPa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Back_ManageInPa.FlatAppearance.BorderSize = 5;
            this.btn_Back_ManageInPa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Back_ManageInPa.Image = global::FamilyCareHospital.Properties.Resources.OPDBACK;
            this.btn_Back_ManageInPa.Location = new System.Drawing.Point(881, 23);
            this.btn_Back_ManageInPa.Name = "btn_Back_ManageInPa";
            this.btn_Back_ManageInPa.Size = new System.Drawing.Size(74, 41);
            this.btn_Back_ManageInPa.TabIndex = 22;
            this.btn_Back_ManageInPa.UseVisualStyleBackColor = false;
            this.btn_Back_ManageInPa.Click += new System.EventHandler(this.btn_Back_ManageInPa_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Image = global::FamilyCareHospital.Properties.Resources.OPDSEARCH;
            this.btnSearch.Location = new System.Drawing.Point(372, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 44);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnAdd_Presc
            // 
            this.btnAdd_Presc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAdd_Presc.Image = global::FamilyCareHospital.Properties.Resources.OPDADD;
            this.btnAdd_Presc.Location = new System.Drawing.Point(835, 626);
            this.btnAdd_Presc.Name = "btnAdd_Presc";
            this.btnAdd_Presc.Size = new System.Drawing.Size(68, 55);
            this.btnAdd_Presc.TabIndex = 34;
            this.btnAdd_Presc.UseVisualStyleBackColor = false;
            this.btnAdd_Presc.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(991, 693);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPresciption_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richtxtNote);
            this.Controls.Add(this.lblBill_Date);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.richtxtMedication);
            this.Controls.Add(this.richtxtCase_History);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPatient);
            this.Controls.Add(this.grpbxpPatirntDetails);
            this.Controls.Add(this.btnAdd_Presc);
            this.Name = "Add_Prescription";
            this.Text = "Add_Prescription";
            this.Load += new System.EventHandler(this.Add_Prescription_Load);
            this.grpbxpPatirntDetails.ResumeLayout(false);
            this.grpbxpPatirntDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.GroupBox grpbxpPatirntDetails;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblBill_Date;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnAdd_Presc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richtxtCase_History;
        private System.Windows.Forms.RichTextBox richtxtMedication;
        private System.Windows.Forms.RichTextBox richtxtNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPresciption_ID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Back_ManageInPa;
    }
}