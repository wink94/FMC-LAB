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

        public TestDetailsEntry()
        {
            InitializeComponent();

            dbr = new DBRetrieve();
        }

        private void TestDetailsEntry_Load(object sender, EventArgs e)
        {
            FillAppointments(null,null,null);
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

        private void dgvPatientTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvAppointmentList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            else
            {
                labpatient = new LabPatient();
                labpatient.ID = dgvAppointmentList.Rows[e.RowIndex].Cells["dgvPatientID"].Value.ToString();
                fillPatientsTests(labpatient.getPatientsTestList());
            }
        }
    }
}
