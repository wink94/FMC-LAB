using FamilyCareHospital.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyCareHospital.Interfaces
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        public ViewForm(object PID,object testid)
        {
            InitializeComponent();

            if(testid.ToString()== "LTBCC002")
            {
                var bloodtest = new BloodTest();
                DataSet ds = bloodtest.fillCellcountReport(PID.ToString());
                var cellcount_report = new CrystalReportCellCount();
                cellcount_report.SetDataSource(ds);
                crystalReportViewerLabReport.ReportSource = cellcount_report;
            }

        }
    }
}
