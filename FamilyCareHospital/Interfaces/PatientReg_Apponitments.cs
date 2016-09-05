using System;
using System.Data;
using System.Windows.Forms;
using FamilyCareHospital.Controllers;
using FamilyCareHospital.DBAccess;
using FamilyCareHospital.Interfaces;

namespace FamilyCareHospital
{
    public partial class Form2 : Form
    {
        private DBRetrieve dbr ;
        private LabPatient labPatient ;
        private LabAppointment labappmnt ;
        private LabAppointment manipulateLabAppmnt ;
        private LabPatient manipulateLabPatient;
        

        public Form2()
        {
            InitializeComponent();
            dbr = new DBRetrieve();
            labPatient = new LabPatient();
            labappmnt = new LabAppointment();
            manipulateLabAppmnt = new LabAppointment();
            manipulateLabPatient = new LabPatient();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FillTestSearch();
            FillAppointments();
            FillGendercmbBox();
            displayTodayAppointmentcount(DateTime.Now);
            gBxSelectApmnt.Hide();
            gBxAmpntLimit.Hide();
            //MessageBox.Show(dbr.getAppointmentLimit.ToString());
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

            Validation validation = new Validation();

            

                if (fieldCheck(txtPName.Text, "name", "lblLPNameErr", "lblLPNamePicErr", "grpBoxLPRegister") & fieldCheck(txtPAge.Text, "age", "lblLPAgeErr", "lblLPAgePicErr", "grpBoxLPRegister") & fieldCheck(txtPPhone.Text, "phone", "lblLPPhoneErr", "lblLPPhonePicErr", "grpBoxLPRegister") & fieldCheck(txtPEmail.Text, "email", "lblLPEmailErr", "lblLPEmailPicErr", "grpBoxLPRegister") & fieldCheck(cmbGender.SelectedItem.ToString(),null,null,  "lblLPGenderPicErr", "grpBoxLPRegister") & validation.checkTestListEmpty(labPatient) & validation.checkDateIsSet(labappmnt.Adate, "Lab Appointment"))
                {
                    labPatient.setDetails(txtPName.Text, cmbGender.SelectedValue.ToString(), txtPEmail.Text, txtPPhone.Text, Convert.ToInt32(txtPAge.Text));

                    LabPatientBill lpb = new LabPatientBill(labPatient, labappmnt);
                    lpb.ShowDialog();
                    //this.Dispose();

                    if (lpb.appoinmentStatus)
                    {
                        lpb.Dispose();
                        emptyFields();
                        labPatient.emptyTestList();

                        tabCtrlPReg_App.SelectedIndex = 1;

                    }
                    else
                        lpb.Dispose();

                }
            

            //else
                //validation.printError(true);
        }

        private bool fieldCheck(string value, string field=null,string field_lbl=null, string pic_lbl = null, string container=null)
        {
            Validation validation = new Validation();
            
            if (validation.checkFieldIsSet(value))
            {
                assignMessagesToLabels(pic_lbl, "err_pic_remove", container);

                if (field == "name")
                {
                    if (validation.alphaVal(value))
                    {
                        assignMessagesToLabels(field_lbl, validation.AlphabeticEror, container);
                        return true;
                    }
                    else
                    {
                        assignMessagesToLabels(field_lbl, validation.AlphabeticEror, container);
                        return false;
                    }
                }

                else if (field == "age")
                {
                    if (validation.IsNumeric(value))
                    {
                        assignMessagesToLabels(field_lbl, validation.NumericEror, container);

                        int age = Convert.ToInt32(value);
                        if (age < 5 || age > 100)
                        {
                            assignMessagesToLabels(field_lbl, "*Age should be logical ", container);
                            return false;
                        }
                        else
                        {
                            assignMessagesToLabels(field_lbl, "clear", container);
                            return true;
                        }
                    }


                    else
                    {
                        assignMessagesToLabels(field_lbl, validation.NumericEror, container);
                        return false;
                    }


                }

                else if (field == "phone")
                {
                    if (validation.numberVal(value))
                    {
                        assignMessagesToLabels(field_lbl, validation.TelephoneNumberEror, container);
                        return true;
                    }
                    else
                    {
                        assignMessagesToLabels(field_lbl, validation.TelephoneNumberEror, container);
                        return false;
                    }
                }

                else if (field == "email")
                {
                    if (validation.emailVal(value))
                    {
                        assignMessagesToLabels(field_lbl, validation.EmailEror, container);
                        return true;
                    }
                    else
                    {
                        assignMessagesToLabels(field_lbl, validation.EmailEror, container);
                        return false;
                    }
                }

                else
                    return true;


            }
                
            else
            {
                assignMessagesToLabels(pic_lbl, "err_pic", container);
                return false;
            }
                    
            

        }

