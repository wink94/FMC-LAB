using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamilyCareHospital.DBAccess;
using FamilyCareHospital.Controllers;

namespace FamilyCareHospital.Interfaces
{
    public partial class TestDetailsEntry : Form
    {
        private DBRetrieve dbr;
        private LabPatient labpatient;
        private Validation validation;
        private Dictionary<string, string> txt_Panel1;
        private Dictionary<string, string> txt_Panel2;
        private Dictionary<string, string> txt_Panel3;

        public TestDetailsEntry()
        {
            InitializeComponent();
            labpatient = new LabPatient();
            dbr = new DBRetrieve();
            validation=new Validation();

            txt_Panel1 = new Dictionary<string, string> { {"Field","" }, {"DType","" }, {"Error_lbl","" } };
            txt_Panel2 = new Dictionary<string, string> { { "Field", "" }, { "DType", "" }, { "Error_lbl", "" } };
            txt_Panel3 = new Dictionary<string, string> { { "Field", "" }, { "DType", "" }, { "Error_lbl", "" } };
            
        }

        private void TestDetailsEntry_Load(object sender, EventArgs e)
        {
            FillAppointments(null,null,null);
            showHidePanels("Panel1", "Panel2", "Panel3", 0);
        }

        /*  fill test appointment details  */

