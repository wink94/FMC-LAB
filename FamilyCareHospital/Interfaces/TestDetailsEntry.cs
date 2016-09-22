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
using System.Text.RegularExpressions;

namespace FamilyCareHospital.Interfaces
{
    public partial class TestDetailsEntry : Form
    {
        private DBRetrieve dbr;
        private LabPatient labpatient;
        private Validation validation;
        private BloodTest bloodtest;
        private LabTest labtest;
        private Dictionary<string, string> txt_Panel1;
        private Dictionary<string, string> txt_Panel2;
        private Dictionary<string, string> txt_Panel3;

        private Dictionary<string, string> updatingTest;

        public TestDetailsEntry()
        {
            InitializeComponent();
            labpatient = new LabPatient();
            dbr = new DBRetrieve();
            validation = new Validation();
            bloodtest = new BloodTest();
            labtest = new LabTest();

            txt_Panel1 = new Dictionary<string, string> { { "Field", "" }, { "DType", "" }, { "Error_lbl", "" }, { "Value", "" } };
            txt_Panel2 = new Dictionary<string, string> { { "Field", "" }, { "DType", "" }, { "Error_lbl", "" }, { "Value", "" } };
            txt_Panel3 = new Dictionary<string, string> { { "Field", "" }, { "DType", "" }, { "Error_lbl", "" }, { "Value", "" } };

            //updatingTest = new Dictionary<string, string> { { "field_num", "" } };


        }


