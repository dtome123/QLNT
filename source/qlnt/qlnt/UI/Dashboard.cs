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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            hidePanels();
        }

        private void hidePanels()
        {
            pnlWeather.Visible = false;
            pnlToDoList.Visible = false;
            pnlStatistics.Visible = false;
            pnlUnknownFeature.Visible = false;
        }

        private void showPanels()
        {
            pnlWeather.Visible = true;
            pnlToDoList.Visible = true;
            pnlStatistics.Visible = true;
            pnlUnknownFeature.Visible = true;
        }

        private void ibtnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void fbtnDashboard_Click(object sender, EventArgs e)
        {
            showPanels();
        }

        private void fbtnInformation_Click(object sender, EventArgs e)
        {
            hidePanels();
        }
    }
}
