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
    class PhanBonDB
    {
        public PhanBonDB() { }
        public void load ( DataGridView d)
        {
            // DataSet data = new DataSet();
            //QLNTEntities1 db = new QLNTEntities1();
            
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                var result = from c in db.PhanBons select new { TenPB = c.TenPB, Loai = c.Loai };
                d.DataSource = result.ToList();
            }
        }
        public PhanBon getPhanBon(string id)
        {
            PhanBon o;
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //p= db.PhanBons.Find();
                int ma=Convert.ToInt32(id);
                o = db.PhanBons.Where(p => p.MaPB == ma).SingleOrDefault();
            }
            return o;
        }
        public void Add(PhanBon o)
        {
            /*using (QLNTEntities1 db = new QLNTEntities1())
            {
                
                db.PhanBons.Add(new PhanBon() { TenPB ="Nis", Loai="Vô cơ", NgaySX= new DateTime(2019,7,1),HanSD = new  DateTime(2020, 7, 1),SoLuong=12,DonGia=100000,KhoiLuong=500 });
                db.SaveChanges();
            }*/
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                db.PhanBons.Add(o);
                db.SaveChanges();
            }
        }
        public void Delete(string id)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = Convert.ToInt32(id);
                PhanBon temp = db.PhanBons.Where(p => p.MaPB == ma).SingleOrDefault();
                db.PhanBons.Remove(temp);
                db.SaveChanges();
            }
        }
        public void Edit(PhanBon o)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = o.MaPB;
                PhanBon temp = db.PhanBons.Find(ma);
                temp.TenPB = o.TenPB;
                temp.Loai = o.Loai;
                temp.SoLuong = o.SoLuong;
                temp.KhoiLuong = o.KhoiLuong;
                temp.NgaySX = o.NgaySX;
                temp.HanSD = o.HanSD;
                temp.DonGia = o.DonGia;
                db.SaveChanges();
            }
        }
        public void View(BunifuCustomDataGrid dataGrid)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //var result = from c in db.PhanBons select new { TenPB=c.TenPB, Loai=c} ;
                var result = from c in db.PhanBons
                             select new { TenPB = c.TenPB, Loai = c.Loai,KhoiLuong = c.KhoiLuong.ToString(), SoLuong = c.SoLuong, DonGia = c.DonGia, NgaySX = c.NgaySX.Day+"/"+ c.NgaySX.Month +"/"+ c.NgaySX.Year,HanSD=  c.HanSD.Day+"/"+c.HanSD.Month +"/"+ c.HanSD.Year ,MaPB=c.MaPB};
                dataGrid.DataSource = result.ToList();
            }
        }
        
    }
}
