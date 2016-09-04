using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FamilyCareHospital.interfaces_HR
{
    public partial class assign_workHR : Form
    {
        public assign_workHR()
        {
            InitializeComponent();
        }

        static String strcon = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mscon = new MySqlConnection(strcon);

        public void autoGenerateID()
        {
            String assignID = "ASGN";
            mscon.Open();
            MySqlCommand cmd = new MySqlCommand("select COUNT(Assignment_ID) from itp.hr_assignment", mscon);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            mscon.Close();

            txt_assign.Text = assignID + i.ToString();
        }

        public void tableLoad()
        {

            MySqlCommand mcmd = new MySqlCommand("select * from itp.hr_assignment", mscon);

            try
            {
                mscon.Open();
                MySqlDataAdapter mda = new MySqlDataAdapter();
                mda.SelectCommand = mcmd;
                DataTable dt = new DataTable();
                mda.Fill(dt);
                dgv_assignWork.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mscon.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String query = "insert into itp.hr_assignment (Assignment_ID, Employee_ID, Position, Department, Day, Day1_half1, Day1_half2, Day2_half1, Day2_half2) values ('" + txt_assign.Text + "','" + txt_emp_ID.Text + "','" + txt_position.Text + "','" + cmbx_dept.Text + "','" + cmbx_day.Text + "','" + dtp_day1half1.Text + "','" + dtp_day1half2.Text + "','" + dtp_day2half1.Text + "','" + dtp_day2half2.Text + "');";
            MySqlCommand cmd = new MySqlCommand(query, mscon);
            MySqlDataReader mr;

            try
            {
                mscon.Open();
                mr = cmd.ExecuteReader();

                MessageBox.Show("saved");
                while (mr.Read())
                {

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            mscon.Close();
            tableLoad();
            autoGenerateID();
        }

        private void dgv_assignWork_MouseClick(object sender, MouseEventArgs e)
        {
            txt_assign.Text = dgv_assignWork.SelectedRows[0].Cells[0].Value.ToString();
            txt_emp_ID.Text = dgv_assignWork.SelectedRows[0].Cells[1].Value.ToString();
            txt_position.Text = dgv_assignWork.SelectedRows[0].Cells[2].Value.ToString();
            cmbx_dept.Text = dgv_assignWork.SelectedRows[0].Cells[3].Value.ToString();
            cmbx_day.Text = dgv_assignWork.SelectedRows[0].Cells[4].Value.ToString();
            dtp_day1half1.Text = dgv_assignWork.SelectedRows[0].Cells[5].Value.ToString();
            dtp_day1half2.Text = dgv_assignWork.SelectedRows[0].Cells[6].Value.ToString();
            dtp_day2half1.Text = dgv_assignWork.SelectedRows[0].Cells[7].Value.ToString();
            dtp_day2half2.Text = dgv_assignWork.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void btn_updt_Click(object sender, EventArgs e)
        {
            String query = "update itp.hr_assignment set Assignment_ID = '" + txt_assign.Text + "',Employee_ID = '" + txt_emp_ID.Text + "',Position = '" + txt_position.Text + "',Department = '" + cmbx_dept.Text + "', Day = '" + cmbx_day.Text + "', Day1_half1 = '" + dtp_day1half1.Text + "', Day1_half2 = '" + dtp_day1half2.Text + "', Day2_half1 = '" + dtp_day2half1.Text + "', Day2_half2 = '" + dtp_day2half2.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, mscon);
            MySqlDataReader mr;

            try
            {
                mscon.Open();
                mr = cmd.ExecuteReader();

                MessageBox.Show("Updated");
                while (mr.Read())
                {

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            mscon.Close();
            tableLoad();
            autoGenerateID();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            String query = "delete from itp.hr_assignment  where Assignment_ID = '" + txt_assign.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, mscon);
            MySqlDataReader mr;

            try
            {
                mscon.Open();
                mr = cmd.ExecuteReader();

                MessageBox.Show("Deleted");
                while (mr.Read())
                {

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            mscon.Close();
            tableLoad();
            autoGenerateID();
        }

    }
}
