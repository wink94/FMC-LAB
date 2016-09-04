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
    public partial class registrationHR : Form
    {
        public registrationHR()
        {
            InitializeComponent();
            tableLoad();
            autoGenerateID();
            fillCombo();
            
        }

        static String strcon = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mscon = new MySqlConnection(strcon);

        public void autoGenerateID()
        {
            String empID = "EMP";
            mscon.Open();
            MySqlCommand cmd = new MySqlCommand("select COUNT(Employee_ID) from itp.hr_registration", mscon);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            mscon.Close();

            txt_emp_id.Text = empID + i.ToString();
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
                dgv_regEmp.DataSource = dt;

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
            mscon.Close();
        }

 

        private void btn_add_Click(object sender, EventArgs e)
        {
            String query = "insert into itp.hr_registration (Employee_ID, Password, Department, DOB, Name, Gender, Address, Marital_Status, Contact_Num, Emerg_Contact_Name, Emerg_Contact_Relation, Emerg_Contact_Num, Annual_Leave, Casual_Leave, Half_Day, Short_Leave, Joined_Date, Qualification, Position) values ('" + txt_emp_id.Text + "','" + txt_pw.Text + "','" + cmbx_dept.Text + "','" + dtp_dob.Text + "','" + txt_name.Text + "','" + cmbx_gendr.Text + "','" + txt_addr.Text + "','" + cmbx_marry.Text + "','" + txt_contct.Text + "','" + txt_emerg_name.Text + "','" + txt_emerg_relation.Text + "','" + txt_emerg_contct.Text + "','" + txt_annualLv.Text + "','" + txt_cashLv.Text + "','" + txt_halfDy.Text + "','" + txt_shortLv.Text + "','" + dtp_joinedDate.Text + "','"+ txt_qualif.Text +"','"+ txt_position.Text +"');";
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
            txt_pw.Clear();
            txt_name.Clear();
            txt_addr.Clear();
            txt_contct.Clear();
            txt_emerg_name.Clear();
            txt_emerg_relation.Clear();
            txt_emerg_contct.Clear();
            txt_annualLv.Clear();
            txt_cashLv.Clear();
            txt_halfDy.Clear();
            txt_shortLv.Clear();
            txt_qualif.Clear();
            txt_position.Clear();
            tableLoad();
            autoGenerateID();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_emp_id.Text = dgv_regEmp.SelectedRows[0].Cells[0].Value.ToString();
            txt_pw.Text = dgv_regEmp.SelectedRows[0].Cells[1].Value.ToString();
            cmbx_dept.Text = dgv_regEmp.SelectedRows[0].Cells[2].Value.ToString();
            dtp_dob.Text = dgv_regEmp.SelectedRows[0].Cells[3].Value.ToString();
            txt_name.Text = dgv_regEmp.SelectedRows[0].Cells[4].Value.ToString();
            cmbx_gendr.Text = dgv_regEmp.SelectedRows[0].Cells[5].Value.ToString();
            txt_addr.Text = dgv_regEmp.SelectedRows[0].Cells[6].Value.ToString();
            cmbx_marry.Text = dgv_regEmp.SelectedRows[0].Cells[7].Value.ToString();
            txt_contct.Text = dgv_regEmp.SelectedRows[0].Cells[8].Value.ToString();
            txt_emerg_name.Text = dgv_regEmp.SelectedRows[0].Cells[9].Value.ToString();
            txt_emerg_relation.Text = dgv_regEmp.SelectedRows[0].Cells[10].Value.ToString();
            txt_emerg_contct.Text = dgv_regEmp.SelectedRows[0].Cells[11].Value.ToString();
            txt_annualLv.Text = dgv_regEmp.SelectedRows[0].Cells[12].Value.ToString();
            txt_cashLv.Text = dgv_regEmp.SelectedRows[0].Cells[13].Value.ToString();
            txt_halfDy.Text = dgv_regEmp.SelectedRows[0].Cells[14].Value.ToString();
            txt_shortLv.Text = dgv_regEmp.SelectedRows[0].Cells[15].Value.ToString();
            dtp_joinedDate.Text = dgv_regEmp.SelectedRows[0].Cells[16].Value.ToString();
            txt_qualif.Text = dgv_regEmp.SelectedRows[0].Cells[17].Value.ToString();
            txt_position.Text = dgv_regEmp.SelectedRows[0].Cells[18].Value.ToString();

        }

        private void btn_updt_Click(object sender, EventArgs e)
        {
            String query = "update itp.hr_registration set Name = '" + txt_name.Text + "',DOB = '" + dtp_dob.Text + "',Department = '"+ cmbx_dept.Text+"',Joined_Date = '" + dtp_joinedDate.Text + "',Gender = '" + cmbx_gendr.Text + "', Address = '" + txt_addr.Text + "', Marital_Status = '" + cmbx_marry.Text + "', Contact_Num = '" + txt_contct.Text + "', Emerg_Contact_Name = '" + txt_emerg_name.Text + "', Emerg_Contact_Relation = '" + txt_emerg_relation.Text + "', Emerg_Contact_Num = '" + txt_emerg_contct.Text + "', Annual_Leave = '" + txt_annualLv.Text + "', Casual_Leave = '" + txt_cashLv.Text + "', Half_Day = '" + txt_halfDy.Text + "', Short_Leave = '" + txt_shortLv.Text + "', Qualification = '" + txt_qualif.Text + "', Position = '" + txt_position.Text + "' where Employee_ID = '"+txt_emp_id.Text+"';";
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
            txt_pw.Clear();
            txt_name.Clear();
            txt_addr.Clear();
            txt_contct.Clear();
            txt_emerg_name.Clear();
            txt_emerg_relation.Clear();
            txt_emerg_contct.Clear();
            txt_annualLv.Clear();
            txt_cashLv.Clear();
            txt_halfDy.Clear();
            txt_shortLv.Clear();
            txt_qualif.Clear();
            txt_position.Clear();

            tableLoad();
            autoGenerateID();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            String query = "delete from itp.hr_registration  where Employee_ID = '" + txt_emp_id.Text + "';";
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
            txt_pw.Clear();
            txt_name.Clear();
            txt_addr.Clear();
            txt_contct.Clear();
            txt_emerg_name.Clear();
            txt_emerg_relation.Clear();
            txt_emerg_contct.Clear();
            txt_annualLv.Clear();
            txt_cashLv.Clear();
            txt_halfDy.Clear();
            txt_shortLv.Clear();
            txt_qualif.Clear();
            txt_position.Clear();

            tableLoad();
            autoGenerateID();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            String searchType = cmbx_chooseTyp.Text;
            String searchKey = txt_search.Text;

            if (searchType != "select" && searchType != "")
            {

                if (searchKey != "")
                {

                    if (searchType == "Employee ID")
                    {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.hr_registration where Employee_ID = '" + searchKey + "'", mscon);

                        try
                        {
                            mscon.Open();
                            MySqlDataAdapter mda = new MySqlDataAdapter();
                            mda.SelectCommand = mcmd;
                            DataTable dt = new DataTable();
                            mda.Fill(dt);

                            dgv_regEmp.DataSource = dt;

                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        mscon.Close();

                    }

                    else if (searchType == "Employee name")
                    {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.hr_registration where Name = '" + searchKey + "'", mscon);

                        try
                        {
                            mscon.Open();
                            MySqlDataAdapter mda = new MySqlDataAdapter();
                            mda.SelectCommand = mcmd;
                            DataTable dt = new DataTable();
                            mda.Fill(dt);

                            dgv_regEmp.DataSource = dt;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        mscon.Close();

                    }

                    else
                    {
                        MessageBox.Show("invalid Search Type");
                    }

                }
                else
                {
                    MessageBox.Show("Please Enter Keyword ");
                }

            }
            else
            {
                MessageBox.Show("Please select type");
            }
        }

        public void fillCombo()
        {
            String query = "select * from itp.hr_add_dept; ";
            MySqlCommand cmd = new MySqlCommand(query, mscon);
            MySqlDataReader mr;

            try
            {
                mscon.Open();
                mr = cmd.ExecuteReader();


                while (mr.Read())
                {
                    string com = mr.GetString("Department_Name");
                    cmbx_dept.Items.Add(com);
                    cmbx_deptVw.Items.Add(com);
                }

            }

            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);

            }
            mscon.Close();

        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_addr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == ' ' || e.KeyChar=='/'|| e.KeyChar ==','  || e.KeyChar == '.' || e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_contct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txt_emerg_name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_emerg_relation_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_emerg_contct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txt_annualLv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txt_cashLv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txt_halfDy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txt_shortLv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btn_vwall_Click(object sender, EventArgs e)
        {
            tableLoad();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            String cat = cmbx_deptVw.Text;
            if (cat != "select" && cat != "")
            {

                MySqlCommand mcmd = new MySqlCommand("select * from itp.hr_registration where Department = '" + cat + "'", mscon);

                try
                {
                    mscon.Open();
                    MySqlDataAdapter mda = new MySqlDataAdapter();
                    mda.SelectCommand = mcmd;
                    DataTable dt = new DataTable();
                    mda.Fill(dt);
                    dgv_regEmp.DataSource = dt;




                }
                catch (Exception ex)
                {


                    MessageBox.Show(ex.Message);
                }
                mscon.Close();
            }

            else
            {

                MessageBox.Show("Please select Category");
            }
        }
    }
}