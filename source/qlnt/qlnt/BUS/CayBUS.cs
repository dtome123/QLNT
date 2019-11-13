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
    class CayBUS
    {
        public CayBUS() { }
        public void check()
        {
            checkString check = new checkString();
        }
        public void Add(Cay o)
        {

            CayBUS db = new CayBUS();
            db.Add(o);
        }
        public void Delete(string id)
        {
            CayBUS db = new CayBUS();
            db.Delete(id);
        }
        public void Edit(Cay o)
        {
            CayBUS db = new CayBUS();
            db.Edit(o);
        }

        public void View(BunifuCustomDataGrid dataGrid)
        {
            CayBUS db = new CayBUS();
            db.View(dataGrid);
        }
        public void Search(BunifuCustomDataGrid dataGrid,string s)
        {
            CayBUS db = new CayBUS();
            db.Search(dataGrid,s);
        }

    }
}
