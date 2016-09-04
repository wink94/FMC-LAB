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
    public partial class apply_leaveHR : Form
    {
        public apply_leaveHR()
        {
            InitializeComponent();
        }

        static String strcon = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mscon = new MySqlConnection(strcon);

        public void autoGenerateID()
        {
            String leaveID = "LEAV";
            mscon.Open();
            MySqlCommand cmd = new MySqlCommand("select COUNT(Employee_ID) from itp.hr_registration", mscon);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            mscon.Close();

            txt_leave.Text = leaveID + i.ToString();
        }

        public void tableLoad()
        {

            MySqlCommand mcmd = new MySqlCommand("select * from itp.hr_registration", mscon);

            try
            {
                mscon.Open();
                MySqlDataAdapter mda = new MySqlDataAdapter();
                mda.SelectCommand = mcmd;
                DataTable dt = new DataTable();
                mda.Fill(dt);
                dgv_leave.DataSource = dt;

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
            mscon.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String query = "insert into itp.hr_leave (Leave_ID, Employee_ID, Leave_type, From_date, To_date, Remarks) values ('" + txt_leave.Text + "','" + txt_empID.Text + "','" + cmbx_leavTyp.Text + "','" + dtp_Fromdtw.Text + "','" + dtp_toDte.Text + "','" + txt_remarks.Text + "');";
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

        private void btn_updt_Click(object sender, EventArgs e)
        {

            String query = "update itp.itp.hr_leave set Leave_ID = '" + txt_empID.Text + "',Leave_ID= '" + txt_leave.Text + "',Leave_type = '" + cmbx_leavTyp.Text + "',From_date = '" + dtp_Fromdtw.Text + "', To_date = '" + dtp_toDte.Text + "', Remarks = '" + txt_remarks.Text + "';";
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
            String query = "delete from itp.itp.hr_leave  where Leave_ID = '" + txt_leave.Text + "';";
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            mainHR mhr = new mainHR();
            mhr.Show();
            this.Close();
        }

        private void txt_remarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
    
}
