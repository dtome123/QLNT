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
    public partial class ProductSellingManagement : Form
    {
        public ProductSellingManagement()
        {
            InitializeComponent();
            
        }

        private void tbtnImportForm_Click(object sender, EventArgs e)
        {

        }
        private void hideComponent()
        {
            tbtnBillForm.Visible = false;
            tbtnExportForm.Visible = false;
            tbtnImportForm.Visible = false;
        }
        private void tbtnExportForm_Click(object sender, EventArgs e)
        {
            hideComponent();
            ExportForm expf = new ExportForm();
            expf.TopLevel = false;
            expf.AutoScroll = true;
            this.Controls.Add(expf);
            expf.Show();
        }
    }
}
