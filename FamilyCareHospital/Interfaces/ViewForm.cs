﻿using FamilyCareHospital.Controllers;
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

            if (testid.ToString() == "LTBS001")
            {
                var bloodtest = new BloodTest();
                DataSet ds = bloodtest.fillSugarReport(PID.ToString());
                var sugar_report = new CrystalReportSugar();
                sugar_report.SetDataSource(ds);
                crystalReportViewerLabReport.ReportSource = sugar_report;
            }

            if (testid.ToString() == "LTBPC007")
            {
                var bloodtest = new BloodTest();
                DataSet ds = bloodtest.fillPlateletReport(PID.ToString());
                var platelet_report = new CrystalReportPlateletCount();
                platelet_report.SetDataSource(ds);
                crystalReportViewerLabReport.ReportSource = platelet_report;
            }

            if (testid.ToString() == "LTLC003")
            {
                var cholesterol_test = new LipidTest();
                DataSet ds = cholesterol_test.fillCholesterolReport(PID.ToString());
                var cholesterol_report = new CrystalReportCholesterolTest();
                cholesterol_report.SetDataSource(ds);
                crystalReportViewerLabReport.ReportSource = cholesterol_report;
            }

        }
    }
}
