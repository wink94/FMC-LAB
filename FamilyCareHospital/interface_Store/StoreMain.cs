using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyCareHospital
{
    public partial class StoreMain : Form
    {
        public StoreMain(String position = null)
        {
            InitializeComponent();
            lbl_user.Text = position;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbl_time.Text = datetime.ToString("hh : mm : ss tt");
            this.lbl_date.Text = datetime.ToString("dd  MMMM  yyyy");
            lbl_day.Text = DateTime.Now.DayOfWeek.ToString();
        }

        private void btn_MS_M_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageStock ms = new ManageStock();
            ms.Show();
        }

        private void btn_VS_M_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStock vs = new ViewStock();
            vs.Show();

        }

        private void btn_AC_M_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCategory ac = new AddCategory();
            ac.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PurchaseOrder po = new PurchaseOrder();                     //btn purchase order medical store
            po.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewPurchaseOrder vp = new ViewPurchaseOrder();             //btn view purchase order medical store
            vp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdreIssue oi = new OrdreIssue();                           //btn order issue medical store
            oi.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewIssueOrder vio = new ViewIssueOrder();                  //btn view issue order medical store
            vio.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supplier s = new Supplier();                                //btn manage supplier medical store
            s.Show();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment p = new Payment();
            p.Show();
        }

        private void btn_ac_nm_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCategory_NM ac = new AddCategory_NM();
            ac.Show();
        }

        private void btn_vs_nm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStock_NM vs = new ViewStock_NM();
            vs.Show();
        }

        private void btn_ms_nm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageStock_NM ms = new ManageStock_NM();
            ms.Show();
        }

        private void btn_po_nm_Click(object sender, EventArgs e)
        {
            this.Hide();
            PurchaseOrder_NM ps = new PurchaseOrder_NM();
            ps.Show();
        }

        private void btn_io_nm_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueOrder_NM io = new IssueOrder_NM();
            io.Show();
        }

        private void btn_vpo_nm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewPurchaseOrder_NM vpo = new ViewPurchaseOrder_NM();
            vpo.Show();
        }

        private void btn_vio_nm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewIssueOrder_NM vio = new ViewIssueOrder_NM();
            vio.Show();
        }

        private void btn_msup_nm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageSupplier_NM msup = new ManageSupplier_NM();
            msup.Show();
        }

        private void btn_p_nm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment_NM p = new Payment_NM();
            p.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            loginHR lh = new loginHR();
            lh.Show();
            this.Close();
        }
    }
}
