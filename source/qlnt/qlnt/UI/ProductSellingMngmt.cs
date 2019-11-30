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
    public partial class ProductSellingMngmt : Form
    {
        public ProductSellingMngmt()
        {
            InitializeComponent();
        }
        private void hideComponents()
        {
            tbtnCustomerMngmt.Hide();
            tbtnSupplierMngmt.Hide();
            tbtnImportMngmt.Hide();
            tbtnExportMngmt.Hide();
            tbtnBillMngmt.Hide();
        }
        private void showComponents()
        {
            tbtnCustomerMngmt.Show();
            tbtnSupplierMngmt.Show();
            tbtnImportMngmt.Show();
            tbtnExportMngmt.Show();
            tbtnBillMngmt.Show();
        }
        private void tbtnExportMngmt_Click(object sender, EventArgs e)
        {

        }

        private void tbtnImportMngmt_Click(object sender, EventArgs e)
        {
            hideComponents();
            ImportMngmt importMenu = new ImportMngmt();
            importMenu.TopLevel = false;
            this.Controls.Add(importMenu);
            importMenu.Show();
            showComponents();
        }
    }
}
