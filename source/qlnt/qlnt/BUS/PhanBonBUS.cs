﻿using qlnt.DB;
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
        public void Add(PhanBon o)
        {

            PhanBonDB db = new PhanBonDB();
            db.Add(o);
        }
        public void Delete(string id)
        {
            PhanBonDB db = new PhanBonDB();
            db.Delete(id);
        }
        public void Edit(PhanBon o)
        {
            PhanBonDB db = new PhanBonDB();
            db.Edit(o);
        }

        public void View(BunifuCustomDataGrid dataGrid)
        {
            PhanBonDB db = new PhanBonDB();
            db.View(dataGrid);
        }
        public void Search(BunifuCustomDataGrid dataGrid,string s)
        {
            PhanBonDB db = new PhanBonDB();
            db.Search(dataGrid,s);
        }

    }
}
