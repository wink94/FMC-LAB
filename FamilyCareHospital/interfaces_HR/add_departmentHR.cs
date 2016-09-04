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
    public partial class add_departmentHR : Form
    {
        public add_departmentHR()
        {
            InitializeComponent();
            autoGenerateID();
            tableLoad();
        }

        static String strcon = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mscon = new MySqlConnection(strcon);

        public void autoGenerateID()
        {
            String depID = "DEP";
            mscon.Open();
            MySqlCommand cmd = new MySqlCommand("select COUNT(Department_ID) from itp.hr_add_dept", mscon);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            mscon.Close();

            txt_dep_id.Text = depID + i.ToString();
        }

        public void tableLoad()
        {

            MySqlCommand mcmd = new MySqlCommand("select * from itp.hr_add_dept", mscon);

            try
            {
                mscon.Open();
                MySqlDataAdapter mda = new MySqlDataAdapter();
                mda.SelectCommand = mcmd;
                DataTable dt = new DataTable();
                mda.Fill(dt);
                dgv_dept.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mscon.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String query = "insert into itp.hr_add_dept (Department_ID, Department_Name) values ('" + txt_dep_id.Text + "','" + txt_dep_name.Text + "');";
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

        private void dgv_dept_MouseClick(object sender, MouseEventArgs e)
        {
            txt_dep_id.Text = dgv_dept.SelectedRows[0].Cells[0].Value.ToString();
            txt_dep_name.Text = dgv_dept.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_updt_Click(object sender, EventArgs e)
        {
            String query = "update itp.hr_add_dept set Department_Name = '" + txt_dep_name.Text + "' where Department_ID = '" + txt_dep_id.Text + "';";
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            String query = "delete from itp.hr_add_dept  where Department_ID = '" + txt_dep_id.Text + "';";
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
