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
    public partial class DoctorRegistrationForm : Form
    {
        String gender;
        String day1, day2, day3, day4, day5, day6, day7;
        string DIDNO;

        static string mycon = "SERVER=localhost; DATABASE=itp; UID=root; PASSWORD=sagarox";
        MySqlConnection mc = new MySqlConnection(mycon);

        public DoctorRegistrationForm()
        {
            InitializeComponent();
            tableLoad();
            label11.Text = ""; label14.Text = ""; label15.Text = ""; label16.Text = ""; label17.Text = ""; label18.Text = "";
            label19.Text = ""; label20.Text = "";label21.Text = ""; label22.Text = ""; label23.Text = "";
        }

       
        public void tableLoad()
        {
           
            try
            {
                String qry = "select DID,Name, DcReNo,Speciality,Gender,Birthday,Phone,Email,Patintlim,Description,ConsltFee,HospCharges,Monday,Tuesday,Wendesday,Thursday,Friday,Saturday,Sunday from doctorinfo";
                MySqlDataAdapter ad = new MySqlDataAdapter(qry, mycon);
                DataTable tb = new DataTable();
                ad.Fill(tb);
                dataGridView1.DataSource = tb;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String qury;
            
            try
            {
                validation validation = new validation();
                if (validation.textisEmpty(nametxt, label11) & validation.textisEmpty(drntxt, label14) & validation.comboisEmpty(specmbo, label15) & validation.TworadiobuttonisEmpty(maleradio, femaleradio, label16) & validation.textisEmpty(patlimtxt7, label20) & validation.textisEmpty(phnetxt, label18) & validation.textisEmpty(cnfeetxt, label21) & validation.textisEmpty(hospchatxt, label22) &
                    validation.DaysradiobuttonisEmpty(radioButton3, radioButton4, radioButton5, radioButton6, radioButton7, radioButton8, radioButton9, radioButton10, radioButton11, radioButton12, radioButton13, radioButton14, radioButton15, radioButton16, radioButton17, radioButton18, radioButton19, radioButton20, radioButton21, radioButton22, radioButton23, label23) == true)
                {
      
                    if (validation.alphaVal(nametxt.Text, label11) & validation.numberVal(phnetxt.Text, label18) & validation.emailVal(emailtxt.Text, label19) & validation.IsNumeric(drntxt.Text, label14) & validation.patientLimit(patlimtxt7.Text, label20) && validation.IsNumeric(cnfeetxt.Text, label21) & validation.IsNumeric(hospchatxt.Text, label22) == true)
                    {
                        mc.Open();
                        qury = "insert into doctorinfo(Name, DcReNo,Speciality,Gender,Birthday,Phone,Email,Patintlim,Description,ConsltFee,HospCharges,Monday,Tuesday,Wendesday,Thursday,Friday,Saturday,Sunday) values('" + nametxt.Text + "', '" + drntxt.Text + "','" + specmbo.Text + "','" + gender + "','" + birthdtpickr.Text + "','" + phnetxt.Text + "','" + emailtxt.Text + "','" + patlimtxt7.Text + "','" + descriptxt.Text + "','" + cnfeetxt.Text + "','" + hospchatxt.Text + "','" + day1 + "','" + day2 + "','" + day3 + "','" + day4 + "','" + day5 + "','" + day6 + "','" + day7 + "')";
                        MySqlCommand cmd = new MySqlCommand(qury, mc);
                        cmd.ExecuteNonQuery();
                        tableLoad();
                        MessageBox.Show("Inserted successfully!");
                        mc.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Entry!");
                    }
                }

                else
                {
                    MessageBox.Show("Mandatory Fields!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nametxt.Clear();
            drntxt.Clear();
            specmbo.Text = "";
            phnetxt.Clear();
            emailtxt.Clear();
            patlimtxt7.Clear();
            descriptxt.Clear();
            cnfeetxt.Clear();
            hospchatxt.Clear();

            if (maleradio.Checked == true | femaleradio.Checked == true)
            {
                maleradio.Checked = false;
                femaleradio.Checked = false;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String qury1;
            try
            {
                if (MessageBox.Show("Do you want to update changes?", "update changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mc.Open();
                    qury1 = "update doctorinfo set Name='" + nametxt.Text + "', DcReNo='" + drntxt.Text + "',Speciality='" + specmbo.Text + "',Birthday='" + birthdtpickr.Text + "',Phone='" + phnetxt.Text + "',Email='" + emailtxt.Text + "',Patintlim='" + patlimtxt7.Text + "',Description='" + descriptxt.Text + "',Gender='" + gender + "',ConsltFee='" + cnfeetxt.Text + "',HospCharges='" + hospchatxt.Text + "',Monday='" + day1 + "' where DID='" + DIDNO + "' ";
                    MySqlCommand cmd = new MySqlCommand(qury1, mc);
                    cmd.ExecuteNonQuery();
                    tableLoad();
                    MessageBox.Show("Updated successfully!");
                    mc.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            String qury2;
            try
            {
                if (MessageBox.Show("Do you want to delete this?", "Deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mc.Open();
                    qury2 = "delete from doctorinfo where DID='" + DIDNO + "'";
                    MySqlCommand cmd = new MySqlCommand(qury2, mc);
                    cmd.ExecuteNonQuery();
                    tableLoad();
                    MessageBox.Show("Deleted successfully!");
                    mc.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {

            if (radioButton3.Checked == true | radioButton4.Checked == true | radioButton5.Checked == true | radioButton6.Checked == true | radioButton7.Checked == true | radioButton8.Checked == true | radioButton9.Checked == true
                | radioButton10.Checked == true | radioButton11.Checked == true | radioButton12.Checked == true | radioButton13.Checked == true | radioButton14.Checked == true | radioButton15.Checked == true | radioButton16.Checked == true
                | radioButton17.Checked == true | radioButton18.Checked == true | radioButton19.Checked == true | radioButton20.Checked == true | radioButton21.Checked == true | radioButton22.Checked == true | radioButton23.Checked == true)
            {
                radioButton3.Checked = false; radioButton4.Checked = false; radioButton5.Checked = false; radioButton6.Checked = false; radioButton7.Checked = false; radioButton8.Checked = false; radioButton9.Checked = false;
                radioButton10.Checked = false; radioButton11.Checked = false; radioButton12.Checked = false; radioButton13.Checked = false; radioButton14.Checked = false; radioButton15.Checked = false; radioButton16.Checked = false;
                radioButton17.Checked = false; radioButton18.Checked = false; radioButton19.Checked = false; radioButton20.Checked = false; radioButton21.Checked = false; radioButton22.Checked = false; radioButton23.Checked = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DoctorMain dm = new DoctorMain();
            this.Hide();
            dm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*Admin ad = new Admin();
            this.Hide();
            ad.ShowDialog();*/
        }


        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DIDNO = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nametxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            drntxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            specmbo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            gender = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            //MessageBox.Show("grndr"+gender);
            if (gender == "Male")
                maleradio.Checked = true;
            else
                femaleradio.Checked = true;
            birthdtpickr.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            phnetxt.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            emailtxt.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            patlimtxt7.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            descriptxt.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            cnfeetxt.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            hospchatxt.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            day1 = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            day2 = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            day3 = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            day4 = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
            day5 = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
            day6 = dataGridView1.SelectedRows[0].Cells[17].Value.ToString();
            day7 = dataGridView1.SelectedRows[0].Cells[18].Value.ToString();
            if (day1 == "Morning") { radioButton3.Checked = true; } else if (day1 == "Evening") { radioButton4.Checked = true; } else if (day1 == "Night") { radioButton5.Checked = true; }
            if (day2 == "Morning") { radioButton8.Checked = true; } else if (day2 == "Evening") { radioButton7.Checked = true; } else if (day2 == "Night") { radioButton6.Checked = true; }
            if (day3 == "Morning") { radioButton11.Checked = true; } else if (day3 == "Evening") { radioButton10.Checked = true; } else if (day3 == "Night") { radioButton9.Checked = true; }
            if (day4 == "Morning") { radioButton14.Checked = true; } else if (day4 == "Evening") { radioButton13.Checked = true; } else if (day4 == "Night") { radioButton12.Checked = true; }
            if (day5 == "Morning") { radioButton17.Checked = true; } else if (day5 == "Evening") { radioButton16.Checked = true; } else if (day5 == "Night") { radioButton15.Checked = true; }
            if (day6 == "Morning") { radioButton20.Checked = true; } else if (day6 == "Evening") { radioButton19.Checked = true; } else if (day6 == "Night") { radioButton18.Checked = true; }
            if (day7 == "Morning") { radioButton23.Checked = true; } else if (day7 == "Evening") { radioButton22.Checked = true; } else if (day7 == "Night") { radioButton21.Checked = true; }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            day2 = "Morning";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            day2 = "Evening";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            day2 = "Night";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            day3 = "Morning";
        }
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            day3 = "Evening";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            day3 = "Night";
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            day4 = "Morning";
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            day4 = "Evening";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            day4 = "Night";
        }
        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            day5 = "Morning";
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            day5 = "Evening";
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            day5 = "Night";
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            day6 = "Morning";
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            day6 = "Evening";
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            day6 = "Night";
        }
        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            day7 = "Morning";
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            day7 = "Evening";
        }

        private void DoctorRegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            day7 = "Night";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            day1 = "Morning";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            day1 = "Evening";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            day1 = "Night";
        }
    }
}
