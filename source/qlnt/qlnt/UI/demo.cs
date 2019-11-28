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
using qlnt.DB.Entity;

namespace qlnt.UI
{
    public partial class demo : Form
    {
        
        public demo()
        {
            InitializeComponent();
        }

        private void demo_Load(object sender, EventArgs e)
        {
            /*QLNTEntities1 db = new QLNTEntities1();
            var result = from c in db.PhanBons select new { TenPB= c.TenPB,Loai= c.Loai};
            dataGridView1.DataSource = result.ToList();*/
            PhanBon o = new PhanBon() { TenPB="hhhh"};
            
            
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if(splitContainer1.Panel2Collapsed == true)
            {
                splitContainer1.Panel2Collapsed = false;
                splitContainer1.Size = new Size(splitContainer1.Width, 200);
                splitContainer1.SplitterDistance = 40;
            }
            else
            {
                splitContainer1.Panel2Collapsed = true;
                splitContainer1.Size = new Size(splitContainer1.Width, 50);
                splitContainer1.SplitterDistance = 40;
            }*/
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (panelDrop.Size.Height == 0)
                panelDrop.Size = new Size(panelDrop.Width,75);
            else
                panelDrop.Size = new Size(panelDrop.Width, 0);
        }
    }
}
