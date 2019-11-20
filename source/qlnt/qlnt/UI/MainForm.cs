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
            this.IsMdiContainer = true;
            InitializeComponent();
            showPanels();
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
            APIPanel APIWeather = new APIPanel();
            APIWeather.TopLevel = false;
            pnlWeather.Controls.Add(APIWeather);
            APIWeather.Show();
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
            pnlMain.Controls.Clear();
            showPanels();
        }

        private void fbtnInformation_Click(object sender, EventArgs e)
        {
            hidePanels();
        }
        private void ftbnProductsSellingMngmt_Click(object sender, EventArgs e)
        {
            hidePanels();
            ProductSellingManagement Management = new ProductSellingManagement();
            Management.TopLevel = false;
            Management.AutoScroll = true;
            pnlMain.Controls.Add(Management);
            Management.Show();
        }

        private void fbtnLogin_Click(object sender, EventArgs e)
        {
            hidePanels();
            LoginForm login = new LoginForm();
            login.TopLevel = false;
            login.AutoScroll = true;
            pnlMain.Controls.Add(login);
            login.Show();
        }
    }
}
