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
    public partial class ManageTest : Form
    {
        private DBRetrieve dbr = new DBRetrieve();
        private DBUpdate dbu = new DBUpdate();
        private LabTest labtest = new LabTest();

        public ManageTest()
        {
            InitializeComponent();
        }

        private void ManageTest_Load(object sender, EventArgs e)
        {
            FillTest();
        }

        /*  fill test details  */

        private void FillTest()
        {

            DataSet ds = dbr.getLabTest();
            dgvTests.DataSource = ds.Tables["labtests"].DefaultView;
            
        }

        private void FillSearchTest(string test)
        {
            try
            {
                DataSet ds = dbr.getSearcehdLabTest(test);
                dgvTests.DataSource = ds.Tables["searchtests"].DefaultView;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txtTestSearch_TextChanged(object sender, EventArgs e)
        {
            FillSearchTest(txtTestSearch.Text);
        }


        private void getGridData(int rowid)
        {

            string testID,testName,testPrice;
            
            testID = dgvTests.Rows[rowid].Cells["dgvTestID"].Value.ToString();
            testName = dgvTests.Rows[rowid].Cells["dgvTestName"].Value.ToString();
            testPrice = dgvTests.Rows[rowid].Cells["dgvTestPrice"].Value.ToString();


            labtest.setUpdateTest(testID,testName,Convert.ToDouble(testPrice));
            
            
        }

        private void fillTestData()
        {
            lblTestID.Text = labtest.ID;
            txtTestName.Text = labtest.Name;
            txtTestPrice.Text = labtest.Price.ToString();
        }

        private void emptyFields()
        {
            lblTestID.Text = "";
            txtTestName.Text = "";
            txtTestPrice.Text = "";
        }

        private void dgvTests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 )
                return;
            else if (e.ColumnIndex==dgvDel.Index)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Delete Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    getGridData(e.RowIndex);
                    fillTestData();
                    labtest.removeTest();
                    emptyFields();
                    FillTest();
                }
                else if (dialogResult == DialogResult.No)
                {
                    emptyFields();
                }
            }
            else
            {
                getGridData(e.RowIndex);
                fillTestData();
            }
        }

        /* assogn error msg to labels */
        private void assignMessagesToLabels(string lbl, string msg, string container)
        {
            if (container != null && lbl !=null)
            {
                //var cont=(GroupBox)Controls[container]; not work ????
                Label label;

                if (container == "grpBoxTestUpdate")
                {
                    label = (Label)grpBoxTestUpdate.Controls[lbl];

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

        private bool fieldCheck(string value, string field = null, string field_lbl = null, string pic_lbl = null, string container = null)
        {
            Validation validation = new Validation();

            if (validation.checkFieldIsSet(value) )
            {
                assignMessagesToLabels(pic_lbl, "err_pic_remove", container);

                if (field == "testname" )
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

                else
                {
                    if (validation.IsNumeric(value) )
                    {
                        assignMessagesToLabels(field_lbl, validation.NumericEror, container);

                        int price = Convert.ToInt32(value);
                        if (price < 0)
                        {
                            assignMessagesToLabels(field_lbl, "*price should be non negative", container);
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

            }

            else
            {
                assignMessagesToLabels(field_lbl, "clear", container);
                assignMessagesToLabels(pic_lbl, "err_pic", container);
                return false;
            }

        }


        private void updateConfirm()
        {
            string tstName = txtTestName.Text, tstPrice = txtTestPrice.Text;
            int updateFlag;

            Validation vali = new Validation();

            if (tstName != labtest.Name && tstPrice != labtest.Price.ToString() && fieldCheck(tstPrice, " test price", "lblTestPriceErr", "lblTestPricePicErr", "grpBoxTestUpdate") & fieldCheck(tstName, "testname", "lblTestNameErr", "lblTestNamePicErr", "grpBoxTestUpdate"))
            {
                labtest.Name = tstName;
                labtest.Price = Convert.ToDouble(tstPrice);
                updateFlag = 3;
            }
            else if (tstName != labtest.Name && fieldCheck(tstPrice, " test price", "lblTestPriceErr", "lblTestPricePicErr", "grpBoxTestUpdate") & fieldCheck(tstName, "testname", "lblTestNameErr", "lblTestNamePicErr", "grpBoxTestUpdate"))
            {
                labtest.Name = tstName;
                updateFlag = 1;
            }
            else if (tstPrice != labtest.Price.ToString() && fieldCheck(tstPrice, " test price", "lblTestPriceErr", "lblTestPricePicErr", "grpBoxTestUpdate") & fieldCheck(tstName, "testname", "lblTestNameErr", "lblTestNamePicErr", "grpBoxTestUpdate"))
            {
                labtest.Price = Convert.ToDouble(tstPrice);
                updateFlag = 2;
            }
            else
            {
                //vali.printError(true);
                //MessageBox.Show("please select a field ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateFlag = 0;
            }

            if (updateFlag > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update?", "Update Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    labtest.updateTest(updateFlag);
                }
                else if (dialogResult == DialogResult.No)
                {
                    emptyFields();
                }
            }

        }

        private void btnUpdateTest_Click(object sender, EventArgs e)
        {
            updateConfirm();
            FillTest();
        }

        private void btnManageTestBack_Click(object sender, EventArgs e)
        {
            Form1 labHome=new Form1();
            labHome.Show();
            this.Dispose();
        }
    }
}
