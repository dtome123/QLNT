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
            hideButtons();
        }

        private void hidePanels()
        {
            pnlWeather.Visible = false;
            pnlToDoList.Visible = false;
            pnlStatistics.Visible = false;
            pnlUnknownFeature.Visible = false;
        }
        private void showButtons()
        {
            pnlMain.Controls.Add(tbtnImport);
            pnlMain.Controls.Add(tbtnExport);
            pnlMain.Controls.Add(tbtnBill);
            tbtnImport.Show();
            tbtnExport.Show();
            tbtnBill.Show();
        }
        private void hideButtons()
        {
            tbtnImport.Visible = false;
            tbtnExport.Visible = false;
            tbtnBill.Visible = false;
        }
        private void showPanels()
        {
            //showing API Weather Panel
            APIPanel APIWeather = new APIPanel();
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
            stat.TopLevel = false;
            pnlStatistics.Controls.Add(stat);
            stat.Show();
            pnlStatistics.Visible = true;

            //i don't have any idea for this one yet
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
            
        public void ftbnProductsSellingMngmt_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            hidePanels();
            showButtons();
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

        private void tbtnExport_Click(object sender, EventArgs e)
        {
            hideButtons();
            ExportForm expf = new ExportForm();
            expf.TopLevel = false;
            expf.TopMost = true;
            pnlMain.Controls.Add(expf);
            expf.Show();
            showButtons();
        }

        private void tbtnImport_Click(object sender, EventArgs e)
        {
            hideButtons();
            ImportForm impf = new ImportForm();
            impf.TopLevel = false;
            impf.TopMost = true;
            pnlMain.Controls.Add(impf);
            impf.Show();
            showButtons();
        }

        private void tbtnBill_Click(object sender, EventArgs e)
        {
            hideButtons();
            Bill bill = new Bill();
            bill.TopLevel = false;
            bill.TopMost = true;
            pnlMain.Controls.Add(bill);
            bill.Show();
            showButtons();
        }
    }
}
