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

namespace FamilyCareHospital
{
    public partial class loginHR : Form
    {
        public loginHR()
        {
            InitializeComponent();
        }

        string username;
        string position;

        static String strcon = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mscon = new MySqlConnection(strcon);

        private void btn_login_Click(object sender, EventArgs e)
        {
            username = txt_empID.Text;
            String query = "select * from itp.hr_registration  where Employee_ID = '" + txt_empID.Text + "' and Password ='" + txt_pass.Text+ "';";
            MySqlCommand cmd = new MySqlCommand(query, mscon);
            int count = 0;
            MySqlDataReader mr;
           
            try
            {
                mscon.Open();
                mr = cmd.ExecuteReader();

               
                while (mr.Read())
                {
                    count = count + 1;
                    
                }
                mscon.Close();
                if (count == 1) {

                    MessageBox.Show("Correct Username or Password");

                    String query1 = "select Position from itp.hr_registration  where Employee_ID = '" + txt_empID.Text + "';";
                    MySqlCommand cmd1 = new MySqlCommand(query1, mscon);


                    try
                    {
                        mscon.Open();
                        position = cmd1.ExecuteScalar().ToString();


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);

                    }
                   
                    if (position=="Admin")
                    {
                        Admin a = new Admin();
                        a.Show();
                        this.Hide();
                    }
                    else if(position=="Pharmacist")
                    {
                        

                    }
                    else if (position == "Ward Master")
                    {
                        Ward_MainFrame wf = new Ward_MainFrame(position);
                        wf.Show();
                        this.Hide();
                    }
                    else if (position == "Store Manager")
                    {
                        
                    }
                    else if (position == "Transport Manager")
                    {
                        
                    }
                    else if (position == "Receptionist")
                    {
                        OPDmain om = new OPDmain(position);
                        om.Show();
                        this.Hide();
                    }
                    else if (position == "Lab Manager")
                    {
                        Form1 lbm = new Form1(position);
                        lbm.Show();
                        this.Hide();
                    }
                    else if (position == "Chanelling Manager")
                    {
                        
                    }
                    else if (position == "HR Manager")
                    {
                        
                       
                    }

                }
                else {

                    MessageBox.Show("Incorrect Username or Password");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            mscon.Close();
        }
    }
}
