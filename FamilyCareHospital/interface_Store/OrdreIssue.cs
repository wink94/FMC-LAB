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
    public partial class OrdreIssue : Form
    {
        public OrdreIssue()
        {
            InitializeComponent();
            autoGenerateID();
            autocomplete();
            tableload();
            fillCombo();
        }

        static String conn = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mc = new MySqlConnection(conn);

        public void autoGenerateID()
        {
            String McID = "MIO";
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("select COUNT(distinct Issue_Order_ID) from itp.store_issueorder_m", mc);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            mc.Close();

            txt_iorderid.Text = McID + i.ToString();
        }

        public void autocomplete()
        {

            txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

            String query = "select * from itp.store_item;";
            MySqlCommand cmd = new MySqlCommand(query, mc);
            MySqlDataReader mr;

            try
            {

                mc.Open();
                mr = cmd.ExecuteReader();

                while (mr.Read())
                {
                    String cn = mr.GetString("Name");
                    acol.Add(cn);
                    


                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);

            }
            txt_search.AutoCompleteCustomSource = acol;
            mc.Close();


        }

        DataTable table = new DataTable();

        public void tableload()
        {
            table.Columns.Add("Issue Order ID",typeof(string));
            table.Columns.Add("Department", typeof(string));
            table.Columns.Add("Entry Date", typeof(string));
            table.Columns.Add("Item ID", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Batch Number", typeof(string));
            table.Columns.Add("Expier Date", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Unit Price", typeof(float));

            dataGridView2.DataSource = table;
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text != "")
            {
                MySqlCommand mcmd = new MySqlCommand("select ItemID,Name,Batch_Number,Expier_Date,Quantity,Unit_Price from itp.store_item where Name = '" + txt_search.Text + "'", mc);

                try
                {
                    mc.Open();
                    MySqlDataAdapter mda = new MySqlDataAdapter();
                    mda.SelectCommand = mcmd;
                    DataTable dt = new DataTable();
                    mda.Fill(dt);
                    //  BindingSource bs = new BindingSource();
                    // bs.DataSource = dt;
                    dataGridView1.DataSource = dt;
                    // mda.Update(dt);



                }
                catch (Exception ex)
                {


                    MessageBox.Show(ex.Message);
                }
                mc.Close();
            }
            else
            {
                MessageBox.Show("please enter keyword");

            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_iID.Text          = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_name.Text         = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_bn.Text           = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker1.Text  = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txt_qn.Text           = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txt_un.Text           = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "select" && comboBox1.Text != "") {

                if (txt_iID.Text != "" && txt_bn.Text != "" && txt_qn.Text !="" && txt_name.Text != "") {

                    mc.Open();
                    MySqlCommand cmd = new MySqlCommand("select Quantity from itp.store_item where ItemID = '" + txt_iID.Text + "' and Batch_Number = '" + txt_bn.Text + "' and Expier_Date = '" + dateTimePicker1.Text + "'  ", mc);
                    int q = Convert.ToInt32(cmd.ExecuteScalar());
                    mc.Close();
                    int qs = Convert.ToInt32(txt_qn.Text);

                    int answer = q - qs;

                    if (answer >= 0) {

                        String qn = Convert.ToString(answer);

                        String query = "update itp.store_item set Quantity = '" + qn + "' where ItemID = '" + txt_iID.Text + "' and Batch_Number = '" + txt_bn.Text + "' and Expier_Date = '" + dateTimePicker1.Text + "' ;";
                        MySqlCommand cmd2 = new MySqlCommand(query, mc);
                        MySqlDataReader mr;

                        try
                        {
                            mc.Open();
                            mr = cmd2.ExecuteReader();


                            while (mr.Read())
                            {

                            }


                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);

                        }

                        mc.Close();

                        table.Rows.Add(txt_iorderid.Text, comboBox1.Text, dateTimePicker2.Text, txt_iID.Text, txt_name.Text, txt_bn.Text, dateTimePicker1.Text, txt_qn.Text, txt_un.Text);
                        dataGridView2.DataSource = table;

                        MySqlCommand mcmd = new MySqlCommand("select ItemID,Name,Batch_Number,Expier_Date,Quantity,Unit_Price from itp.store_item where ItemID = '" + txt_iID.Text + "' and Batch_Number = '" + txt_bn.Text + "' and Expier_Date = '" + dateTimePicker1.Text + "'", mc);

                        try
                        {
                            mc.Open();
                            MySqlDataAdapter mda = new MySqlDataAdapter();
                            mda.SelectCommand = mcmd;
                            DataTable dt = new DataTable();
                            mda.Fill(dt);
                            //  BindingSource bs = new BindingSource();
                            // bs.DataSource = dt;
                            dataGridView1.DataSource = dt;
                            // mda.Update(dt);



                        }
                        catch (Exception ex)
                        {


                            MessageBox.Show(ex.Message);
                        }
                        mc.Close();


                    } else {

                        MessageBox.Show("insufficient Quantity");

                    }
                }
                else {

                    MessageBox.Show("invalid details");

                }
                
            }
            else {

                MessageBox.Show("please Select Department");
            }
            txt_iID.Clear();
            txt_name.Clear();
            txt_bn.Clear();
            txt_qn.Clear();
            txt_un.Clear();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            
            if (dataGridView2.SelectedRows.Count>0)
            {

                String iorderid = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                String dept = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                String endate = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                String iID = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                String name = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                String bn = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                String exdate = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
                String qnt = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
                String un = dataGridView2.SelectedRows[0].Cells[8].Value.ToString();

                if (iID != "" && bn != "" && qnt != "")
                {

                    mc.Open();
                    MySqlCommand cmd = new MySqlCommand("select Quantity from itp.store_item where ItemID = '" + iID + "' and Batch_Number = '" + bn + "' and Expier_Date = '" + exdate + "'  ", mc);
                    int q = Convert.ToInt32(cmd.ExecuteScalar());
                    mc.Close();
                    int qs = Convert.ToInt32(qnt);

                    int answer = q + qs;

                    String qn = Convert.ToString(answer);

                    String query = "update itp.store_item set Quantity = '" + qn + "' where ItemID = '" + iID + "' and Batch_Number = '" + bn + "' and Expier_Date = '" + exdate + "' ;";
                    MySqlCommand cmd2 = new MySqlCommand(query, mc);
                    MySqlDataReader mr;

                    try
                    {
                        mc.Open();
                        mr = cmd2.ExecuteReader();


                        while (mr.Read())
                        {

                        }


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);

                    }

                    mc.Close();

                    int rowIndex = dataGridView2.CurrentCell.RowIndex;

                    dataGridView2.Rows.RemoveAt(rowIndex);

                    MySqlCommand mcmd = new MySqlCommand("select ItemID,Name,Batch_Number,Expier_Date,Quantity,Unit_Price from itp.store_item where ItemID = '" + iID + "' and Batch_Number = '" + bn + "' and Expier_Date = '" + exdate + "'", mc);

                    try
                    {
                        mc.Open();
                        MySqlDataAdapter mda = new MySqlDataAdapter();
                        mda.SelectCommand = mcmd;
                        DataTable dt = new DataTable();
                        mda.Fill(dt);
                        //  BindingSource bs = new BindingSource();
                        // bs.DataSource = dt;
                        dataGridView1.DataSource = dt;
                        // mda.Update(dt);



                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show(ex.Message);
                    }
                    mc.Close();

                }
                else
                {

                    MessageBox.Show("Invalid Details");

                }
            }
            else {

                MessageBox.Show("please select row");

            }
            txt_iID.Clear();
            txt_name.Clear();
            txt_bn.Clear();
            txt_qn.Clear();
            txt_un.Clear();
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
        
        }

        private void btn_NO_Click(object sender, EventArgs e)
        {
            autoGenerateID();
        }

        private void btn_issue_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Do you want to issue ?", "Issue", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    mc.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into itp.store_issueorder_m (Issue_Order_ID,Department,Entry_Date,ItemID,Name,Batch_Number,Expier_Date,Quantity,Unit_price) values(@Issue_Order_ID,@Department,@Entry_Date,@ItemID,@Name,@Batch_Number,@Expier_Date,@Quantity,@Unit_price)", mc);
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {



                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@issue_order_id", dataGridView2.Rows[i].Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@Department", dataGridView2.Rows[i].Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@Entry_Date", dataGridView2.Rows[i].Cells[2].Value.ToString());
                        cmd.Parameters.AddWithValue("@ItemID", dataGridView2.Rows[i].Cells[3].Value.ToString());
                        cmd.Parameters.AddWithValue("@Name", dataGridView2.Rows[i].Cells[4].Value.ToString());
                        cmd.Parameters.AddWithValue("@Batch_Number", dataGridView2.Rows[i].Cells[5].Value.ToString());
                        cmd.Parameters.AddWithValue("@Expier_Date", dataGridView2.Rows[i].Cells[6].Value.ToString());
                        cmd.Parameters.AddWithValue("@Quantity", dataGridView2.Rows[i].Cells[7].Value.ToString());
                        cmd.Parameters.AddWithValue("@Unit_price", dataGridView2.Rows[i].Cells[8].Value.ToString());
                        cmd.ExecuteNonQuery();



                    }

                    MessageBox.Show("Issued");

                }
                catch (MySqlException ex)
                {

                    MessageBox.Show(ex.Message);
                    cancle();

                }

                mc.Close();
                while (dataGridView2.Rows.Count > 0)
                {
                    dataGridView2.Rows.RemoveAt(0);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            StoreMain sm = new StoreMain();
            sm.Show();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to cancel ?", "Cancel", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    mc.Open();
                    String qn;
                    String qs;
                    int q;
                    int qa;
                    int qt;

                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {

                        MySqlCommand cmd = new MySqlCommand("select Quantity from itp.store_item where ItemID = @ItemID and Batch_Number = @Batch_Number and Expier_Date = @Expier_Date ", mc);



                        cmd.Parameters.AddWithValue("@ItemID", dataGridView2.Rows[i].Cells[3].Value.ToString());

                        cmd.Parameters.AddWithValue("@Batch_Number", dataGridView2.Rows[i].Cells[5].Value.ToString());
                        cmd.Parameters.AddWithValue("@Expier_Date", dataGridView2.Rows[i].Cells[6].Value.ToString());


                        q = Convert.ToInt32(cmd.ExecuteScalar());


                        qs = dataGridView2.Rows[i].Cells[7].Value.ToString();

                        qa = Convert.ToInt32(qs);

                        qt = q + qa;
                        qn = Convert.ToString(qt);
                        qt = 0;
                        cmd.Parameters.Clear();

                        MySqlCommand cmd1 = new MySqlCommand("update itp.store_item set Quantity ='" + qn + "' where ItemID = @ItemID and Batch_Number = @Batch_Number and Expier_Date = @Expier_Date ", mc);

                        cmd1.Parameters.AddWithValue("@ItemID", dataGridView2.Rows[i].Cells[3].Value.ToString());
                        cmd1.Parameters.AddWithValue("@Batch_Number", dataGridView2.Rows[i].Cells[5].Value.ToString());
                        cmd1.Parameters.AddWithValue("@Expier_Date", dataGridView2.Rows[i].Cells[6].Value.ToString());

                        cmd1.ExecuteNonQuery();

                        cmd1.Parameters.Clear();
                    }

                }
                catch (MySqlException ex)
                {

                    MessageBox.Show(ex.Message);

                }

                mc.Close();
                while (dataGridView2.Rows.Count > 0)
                {
                    dataGridView2.Rows.RemoveAt(0);
                }
            }
        }

        public void cancle()
        {
            try
            {
                
                String qn;
                String qs;
                int q;
                int qa;
                int qt;

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {

                    MySqlCommand cmd = new MySqlCommand("select Quantity from itp.store_item where ItemID = @ItemID and Batch_Number = @Batch_Number and Expier_Date = @Expier_Date ", mc);



                    cmd.Parameters.AddWithValue("@ItemID", dataGridView2.Rows[i].Cells[3].Value.ToString());

                    cmd.Parameters.AddWithValue("@Batch_Number", dataGridView2.Rows[i].Cells[5].Value.ToString());
                    cmd.Parameters.AddWithValue("@Expier_Date", dataGridView2.Rows[i].Cells[6].Value.ToString());


                    q = Convert.ToInt32(cmd.ExecuteScalar());


                    qs = dataGridView2.Rows[i].Cells[7].Value.ToString();

                    qa = Convert.ToInt32(qs);

                    qt = q + qa;
                    qn = Convert.ToString(qt);
                    qt = 0;
                    cmd.Parameters.Clear();

                    MySqlCommand cmd1 = new MySqlCommand("update itp.store_item set Quantity ='" + qn + "' where ItemID = @ItemID and Batch_Number = @Batch_Number and Expier_Date = @Expier_Date ", mc);

                    cmd1.Parameters.AddWithValue("@ItemID", dataGridView2.Rows[i].Cells[3].Value.ToString());
                    cmd1.Parameters.AddWithValue("@Batch_Number", dataGridView2.Rows[i].Cells[5].Value.ToString());
                    cmd1.Parameters.AddWithValue("@Expier_Date", dataGridView2.Rows[i].Cells[6].Value.ToString());

                    cmd1.ExecuteNonQuery();

                    cmd1.Parameters.Clear();

                    MySqlCommand cmd2 = new MySqlCommand("delete from itp.store_issueorder_m where issue_order_id = @issue_order_id and ItemID = @ItemID and Batch_Number = @Batch_Number and Expier_Date = @Expier_Date", mc);

                    cmd2.Parameters.AddWithValue("@issue_order_id", dataGridView2.Rows[i].Cells[0].Value.ToString());
                    cmd2.Parameters.AddWithValue("@ItemID", dataGridView2.Rows[i].Cells[3].Value.ToString());
                    cmd2.Parameters.AddWithValue("@Batch_Number", dataGridView2.Rows[i].Cells[5].Value.ToString());
                    cmd2.Parameters.AddWithValue("@Expier_Date", dataGridView2.Rows[i].Cells[6].Value.ToString());
                    cmd2.ExecuteNonQuery();

                    cmd2.Parameters.Clear();
                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);

            }

            
            while (dataGridView2.Rows.Count > 0)
            {
                dataGridView2.Rows.RemoveAt(0);
            }
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
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
        public void fillCombo()
        {
            String query = "select * from itp.hr_add_dept; ";
            MySqlCommand cmd = new MySqlCommand(query, mc);
            MySqlDataReader mr;

            try
            {
                mc.Open();
                mr = cmd.ExecuteReader();


                while (mr.Read())
                {
                    string com = mr.GetString("Department_Name");
                    comboBox1.Items.Add(com);
                  
                }

            }

            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);

            }
            mc.Close();

        }
    }
}
