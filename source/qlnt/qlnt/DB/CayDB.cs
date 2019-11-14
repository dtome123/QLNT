using Bunifu.Framework.UI;
using qlnt.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlnt.DB
{
    class CayDB
    {
        public CayDB() { }
        public void load ( DataGridView d)
        {
            // DataSet data = new DataSet();
            //QLNTEntities1 db = new QLNTEntities1();
            
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                var result = from c in db.Cays select new { TenCay = c.TenCay, SoLuong = c.SoLuong,MuaThuHoach=c.MuaThuHoach,NamGieoDau=c.NamGieoDau };
                d.DataSource = result.ToList();
            }
        }
        public Cay GetCay(string id)
        {
            Cay o;
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //p= db.PhanBons.Find();
                int ma=Convert.ToInt32(id);
                o = db.Cays.Where(p => p.MaLoaiCay == ma).SingleOrDefault();
            }
            return o;
        }
        public void Add(Cay o)
        {
            /*using (QLNTEntities1 db = new QLNTEntities1())
            {
                
                db.PhanBons.Add(new PhanBon() { TenPB ="Nis", Loai="Vô cơ", NgaySX= new DateTime(2019,7,1),HanSD = new  DateTime(2020, 7, 1),SoLuong=12,DonGia=100000,KhoiLuong=500 });
                db.SaveChanges();
            }*/
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                db.Cays.Add(o);
                db.SaveChanges();
            }
        }
        public void Delete(string id)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = Convert.ToInt32(id);
                Cay temp = db.Cays.Where(p => p.MaLoaiCay == ma).SingleOrDefault();
                db.Cays.Remove(temp);
                db.SaveChanges();
            }
        }
        public void Edit(Cay o)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = o.MaLoaiCay;
                Cay temp = db.Cays.Find(ma);
                temp.TenCay = o.TenCay;
                temp.SoLuong = o.SoLuong;
                temp.MuaThuHoach = o.MuaThuHoach;
                temp.NamGieoDau = o.NamGieoDau;
                db.SaveChanges();
            }
        }
        public void View(BunifuCustomDataGrid dataGrid)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //var result = from c in db.PhanBons select new { TenPB=c.TenPB, Loai=c} ;
                var result = from c in db.Cays
                             select new { TenCay = c.TenCay, SoLuong = c.SoLuong, MuaThuHoach = c.MuaThuHoach, NamGieoDau = c.NamGieoDau,MaLoaiCay=c.MaLoaiCay};
                dataGrid.DataSource = result.ToList();
            }
        }
        public void Search(BunifuCustomDataGrid dataGrid, string s)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                var result = from c in db.Cays
                              where c.TenCay.Contains(s)
                              select new { TenCay = c.TenCay, SoLuong = c.SoLuong, MuaThuHoach = c.MuaThuHoach, NamGieoDau = c.NamGieoDau,MaLoaiCay=c.MaLoaiCay };
                dataGrid.DataSource = result.ToList();
            }
        }
        
    }
}
