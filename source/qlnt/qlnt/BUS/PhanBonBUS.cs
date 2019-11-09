using qlnt.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace qlnt.BUS
{
    class PhanBonBUS
    {
        public PhanBonBUS() { }
        public void check()
        {
            checkString check = new checkString();
        }
        public void them(PhanBon o)
        {

            PhanBonDB db = new PhanBonDB();
            db.them(o);
        }
        internal void xem(BunifuCustomDataGrid dataGrid)
        {
            PhanBonDB db = new PhanBonDB();
            db.xem(dataGrid);
        }
    }
}