        /* assogn error msg to labels */
        private void assignMessagesToLabels(string lbl,string msg,string container)
        {
            if (container != null)
            {
                //var cont=(GroupBox)controls[name]  doesn't work????
                Label label;

                if (container == "grpBoxLPRegister")
                {
                     label = (Label)grpBoxLPRegister.Controls[lbl];

                    if (msg == "err_pic")
                    {
                        label.Text = " ";
                        label.Image = Properties.Resources.required;
                    }
                    else if (msg == "err_pic_remove")
                    {
                        label.Text = "";
                    }

                    else if (msg == "clear")
                    {
                        label.Text = "";
                    }
                    else
                    {
                        label.Text = msg;
                    }
                }

                if (container == "grpBoxLPUpdate")
                {
                     label = (Label)grpBoxLPUpdate.Controls[lbl];

                    if (msg == "err_pic")
                    {
                        label.Text = " ";
                        label.Image = Properties.Resources.required;
                    }
                    else if (msg == "err_pic_remove")
                    {
                        label.Text = "";
                    }

                    else if (msg == "clear")
                    {
                        label.Text = "";
                    }
                    else
                    {
                        label.Text = msg;
                    }
                }

            }

        }

        private void emptyFields()
        {
            txtPAge.Text = "";
            txtPEmail.Text = "";
            txtPName.Text = "";
            txtPPhone.Text = "";
            txtPSearchTest.Text = "";
            cmbGender.SelectedIndex = 0;
        }


        /*  fill test list and  */

        private void FillTestSearch()
        {

            DataTable dt1 = dbr.getSearchedTestDetails(txtPSearchTest.Text);


            lstTests.ValueMember = "TestID";
            lstTests.DisplayMember = "TestName";
            lstTests.DataSource = dt1;

        }

        /*  set hoover effect to arrow buttons */

        private void txtPSearchTest_TextChanged(object sender, EventArgs e)
        {
            FillTestSearch();
        }

        private void pboxAdd_MouseHover(object sender, EventArgs e)
        {
            pboxAdd.BackgroundImage = Properties.Resources.blue_right_arrow_hoover;
        }

        private void pboxAdd_MouseLeave(object sender, EventArgs e)
        {
            pboxAdd.BackgroundImage = null;
        }

        private void pboxRemove_MouseHover(object sender, EventArgs e)
        {
            pboxRemove.BackgroundImage = Properties.Resources.blue_left_hoover;
        }

        private void pboxRemove_MouseLeave(object sender, EventArgs e)
        {
            pboxRemove.BackgroundImage = null;
        }

       


        /*  add tests to patient list */

        private void pboxAdd_Click(object sender, EventArgs e)
        {
            if (lstTests.SelectedIndex >= 0)
            {
                string id = lstTests.SelectedValue.ToString();


                if (!labPatient.findIfExist(id))
                {

                    getTestList gTL = new getTestList(id, labPatient.getSelectedFromList(id));
                    //testList.Add(gTL);
                    labPatient.getPatientTest(gTL);



                    try
                    {
                        lstPTests.DataSource = labPatient.tests;
                        lstPTests.ValueMember = "id";
                        lstPTests.DisplayMember = "name";
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message);
                    }
                    lstTests.ClearSelected();
                    lstPTests.ClearSelected();
                }

            }
           
        }

        /*  remove tests from patient list */

        private void pboxRemove_Click(object sender, EventArgs e)
        {
            if (lstPTests.SelectedIndex>=0)
            {
                labPatient.removeTest(lstPTests.SelectedIndex);
                lstPTests.ClearSelected();
            }
        }

        private void FillGendercmbBox()
        {
            string[] gender = { "","Male","Female"};

            cmbGender.DataSource = gender;
            cmbLPGenderUpdate.DataSource = gender;
        }

        private void displayTodayAppointmentcount(DateTime dt)
        {
            string today = dt.ToString("yyyy-MM-dd");
            lblAppNum.Text = dbr.getAppointmentCount(today).ToString();
        }

