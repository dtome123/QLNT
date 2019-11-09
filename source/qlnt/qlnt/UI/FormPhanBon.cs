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
        public FormPhanBon()
        {
            InitializeComponent();
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            PhanBonBUS bus = new PhanBonBUS();
            bus.xem(dataGrid);
            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Diablog_PB d = new Diablog_PB();
            d.ShowDialog(this);
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGrid.Columns[e.ColumnIndex].Name=="Sua")
            {
                //MessageBox.Show(dataGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                Diablog_PB d = new Diablog_PB(dataGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                d.ShowDialog(this);
            }
        }
    }
}
