using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlnt.UI
{
    public partial class BillMngmt : Form
    {
        public BillMngmt()
        {
            InitializeComponent();
        }

        private void hideComponents()
        {
            tbtnCreateBill.Visible = false;
            tbtnSearchBill.Visible = false;
        }

        private void showComponents()
        {
            tbtnCreateBill.Visible = true;
            tbtnSearchBill.Visible = true;
        }

        private void tbtnSearchBill_Click(object sender, EventArgs e)
        {
            hideComponents();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
