using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace FamilyCareHospital
{
    public partial class Ward_Admin_ViewWard_WHandling : Form
    {
        public Ward_Admin_ViewWard_WHandling()
        {
            InitializeComponent();
        }

        static string myConnection = "Data Source=localhost; Initial Catalog=itp; port=3306; username=root; password=sagarox";
        //static MySqlConnection myConn = new MySqlConnection(myConnection);


        DataTable dbDataset;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ward_MainFrame f1 = new Ward_MainFrame();
            f1.ShowDialog();
        }


        private void auto_load_datagrid_all()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string autoloadDataGridALLQuery = "SELECT w.ward_id as 'WARD_ID', w.ward_name as 'WARD_NAME', w.floor as 'FLOOR', c.type as 'CLASS_TYPE', c.bathroom as 'BATHROOM/TOILET', c.food as 'FOOD', c.ventilation as 'VENTILATION', c.optional_sleeper_unit as 'OPTIONAL_SLEEPER_UNIT', c.amenities_tv as 'TELEVISION', c.amenities_sofa as 'SOFA', c.amenities_phone as 'TELEPHONE', c.amenities_fridge as 'FRIDGE', c.amenities_wardrobe as 'WARDROBE', r.room_no as 'ROOM_NO', r.no_of_beds as 'NO_OF_BEDS', b.bed_no as 'BED_NO', c.price as 'PRICE', b.status as 'STATUS' FROM itp.ward_category w, itp.class_type c, itp.room_details r, itp.bed_details b WHERE w.ward_id=r.ward_id AND c.type=r.type AND r.room_no=b.room_no order by w.ward_id;";
                MySqlCommand cmd = new MySqlCommand(autoloadDataGridALLQuery, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView1_ViewWard.DataSource = bSource;

                dataGridView1_ViewWard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            myConn.Close();
        }


        private void auto_load_datagrid_wardDetails()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string autoloadDataGridWardQuery = "SELECT ward_id as 'WARD_ID', ward_name as 'WARD_NAME', floor as 'FLOOR' FROM itp.ward_category;";
                MySqlCommand cmd = new MySqlCommand(autoloadDataGridWardQuery, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView1_ViewWard.DataSource = bSource;

                dataGridView1_ViewWard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            myConn.Close();
        }


        private void auto_load_datagrid_classDetails()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string autoloadDataGridClassQuery = "SELECT type as 'CLASS_TYPE', bathroom as 'BATHROOM/TOILET', food as 'FOOD', ventilation as 'VENTILATION', optional_sleeper_unit as 'OPTIONAL_SLEEPER_UNIT', amenities_tv as 'TELEVISION', amenities_sofa as 'SOFA', amenities_phone as 'TELEPHONE', amenities_fridge as 'FRIDGE', amenities_wardrobe as 'WARDROBE', price as 'PRICE' FROM itp.class_type;";
                MySqlCommand cmd = new MySqlCommand(autoloadDataGridClassQuery, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView1_ViewWard.DataSource = bSource;

                dataGridView1_ViewWard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            myConn.Close();
        }


        private void auto_load_datagrid_RoomDetails()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string autoloadDataGridRoomQuery = "SELECT ward_id as 'WARD_ID', type as 'CLASS_TYPE', room_no as 'ROOM_NO', no_of_beds as 'NO_OF_BEDS' FROM itp.room_details order by ward_id;";
                MySqlCommand cmd = new MySqlCommand(autoloadDataGridRoomQuery, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView1_ViewWard.DataSource = bSource;

                dataGridView1_ViewWard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            myConn.Close();
        }


        private void auto_load_datagrid_bedDetails()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string autoloadDataGridBedQuery = "SELECT room_no as 'ROOM_NO',bed_no as 'BED_NO', status as 'STATUS' FROM itp.bed_details;";
                MySqlCommand cmd = new MySqlCommand(autoloadDataGridBedQuery, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView1_ViewWard.DataSource = bSource;

                dataGridView1_ViewWard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            myConn.Close();
        }

        private void btn_AllDetails_Click(object sender, EventArgs e)
        {
            auto_load_datagrid_all();
        }

        private void btn_WardDetails_Click(object sender, EventArgs e)
        {
            auto_load_datagrid_wardDetails();
        }

        private void btn_ClassDetails_Click(object sender, EventArgs e)
        {
            auto_load_datagrid_classDetails();
        }

        private void btn_RoomDetails_Click(object sender, EventArgs e)
        {
            auto_load_datagrid_RoomDetails();
        }

        private void btn_BedDetails_Click(object sender, EventArgs e)
        {
            auto_load_datagrid_bedDetails();
        }
    }
}
