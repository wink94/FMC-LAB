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
    public partial class PHmain : Form
    {
        public PHmain(String position = null)
        {
            InitializeComponent();
            lbl_user.Text = position;
        }

        private void btn_mngStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            PHmanage_stock phManage = new PHmanage_stock();
            phManage.Show();

        }

        private void btn_vwStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            PHview_stock phVwStock = new PHview_stock();
            phVwStock.Show();
        }

        private void btn_addCat_Click(object sender, EventArgs e)
        {
            this.Hide();
            PHaddCategory phAddCat = new PHaddCategory();
            phAddCat.Show();
        }

        private void btn_placedOrd_Click(object sender, EventArgs e)
        {
            this.Hide();
            PHplaced_order phPlacedOrd = new PHplaced_order();
            phPlacedOrd.Show();
        }

        private void btn_purchOrd_Click(object sender, EventArgs e)
        {
            this.Hide();
            PHpurchased_order phPurchOrd = new PHpurchased_order();
            phPurchOrd.Show();
        }

        private void btn_vwPurchOrd_Click(object sender, EventArgs e)
        {
            this.Hide();
            PHview_purchase_order vwPurchOrd = new PHview_purchase_order();
            vwPurchOrd.Show();
        }

        private void btn_mngSupp_Click(object sender, EventArgs e)
        {
            this.Hide();
            PHmanage_supplier_details mngSupp = new PHmanage_supplier_details();
            mngSupp.Show();
        }

        private void btn_payments_Click(object sender, EventArgs e)
        {
            this.Hide();
            PHpayment paymnt = new PHpayment();
            paymnt.Show();
        }

        private void btn_retailSale_Click(object sender, EventArgs e)
        {
            this.Hide();
            PHretail_sale retail = new PHretail_sale();
            retail.Show();
        }

        private void btn_vwSale_Click(object sender, EventArgs e)
        {
            this.Hide();
            PHview_sales vwSale = new PHview_sales();
            vwSale.Show();
        }

        private void btn_vwPlacedOrd_Click(object sender, EventArgs e)
        {
            this.Hide();
            PHplaced_order phPlacedOrd = new PHplaced_order();
            phPlacedOrd.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            loginHR lh = new loginHR();
            lh.Show();
            this.Close();
        }
    }
}