        private void tabCtrlPReg_App_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrlPReg_App.SelectedIndex == 0)
            {
                displayTodayAppointmentcount(DateTime.Now);
                gBxSelectApmnt.Hide();
            }
            else if(tabCtrlPReg_App.SelectedIndex == 1)
            {
                FillAppointments();
            }
        }

        private void btnSetAppmnt_Click(object sender, EventArgs e)
        {
            if (gBxSelectApmnt.Visible == false)
                gBxSelectApmnt.Show();
            else
                gBxSelectApmnt.Hide();
        }

        private void btnSetAppLimit_Click(object sender, EventArgs e)
        {
            //if (gBxAmpntLimit.Visible == false)
            //{
            //    gBxAmpntLimit.Show();
               
            //}
            //else if(txtAppmntLimit.Text != null && txtAppmntLimit.Text != "" && gBxAmpntLimit.Visible == true)
            //{
            //    Validation val = new Validation();
            //    if (val.IsNumeric(txtAppmntLimit.Text, "Set Appointment Limit"))
            //    {
            //        DBInsert dbi = new DBInsert();
            //        dbi.insertLabAppointmentLimit(txtAppmntLimit.Text);
            //        MessageBox.Show("Appointment Limit is set ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //        val.printError(true);
            //}
            //else
            //{
            //    gBxAmpntLimit.Hide();
            //}

        }

        private void btnSetAppmntToday_Click(object sender, EventArgs e)
        {
            string date= DateTime.Now.ToString("yyyy-MM-dd");

            if (labappmnt.isAppointmentAllowed(date))
            {
                labappmnt.Adate = date;
                MessageBox.Show("Appointment Date is set ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dateAppDate_ValueChanged(object sender, EventArgs e)
        {
            string date = dateAppDate.Value.ToString("yyyy-MM-dd");

            if (labappmnt.isAppointmentAllowed(date))
            {
                labappmnt.Adate = date;
                MessageBox.Show("Appointment Date is set ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /*  fill appointment details  */

        private void FillAppointments()
        {

            DataSet ds = dbr.getAppointmentDetails();
            dgvAppointmentList.DataSource = ds.Tables["lab_appointments"].DefaultView;

        }

        private void FillSearchedAppointments(string appmntID)
        {
            try
            {
                DataSet ds = dbr.getSearcehdLabAppointment(appmntID);
                dgvAppointmentList.DataSource = ds.Tables["lab_appointments"].DefaultView;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void FillSearchedAppointmentsByDate(DateTime DateF,DateTime DateT)
        {
            try
            {
                DataSet ds = dbr.getSearcehdLabAppointmentFromDate(DateF, DateT);
                dgvAppointmentList.DataSource = ds.Tables["lab_appointments"].DefaultView;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }


        private void txtAppointmentSearch_TextChanged(object sender, EventArgs e)
        {
            FillSearchedAppointments(txtAppointmentSearch.Text);
        }

        private void btnSearchAppmntByDate_Click(object sender, EventArgs e)
        {
            DateTime dateF = dateFrom.Value;
            DateTime dateT = dateTo.Value;

            if (DateTime.Compare(dateF, dateT) <= 0)
            {
                FillSearchedAppointmentsByDate(dateF,dateT);
            }
            else
            {
                MessageBox.Show("Invalid Date Compare","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void fillUpdateFormData(LabPatient details)
        {
            txtLPAgeUpdate.Text =details.Age.ToString();
            txtLPEmailUpdate.Text = details.Email;
            txtLPNameUpdate.Text = details.Name;
            txtLPPhoneUpdate.Text = details.Phone;
            cmbLPGenderUpdate.SelectedItem = details.Gender;

        }

        private void emptyUpdateFormData()
        {
            txtLPAgeUpdate.Text = "";
            txtLPEmailUpdate.Text = "";
            txtLPNameUpdate.Text = "";
            txtLPPhoneUpdate.Text = "";
            cmbLPGenderUpdate.SelectedItem = null;

        }
        /* fill patient and appointment object with clicked row details*/
        private void fillManipulateObject(int rowid)
        {
            manipulateLabAppmnt.AID = dgvAppointmentList.Rows[rowid].Cells["dgvAppointmentID"].Value.ToString();
            manipulateLabAppmnt.Adate= (dgvAppointmentList.Rows[rowid].Cells["dgvAppointmentDate"].Value).ToString();
            manipulateLabPatient.ID = dgvAppointmentList.Rows[rowid].Cells["dgvPatientID"].Value.ToString();
            dateLPAppDateUpdate.Value = DateTime.Parse(dgvAppointmentList.Rows[rowid].Cells["dgvAppointmentDate"].Value.ToString());
            manipulateLabPatient.getLabPatientDetails();
            fillUpdateFormData(manipulateLabPatient);
        }

        /*fill apponitments details on DGV cell click event*/
        private void dgvAppointmentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            else
            {
                fillManipulateObject(e.RowIndex); 
               
                if (e.ColumnIndex == dbvAppointmentDelete.Index)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Delete Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        manipulateLabAppmnt.deleteLabAppointment();
                        manipulateLabPatient.deleteLabPatientAndTests();
                        emptyUpdateFormData();
                    }
                    
                }

                FillAppointments();
            }
        }

        /*update patients detals on button click*/

        private void btnLPUpdate_Click(object sender, EventArgs e)
        {
            Validation val = new Validation();
            if (fieldCheck(txtLPNameUpdate.Text, "name", "lblLPUpdateNameErr", "lblLPUpdateNamePicErr", "grpBoxLPUpdate") & fieldCheck(txtLPAgeUpdate.Text, "age", "lblLPUpdateAgeErr", "lblLPUpdateAgePicErr", "grpBoxLPUpdate") & fieldCheck(txtLPPhoneUpdate.Text, "phone", "lblLPUpdatePhoneErr", "lblLPUpdatePhonePicErr", "grpBoxLPUpdate") & fieldCheck(txtLPEmailUpdate.Text, "email", "lblLPUpdateEmailErr", "lblLPUpdateEmailPicErr", "grpBoxLPUpdate") & fieldCheck(cmbLPGenderUpdate.SelectedItem.ToString(), null, null, "lblLPUpdateGenderPicErr", "grpBoxLPUpdate")  )
            {
                string upName = txtLPNameUpdate.Text, upAge = txtLPAgeUpdate.Text, upPhone = txtLPPhoneUpdate.Text, upEmail = txtLPEmailUpdate.Text, upAppmntDate = dateLPAppDateUpdate.Value.ToString("yyyy-MM-dd"), upGender = cmbLPGenderUpdate.SelectedItem.ToString();

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update?", "Update Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (manipulateLabPatient.Name != upName)
                    {
                        manipulateLabPatient.Name = upName;
                        manipulateLabPatient.updateLabPatientData("Name");
                    }

                    if (manipulateLabPatient.Age.ToString() != upAge)
                    {
                        manipulateLabPatient.Age = Convert.ToInt32(upAge);
                        manipulateLabPatient.updateLabPatientData("Age");
                    }

                    if (manipulateLabPatient.Phone != upPhone)
                    {
                        manipulateLabPatient.Phone = upPhone;
                        manipulateLabPatient.updateLabPatientData("Phone");
                    }

                    if (manipulateLabPatient.Email != upEmail)
                    {
                        manipulateLabPatient.Email = upEmail;
                        manipulateLabPatient.updateLabPatientData("Email");
                    }

                    if (manipulateLabAppmnt.Adate != upAppmntDate && manipulateLabAppmnt.isAppointmentAllowed(upAppmntDate))
                    {
                        manipulateLabAppmnt.Adate = upAppmntDate;
                        manipulateLabAppmnt.updateLabAppointmentDate();
                    }

                    if (manipulateLabPatient.Gender != upGender)
                    {
                        manipulateLabPatient.Gender = upGender;
                        manipulateLabPatient.updateLabPatientData("Gender");
                    }

                    FillAppointments();
                }

                else if (dialogResult == DialogResult.No)
                {
                    emptyUpdateFormData();
                }


            }
            else
            {
                val.printError(true);
            }


        }

        private void btnLPUpdateCancel_Click(object sender, EventArgs e)
        {
            emptyUpdateFormData();
        }

        private void btnManageAppmntBack_Click(object sender, EventArgs e)
        {
            Form1 labHome = new Form1();
            labHome.Show();
            this.Hide();
        }

        private void btnPatientRegBack_Click(object sender, EventArgs e)
        {
            Form1 labHome = new Form1();
            labHome.Show();
            this.Hide();
        }
    }
}
