using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyCareHospital.Pharmacy_Interfaces
{
    public partial class PHview_purchase_order : Form
    {
        public PHview_purchase_order()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

            this.Close();
            PHmain pm = new PHmain();
            pm.Show();
        }
    }
}
