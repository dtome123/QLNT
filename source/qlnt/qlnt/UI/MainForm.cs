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
            showPanels();
        }
        private void hidePanels()
        {
            pnlWeather.Visible = false;
            pnlToDoList.Visible = false;
            pnlStatistics.Visible = false;
            pnlClock.Visible = false;
        }

        private void showPanels()
        {
            //showing API Weather Panel
            APIWeather APIWeather = new APIWeather();
            APIWeather.TopLevel =  false;
            pnlWeather.Controls.Add(APIWeather);
            APIWeather.Show();
            pnlWeather.Visible = true;

            //showing today's To-do List Panel
            ToDoListPanel todo = new ToDoListPanel();
            todo.TopLevel = false;
            pnlToDoList.Controls.Add(todo);
            todo.Show();
            pnlToDoList.Visible = true;

            //showing all time statistics Panel
            StatisticsPanel stat = new StatisticsPanel();
            load(pnlStatistics, stat);
            pnlStatistics.Visible = true;

            //i don't have any idea for this one yet
            ClockPanel clock = new ClockPanel();
            load(pnlClock, clock);
            pnlClock.Visible = true;
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
            InformationForm info = new InformationForm();
            info.TopLevel = false;
            load(pnlMain, info);
        }
        public void ftbnProductsSellingMngmt_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            hidePanels();
            ProductSellingMngmt psmngmt = new ProductSellingMngmt();
            load(pnlMain, psmngmt);
        }
        private void fbtnLogin_Click(object sender, EventArgs e)
        {
            hidePanels();
            LoginForm login = new LoginForm();
            load(pnlMain, login);
        }

        public void load(Panel panel, Form form)
        {
            panel.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            panel.Controls.Add(form);
            form.Show();
        }

        private void fbtnWarehouseMngmt_Click(object sender, EventArgs e)
        {
            hidePanels();
            WarehouseMngmtForm warehouse = new WarehouseMngmtForm();
            load(pnlMain, warehouse);
        }
    }
}
