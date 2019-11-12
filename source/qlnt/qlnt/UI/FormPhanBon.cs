using qlnt.DialogForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlnt.DB;
using qlnt.BUS;

namespace qlnt
{
    public partial class FormPhanBon : Form1
    {
        PhanBonBUS bus = new PhanBonBUS();
        public FormPhanBon()
        {
            InitializeComponent();
            
        }
        internal void View()
        {
            bus.View(dataGrid);
            dataGrid.Rows[0].Selected = false;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            View();
        }
        // Chức năng 
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Diablog_PB d = new Diablog_PB();
            d.ShowDialog(this);
            View();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            if (dataGrid.Columns[e.ColumnIndex].Name=="Sua")
            {
                //MessageBox.Show(dataGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                Diablog_PB d = new Diablog_PB(id);
                d.ShowDialog(this);
                View();
            }
            if (dataGrid.Columns[e.ColumnIndex].Name == "Xoa")
            {
                bus.Delete(id);
                View();
            }
        }


        // Hover hàng
        private void dataGrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGrid.ClearSelection();
            if(e.RowIndex > -1) {
                dataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221);
            }
        }

        private void dataGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGrid.ClearSelection();
            if (e.RowIndex > -1)
            {
                dataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}