        private void FillAppointments(string appointmentID = null, string fromdate = null, string todate = null)
        {
            try
            {
                DataSet ds = dbr.getTestPatientList(appointmentID, fromdate, todate);
                dgvAppointmentList.DataSource = ds.Tables["TestPatients"].DefaultView;
            }
            catch (Exception)
            {
                MessageBox.Show("connection error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAppointmentSearch_TextChanged(object sender, EventArgs e)
        {
            FillAppointments(txtAppointmentSearch.Text, null, null);
        }

        private void btnSearchAppmntByDate_Click(object sender, EventArgs e)
        {
            DateTime dateF = dateFrom.Value;
            DateTime dateT = dateTo.Value;

            if (DateTime.Compare(dateF, dateT) <= 0)
            {
                FillAppointments(null,dateF.ToString("yyyy-MM-dd"), dateT.ToString("yyyy-MM-dd"));
            }
            else
            {
                MessageBox.Show("Invalid Date Compare", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void fillPatientsTests(DataSet ds)
        {
            dgvPatientTest.DataSource = ds.Tables["PatientTestList"].DefaultView;
        }


        private void dgvAppointmentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0)
            //    return;
            //else
            //{
            //    labpatient = new LabPatient();
            //    labpatient.ID = dgvAppointmentList.Rows[e.RowIndex].Cells["dgvPatientID"].Value.ToString();
            //    fillPatientsTests(labpatient.getPatientsTestList());
            //}

            //print report cell


        }

        private void showHidePanels(string p1,string p2,string p3,int numOfPanels)
        {
            var panel1 = (Panel)grpBoxTextBoxSet.Controls[p1];
            var panel2 = (Panel)grpBoxTextBoxSet.Controls[p2];
            var panel3 = (Panel)grpBoxTextBoxSet.Controls[p3];

            if ( numOfPanels == 3)
            {
                

                if (panel1.Visible == false)
                {
                    panel1.Visible = true;
                }
                if (panel2.Visible == false)
                {
                    panel2.Visible = true;
                }
                if (panel3.Visible == false)
                {
                    panel3.Visible = true;
                }

            }

            if (numOfPanels == 2)
            {
                

                if (panel1.Visible == false)
                {
                    panel1.Visible = true;
                }
                if (panel2.Visible == false)
                {
                    panel2.Visible = true;
                }
                if (panel3.Visible == true)
                {
                    panel3.Visible = false;
                }

            }

            if (numOfPanels == 1)
            {


                if (panel1.Visible == false)
                {
                    panel1.Visible = true;
                }
                if (panel2.Visible == true)
                {
                    panel2.Visible = false;
                }
                if (panel3.Visible == true)
                {
                    panel3.Visible = false;
                }

            }

            if (numOfPanels == 0)
            {


                if (panel1.Visible == true)
                {
                    panel1.Visible = false;
                }
                if (panel2.Visible == true)
                {
                    panel2.Visible = false;
                }
                if (panel3.Visible == true)
                {
                    panel3.Visible = false;
                }

            }



        }

        private void setTxtBoxDictionaries(string field,string dtype,string err_lbl,string dicName)
        {
            if(dicName== "txt_Panel1")
            {
                txt_Panel1["Field"] = field;
                txt_Panel1["DType"] = dtype;
                txt_Panel1["Error_lbl"] = err_lbl;
            }
            if (dicName == "txt_Panel2")
            {
                txt_Panel2["Field"] = field;
                txt_Panel2["DType"] = dtype;
                txt_Panel2["Error_lbl"] = err_lbl;
            }
            if (dicName == "txt_Panel3")
            {
                txt_Panel3["Field"] = field;
                txt_Panel3["DType"] = dtype;
                txt_Panel3["Error_lbl"] = err_lbl;
            }


        }


        private void setPanelControls(string panel,string flag=null ,string testName=null,string testUnits=null)
        {
            var panel1 = (Panel)grpBoxTextBoxSet.Controls[panel];
            var lblname = (Label)panel1.Controls["lblNameTest_" + panel];
            var lblunit = (Label)panel1.Controls["lblUnitsTest_" + panel];
            //var txtbox=(TextBox)panel1.Controls["txtTest_"+panel];

            if (flag == "set")
            {
                
                lblunit.Text = testUnits;
                lblname.Text = testName;
                //txtbox.Name = testName;
            }
            else
            {
                lblunit.Text = ".";
                lblname.Text = ".";
                //txtbox.Name = "txtTest_" + panel;
            }

            
        }

        private void dgvPatientTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            else
            {
                var BT = new BloodTest();
                Dictionary<string, string> testData;
                showHidePanels("Panel1", "Panel2", "Panel3", 0);
                if (dgvAddTestResult.Index == dgvPatientTest.Columns[e.ColumnIndex].Index)
                {
                    string testId = dgvPatientTest.Rows[e.RowIndex].Cells["dgvtestID"].Value.ToString();

                    testData =BT.identifyTests(testId);
                    //setPanelControls("Panel1", null, null, null);
                    //setPanelControls("Panel2", null, null, null);
                    //setPanelControls("Panel3", null, null, null);

                    if (testData["field_num"] == "2")
                    {

                        setPanelControls("Panel1","set",testData["field1_name"], testData["field1_units"]);
                        setTxtBoxDictionaries(testData["field1_name"], testData["field1_dataType"], "lblErrorTest_Panel1", "txt_Panel1");

                        setPanelControls("Panel2", "set", testData["field2_name"], testData["field2_units"]);
                        setTxtBoxDictionaries(testData["field2_name"], testData["field2_dataType"], "lblErrorTest_Panel2", "txt_Panel2");

                        showHidePanels("Panel1", "Panel2", "Panel3", 2);
                    }
                    if (testData["field_num"] == "1")
                    {
                        setPanelControls("Panel1", "set", testData["field1_name"], testData["field1_units"]);
                        setTxtBoxDictionaries(testData["field1_name"], testData["field1_dataType"], "lblErrorTest_Panel1", "txt_Panel1");

                        showHidePanels("Panel1", "Panel2", "Panel3", 1);

                    }


                }
            }
        }

        private void dgvAppointmentList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            else
            {
                
                labpatient.ID = dgvAppointmentList.Rows[e.RowIndex].Cells["dgvPatientID"].Value.ToString();
                fillPatientsTests(labpatient.getPatientsTestList());
            }
        }

        private void txtTest_Panel1_TextChanged(object sender, EventArgs e)
        {
            var panel = (Panel)grpBoxTextBoxSet.Controls["Panel1"];
            var Error_lbl = (Label)panel.Controls[txt_Panel1["Error_lbl"]];

            if (txt_Panel1["DType"]=="int")
            {
                if (validation.IsNumeric(txtTest_Panel1.Text))
                {
                    Error_lbl.Text = validation.NumericEror;
                }
                else
                {
                    Error_lbl.Text = validation.NumericEror;
                    txtTest_Panel1.Text = "";
                }
            }

        }
    }
}