        private void TestDetailsEntry_Load(object sender, EventArgs e)
        {
            FillAppointments(null,null,null);
            showHidePanels("Panel1", "Panel2", "Panel3", 0);
            grpBxScans.Visible = false;
            grpBoxTextBoxSet.Visible = false;
            btnSubmit.Enabled = false;
            btnUpdate.Enabled = false;
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

        private void clearDictionarys()
        {
            string[] keys = { "Field", "DType", "Error_lbl", "Value" };

            foreach (string k in keys)
            {
                txt_Panel1[k] = "";
                txt_Panel2[k] = "";
                txt_Panel3[k] = "";
            }

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
                //var BT = new BloodTest();

                showHidePanels("Panel1", "Panel2", "Panel3", 0);
                if (dgvAddTestResult.Index == dgvPatientTest.Columns[e.ColumnIndex].Index)
                {
                    if(!btnSubmit.Enabled)
                    {
                        btnSubmit.Enabled = true;
                    }

                    if (btnUpdate.Enabled)
                    {
                        btnUpdate.Enabled = false;
                    }

                    clearDictionarys();
                    if (dgvPatientTest.Rows[e.RowIndex].Cells["dgvUniqueTestStatus"].Value.ToString() == "Incomplete")
                    {

                        Dictionary<string, string> testData;
                        labtest.ID = dgvPatientTest.Rows[e.RowIndex].Cells["dgvtestID"].Value.ToString();

                        if (dgvPatientTest.Rows[e.RowIndex].Cells["dgvUniqueTestStatus"].Value.ToString() == "Complete")
                        {
                            labtest.Status = true;
                        }
                        else
                        {
                            labtest.Status = false;
                        }

                        if ((testData = labtest.identifyTest()) == null)
                        {
                            if (labtest.identifyScan())
                            {
                                //labtest.Status = false;
                                labtest.LTRNumber = dgvPatientTest.Rows[e.RowIndex].Cells["dgvLTRNum"].Value.ToString();
                                if (!grpBxScans.Visible)
                                    grpBxScans.Visible = true;

                                if (grpBoxTextBoxSet.Visible)
                                    grpBoxTextBoxSet.Visible = false;
                            }

                        }

                        else
                        {
                            if (grpBxScans.Visible)
                                grpBxScans.Visible = false;

                            if (!grpBoxTextBoxSet.Visible)
                                grpBoxTextBoxSet.Visible = true;

                            //setPanelControls("Panel1", null, null, null);
                            //setPanelControls("Panel2", null, null, null);
                            //setPanelControls("Panel3", null, null, null);

                            if (testData["field_num"] == "3")
                            {

                                setPanelControls("Panel1", "set", testData["field1_name"], testData["field1_units"]);
                                setTxtBoxDictionaries(testData["field1_name"], testData["field1_dataType"], "lblErrorTest_Panel1", "txt_Panel1");

                                setPanelControls("Panel2", "set", testData["field2_name"], testData["field2_units"]);
                                setTxtBoxDictionaries(testData["field2_name"], testData["field2_dataType"], "lblErrorTest_Panel2", "txt_Panel2");

                                setPanelControls("Panel3", "set", testData["field3_name"], testData["field3_units"]);
                                setTxtBoxDictionaries(testData["field3_name"], testData["field3_dataType"], "lblErrorTest_Panel3", "txt_Panel3");

                                showHidePanels("Panel1", "Panel2", "Panel3", 3);
                            }


                            if (testData["field_num"] == "2")
                            {

                                setPanelControls("Panel1", "set", testData["field1_name"], testData["field1_units"]);
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
                    else
                    {
                        MessageBox.Show("Please select update the Field ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }

                ///////////////update test results////////////////////

                if (dgvUpdateTestResult.Index == dgvPatientTest.Columns[e.ColumnIndex].Index)    
                {
                    clearDictionarys();

                    if (btnSubmit.Enabled)
                    {
                        btnSubmit.Enabled = false;
                    }

                    if (!btnUpdate.Enabled)
                    {
                        btnUpdate.Enabled = true;
                    }


                    if (dgvPatientTest.Rows[e.RowIndex].Cells["dgvUniqueTestStatus"].Value.ToString() == "Complete")
                    {

                        Dictionary<string, string> testData;
                        labtest.ID = dgvPatientTest.Rows[e.RowIndex].Cells["dgvtestID"].Value.ToString();

                        if ((testData = labtest.identifyTest()) == null)
                        {
                            if (labtest.identifyScan())
                            {
                                //labtest.Status = false;

                                radioSet.Checked = true;
                                labtest.LTRNumber = dgvPatientTest.Rows[e.RowIndex].Cells["dgvLTRNum"].Value.ToString();
                                if (!grpBxScans.Visible)
                                    grpBxScans.Visible = true;

                                if (grpBoxTextBoxSet.Visible)
                                    grpBoxTextBoxSet.Visible = false;

                            }

                        }

                        else
                        {
                            if (grpBxScans.Visible)
                                grpBxScans.Visible = false;

                            if (!grpBoxTextBoxSet.Visible)
                                grpBoxTextBoxSet.Visible = true;

                            updatingTest = labtest.getUpdateTestDetails(labpatient.ID);

                            if (testData["field_num"] == "3" && updatingTest["field_num"] == "3")
                            {

                                setPanelControls("Panel1", "set", testData["field1_name"], testData["field1_units"]);
                                setTxtBoxDictionaries(testData["field1_name"], testData["field1_dataType"], "lblErrorTest_Panel1", "txt_Panel1");

                                setPanelControls("Panel2", "set", testData["field2_name"], testData["field2_units"]);
                                setTxtBoxDictionaries(testData["field2_name"], testData["field2_dataType"], "lblErrorTest_Panel2", "txt_Panel2");

                                setPanelControls("Panel3", "set", testData["field3_name"], testData["field3_units"]);
                                setTxtBoxDictionaries(testData["field3_name"], testData["field3_dataType"], "lblErrorTest_Panel3", "txt_Panel3");

                                if (testData["field1_name"] == updatingTest["field1_name"])
                                {
                                    txtTest_Panel1.Text = updatingTest["field1_value"];
                                    txt_Panel1["Value"] = updatingTest["field1_value"];
                                }

                                if (testData["field2_name"] == updatingTest["field2_name"])
                                {
                                    txtTest_Panel2.Text = updatingTest["field2_value"];
                                    txt_Panel2["Value"] = updatingTest["field2_value"];
                                }

                                if (testData["field3_name"] == updatingTest["field3_name"])
                                {
                                    txtTest_Panel3.Text = updatingTest["field3_value"];
                                    txt_Panel3["Value"] = updatingTest["field3_value"];
                                }

                                showHidePanels("Panel1", "Panel2", "Panel3", 3);
                            }


                            if (testData["field_num"] == "2" && updatingTest["field_num"] == "2")
                            {

                                setPanelControls("Panel1", "set", testData["field1_name"], testData["field1_units"]);
                                setTxtBoxDictionaries(testData["field1_name"], testData["field1_dataType"], "lblErrorTest_Panel1", "txt_Panel1");

                                setPanelControls("Panel2", "set", testData["field2_name"], testData["field2_units"]);
                                setTxtBoxDictionaries(testData["field2_name"], testData["field2_dataType"], "lblErrorTest_Panel2", "txt_Panel2");

                                if (testData["field1_name"] == updatingTest["field1_name"])
                                {
                                    txtTest_Panel1.Text = updatingTest["field1_value"];
                                    txt_Panel1["Value"] = updatingTest["field1_value"];
                                }

                                if (testData["field1_name"] == updatingTest["field2_name"])
                                {
                                    txtTest_Panel1.Text = updatingTest["field2_value"];
                                    txt_Panel1["Value"] = updatingTest["field2_value"];
                                }

                                if (testData["field2_name"] == updatingTest["field2_name"])
                                {
                                    txtTest_Panel2.Text = updatingTest["field2_value"];
                                    txt_Panel2["Value"] = updatingTest["field2_value"];
                                }

                                if (testData["field2_name"] == updatingTest["field1_name"])
                                {
                                    txtTest_Panel2.Text = updatingTest["field1_value"];
                                    txt_Panel2["Value"] = updatingTest["field1_value"];
                                }

                                showHidePanels("Panel1", "Panel2", "Panel3", 2);
                            }
                            if (testData["field_num"] == "1" && updatingTest["field_num"] == "1")
                            {
                                setPanelControls("Panel1", "set", testData["field1_name"], testData["field1_units"]);
                                setTxtBoxDictionaries(testData["field1_name"], testData["field1_dataType"], "lblErrorTest_Panel1", "txt_Panel1");

                                if (testData["field1_name"] == updatingTest["field1_name"])
                                {
                                    txtTest_Panel1.Text = updatingTest["field1_value"];
                                    txt_Panel1["Value"] = updatingTest["field1_value"];
                                }

                                showHidePanels("Panel1", "Panel2", "Panel3", 1);

                            }



                        }

                    }

                    else
                    {
                        MessageBox.Show("Please Add the Field ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

                if (dgvPrintReport.Index == dgvPatientTest.Columns[e.ColumnIndex].Index)
                {
                    if (dgvPatientTest.Rows[e.RowIndex].Cells["dgvUniqueTestStatus"].Value.ToString() == "Complete")
                    {

                        string testID = dgvPatientTest.Rows[e.RowIndex].Cells["dgvtestID"].Value.ToString();



                        string patternSugar = @"BS";
                        string patternCellCount = @"BCC";
                        string patternPlatelets = @"PC";
                        string patternLipid = @"LC";

                        Match sugar = Regex.Match(testID, patternSugar);
                        Match cellCount = Regex.Match(testID, patternCellCount);
                        Match platelet = Regex.Match(testID, patternPlatelets);

                        Match Lipid = Regex.Match(testID, patternLipid);

                        if (sugar.Success || platelet.Success || cellCount.Success || Lipid.Success)
                        {
                            var view = new ViewForm(labpatient.ID, testID);
                            view.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Scan results printed seperately", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    else
                    {
                        MessageBox.Show("This test is not Complete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                //showHidePanels("Panel1", "Panel2", "Panel3", 1);
                clearDictionarys();
                fillPatientsTests(labpatient.getPatientsTestList());
            }
        }

       

        private void txtTest_Panel1_Leave(object sender, EventArgs e)
        {

            var panel = (Panel)grpBoxTextBoxSet.Controls["Panel1"];
            var Error_lbl = (Label)panel.Controls[txt_Panel1["Error_lbl"]];

            if (txt_Panel1["DType"] == "int")
            {
                if (validation.IsNumeric(txtTest_Panel1.Text) || string.IsNullOrEmpty(txtTest_Panel1.Text))
                {
                    if (txt_Panel1["Field"] == "WBC"  || txt_Panel1["Field"] == "Platelet Count" || txt_Panel1["Field"] == "Sugar" )
                    {
                        if ( string.IsNullOrEmpty(txtTest_Panel1.Text) || int.Parse(txtTest_Panel1.Text) > 0)
                        {
                            Error_lbl.Text = "";
                            txt_Panel1["Value"] = txtTest_Panel1.Text;
                        }
                        else
                        {
                            Error_lbl.Text = "*Count should be logical";
                            //txtTest_Panel1.Text = "";
                            txt_Panel1["Value"] = "";
                        }
                    }

                }
                else
                {
                    Error_lbl.Text = validation.NumericEror;
                    //txtTest_Panel1.Text = "";
                    txt_Panel1["Value"] = "";
                }
            }


            if (txt_Panel1["DType"] == "double")
            {
                if (validation.IsDouble(txtTest_Panel1.Text) || string.IsNullOrEmpty(txtTest_Panel1.Text))
                {
                    if (txt_Panel1["Field"] == "HDL" )
                    {
                        if (string.IsNullOrEmpty(txtTest_Panel1.Text) || double.Parse(txtTest_Panel1.Text) > 0 )
                        {
                            Error_lbl.Text = "";
                            txt_Panel1["Value"] = txtTest_Panel1.Text;
                        }
                        else
                        {
                            Error_lbl.Text = "*Value should be logical";
                            //txtTest_Panel1.Text = "";
                            txt_Panel1["Value"] = "";
                        }
                    }

                }
                else
                {
                    Error_lbl.Text = validation.NumericEror;
                    //txtTest_Panel1.Text = "";
                    txt_Panel1["Value"] = "";

                }
            }


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!labtest.Status)
            {
                var bloodtest = new BloodTest();
                

                if (txt_Panel1["Field"] == "Sugar")
                {
                    if (!bloodtest.insertSugar( labpatient.ID, labtest.ID, txt_Panel1["Value"]))
                    {
                        MessageBox.Show("Please Fill the Relevant Field", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtTest_Panel1.Text = "";
                        fillPatientsTests(labpatient.getPatientsTestList());
                        labtest.Status = true;
                    }

                }

                if (txt_Panel1["Field"] == "Platelet Count")
                {
                    if (!bloodtest.insertPlatelet(labpatient.ID, labtest.ID, txt_Panel1["Value"]))
                    {
                        MessageBox.Show("Please Fill the Relevant Field", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtTest_Panel1.Text = "";
                        fillPatientsTests(labpatient.getPatientsTestList());
                        labtest.Status = true;
                    }

                }


                if (txt_Panel1["Field"] == "WBC" && txt_Panel2["Field"] == "RBC")
                {
                    if (!bloodtest.insertCellCount(labpatient.ID, labtest.ID, txt_Panel1["Value"], txt_Panel2["Value"]))
                    {
                        MessageBox.Show("Please Fill the Relevant Field", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtTest_Panel1.Text = "";
                        txtTest_Panel2.Text = "";
                        fillPatientsTests(labpatient.getPatientsTestList());
                        labtest.Status = true;
                    }

                }

                if (txt_Panel1["Field"] == "HDL" && txt_Panel2["Field"] == "LDL" && txt_Panel3["Field"] == "Serum Cholesterol")
                {
                    var cholesterol = new LipidTest();

                    if (!cholesterol.insertCholestrolTest(labpatient.ID, labtest.ID, txt_Panel1["Value"], txt_Panel2["Value"],txt_Panel3["Value"]) )
                    {
                        MessageBox.Show("Please Fill the Relevant Field", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtTest_Panel1.Text = "";
                        txtTest_Panel2.Text = "";
                        txtTest_Panel3.Text = "";
                        fillPatientsTests(labpatient.getPatientsTestList());
                        labtest.Status = true;
                    }

                }

                if (grpBxScans.Visible)
                {
                    
                    var scan = new Scans();
                    if (radioSet.Checked)
                    {
                        if (scan.setScanStatus(Convert.ToInt32(labtest.LTRNumber), true, true))
                        {
                            radioSet.Checked = false;
                            radioReset.Checked = false;
                            fillPatientsTests(labpatient.getPatientsTestList());
                        }
                        

                    }

                    if (radioReset.Checked)
                    {
                        if(scan.setScanStatus(Convert.ToInt32(labtest.LTRNumber), false, true))
                        {
                            radioSet.Checked = false;
                            radioReset.Checked = false;
                            fillPatientsTests(labpatient.getPatientsTestList());
                        }
                        

                    }

                }

                //clearDictionarys();
                FillAppointments(null, null, null);

            }
            else
            {
                //txtTest_Panel1.Text = "";
                //labtest.Status = false;
                MessageBox.Show("This is already added. Select Update to Change", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTest_Panel2_Leave(object sender, EventArgs e)
        {

            var panel = (Panel)grpBoxTextBoxSet.Controls["Panel2"];
            var Error_lbl = (Label)panel.Controls[txt_Panel2["Error_lbl"]];

            if (txt_Panel2["DType"] == "int")
            {
                if (validation.IsNumeric(txtTest_Panel2.Text) || string.IsNullOrEmpty(txtTest_Panel2.Text))
                {
                    if (txt_Panel2["Field"] == "RBC" )
                    {
                        if (string.IsNullOrEmpty(txtTest_Panel2.Text) || int.Parse(txtTest_Panel2.Text) > 0 )
                        {
                            Error_lbl.Text = "";
                            txt_Panel2["Value"] = txtTest_Panel2.Text;
                        }
                        else
                        {
                            Error_lbl.Text = "*Count should be logical";
                            //txtTest_Panel1.Text = "";
                            txt_Panel2["Value"] = "";
                        }
                    }

                }
                else
                {
                    Error_lbl.Text = validation.NumericEror;
                    //txtTest_Panel1.Text = "";
                    txt_Panel2["Value"] = "";
                }
            }


            if (txt_Panel2["DType"] == "double")
            {
                if (validation.IsDouble(txtTest_Panel2.Text) || string.IsNullOrEmpty(txtTest_Panel2.Text))
                {
                    if (txt_Panel2["Field"] == "LDL")
                    {
                        if (string.IsNullOrEmpty(txtTest_Panel2.Text) || double.Parse(txtTest_Panel2.Text) > 0 )
                        {
                            Error_lbl.Text = "";
                            txt_Panel2["Value"] = txtTest_Panel2.Text;
                        }
                        else
                        {
                            Error_lbl.Text = "*Value should be logical";
                            //txtTest_Panel1.Text = "";
                            txt_Panel2["Value"] = "";
                        }
                    }

                }
                else
                {
                    Error_lbl.Text = validation.NumericEror;
                    //txtTest_Panel1.Text = "";
                    txt_Panel2["Value"] = "";

                }
            }



        }

        private void txtTest_Panel3_Leave(object sender, EventArgs e)
        {
            var panel = (Panel)grpBoxTextBoxSet.Controls["Panel3"];
            var Error_lbl = (Label)panel.Controls[txt_Panel3["Error_lbl"]];



            if (txt_Panel3["DType"] == "double")
            {
                if (validation.IsDouble(txtTest_Panel3.Text) || string.IsNullOrEmpty(txtTest_Panel3.Text))
                {
                    if (txt_Panel3["Field"] == "Serum Cholesterol")
                    {
                        if (string.IsNullOrEmpty(txtTest_Panel3.Text) || double.Parse(txtTest_Panel3.Text) > 0 )
                        {
                            Error_lbl.Text = "";
                            txt_Panel3["Value"] = txtTest_Panel3.Text;
                        }
                        else
                        {
                            Error_lbl.Text = "*Value should be logical";
                            //txtTest_Panel1.Text = "";
                            txt_Panel3["Value"] = "";
                        }
                    }

                }
                else
                {
                    Error_lbl.Text = validation.NumericEror;
                    //txtTest_Panel1.Text = "";
                    txt_Panel3["Value"] = "";
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (grpBxScans.Visible)
            {

                var scan = new Scans();


                if (radioReset.Checked)
                {
                    if (scan.setScanStatus(Convert.ToInt32(labtest.LTRNumber), false, true))
                    {
                        radioSet.Checked = false;
                        radioReset.Checked = false;
                        fillPatientsTests(labpatient.getPatientsTestList());
                    }


                }

            }


            var bloodtest = new BloodTest();


            if (txt_Panel1["Field"] == "Sugar")
            {
                if (!bloodtest.insertSugar(labpatient.ID, labtest.ID, txt_Panel1["Value"]))
                {
                    MessageBox.Show("Please Fill the Relevant Field", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    txtTest_Panel1.Text = "";
                    fillPatientsTests(labpatient.getPatientsTestList());
                    //labtest.Status = true;
                }

            }

            if (txt_Panel1["Field"] == "Platelet Count")
            {
                if (!bloodtest.insertPlatelet(labpatient.ID, labtest.ID, txt_Panel1["Value"]))
                {
                    MessageBox.Show("Please Fill the Relevant Field", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    txtTest_Panel1.Text = "";
                    fillPatientsTests(labpatient.getPatientsTestList());
                    //labtest.Status = true;
                }

            }


            if (txt_Panel1["Field"] == "WBC" && txt_Panel2["Field"] == "RBC")
            {
                if (!bloodtest.insertCellCount(labpatient.ID, labtest.ID, txt_Panel1["Value"], txt_Panel2["Value"]))
                {
                    MessageBox.Show("Please Fill the Relevant Field", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    txtTest_Panel1.Text = "";
                    txtTest_Panel2.Text = "";
                    fillPatientsTests(labpatient.getPatientsTestList());
                    //labtest.Status = true;
                }

            }

            if (txt_Panel1["Field"] == "HDL" && txt_Panel2["Field"] == "LDL" && txt_Panel3["Field"] == "Serum Cholesterol")
            {
                var cholesterol = new LipidTest();
                if(!cholesterol.updateCholesterolTest(labpatient.ID,  txt_Panel1["Value"], txt_Panel2["Value"], txt_Panel3["Value"]))
                {
                    MessageBox.Show("Please Fill the Relevant Field", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                else
                {
                    txtTest_Panel1.Text = "";
                    txtTest_Panel2.Text = "";
                    txtTest_Panel3.Text = "";
                    fillPatientsTests(labpatient.getPatientsTestList());
                    //labtest.Status = true;
                }

            }

            //clearDictionarys();
            FillAppointments(null, null, null);
        }

        private void btnPatientRegBack_Click(object sender, EventArgs e)
        {
            var labhome = new Form1();
            labhome.Show();
            Dispose();
        }
    }
}
