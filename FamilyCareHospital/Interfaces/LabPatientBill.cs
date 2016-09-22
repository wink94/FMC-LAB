using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamilyCareHospital.Controllers;
using FamilyCareHospital.DBAccess;

namespace FamilyCareHospital.Interfaces
{
    public partial class LabPatientBill : Form
    {
        private LabPatient lp = new LabPatient();
        private LabAppointment la = new LabAppointment();
        private DBInsert dbi = new DBInsert();
        private DBRetrieve dbr = new DBRetrieve();
        private bool appState;
        private Dictionary<string, string> testList;
        
        public bool appoinmentStatus
        { get { return appState; } }
        

        //public LabPatientBill()
        //{
        //    InitializeComponent();

        //}
        public LabPatientBill(object lp1,object la1) //:this()
        {
            InitializeComponent();
            lp = (LabPatient)lp1;
            la = (LabAppointment)la1;
            //setPatientDetails();

        }

        private void setPatientDetails()
        {
            lblPAge.Text = lp.Age.ToString();
            lblPEmail.Text = lp.Email;
            lblPGender.Text = lp.Gender;
            lblPName.Text = lp.Name;
            lblPTele.Text = lp.Phone;
            lblPAppDate.Text = la.Adate;
        }

        private void createLabelsNAssignValues(Dictionary<string,string> dic)
        {
            int x1 = 26, x2 = 209;
            int y1 = 102;
            int depth = 0;
            foreach(string key in dic.Keys)
            {
                createLabel(x1, y1 + depth, key, 'g');
                createLabel(x2, y1 + depth, dic[key], 'A');
                depth += 40;
            }

        }

        void createLabel(int x,int y,string value,char color)
        {
            var lbl = new Label();
            lbl.Location = new Point(x, y);
            lbl.Text = value;
            if (color == 'A')
                lbl.BackColor = Color.Aqua;
            if (color == 'g')
                lbl.BackColor = Color.Gray;

            grpBxTestPrices.Controls.Add(lbl);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lp.insertLabPatient();

            string LPID=dbr.getRegisteredPatientID();  //get enterd labpatients id
           
            la.PID = LPID;
            la.insertLabAppointment();
            LabTest.insertTestListData(LPID, lp.tests.ToList());


            if (lp.PatientType == "Out")
                LabTest.insertLabPayment(LPID, lp.PatientType, testList["Total :"], true);
            else
                LabTest.insertLabPayment(LPID, lp.PatientType, testList["Total :"]);


            appState = true;
            this.Hide();

        }

        private void LabPatientBill_Load(object sender, EventArgs e)
        {
            
            //lblPAge.Text = lp.Age.ToString();
            setPatientDetails();
            testList=dbr.getTestPrices(lp.tests.ToList());
            createLabelsNAssignValues(testList);

        }
       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            appState = false;
            this.Dispose();
        }
    }
}
