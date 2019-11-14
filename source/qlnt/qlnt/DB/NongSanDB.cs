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
    class NongSanDB
    {
        public NongSanDB() { }
        public void load ( DataGridView d)
        {
            // DataSet data = new DataSet();
            //QLNTEntities1 db = new QLNTEntities1();
            
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                var result = from c in db.NongSans select new { ThoiGianBaoQuan = c.ThoiGianBaoQuan, SanLuongTonKho = c.SanLuongTonKho, DonGia = c.DonGia, BaoQuan=c.BaoQuan };
                d.DataSource = result.ToList();
            }
        }
        public NongSan getNongSan(string id)
        {
            NongSan o;
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //p= db.NongSans.Find();
                int ma=Convert.ToInt32(id);
                o = db.NongSans.Where(p => p.MaNS == ma).SingleOrDefault();
            }
            return o;
        }
        public void Add(NongSan o)
        {
            /*using (QLNTEntities1 db = new QLNTEntities1())
            {
                
                db.NongSans.Add(new NongSan() { TenPB ="Nis", Loai="Vô cơ", NgaySX= new DateTime(2019,7,1),HanSD = new  DateTime(2020, 7, 1),SoLuong=12,DonGia=100000,KhoiLuong=500 });
                db.SaveChanges();
            }*/
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                db.NongSans.Add(o);
                db.SaveChanges();
            }
        }
        public void Delete(string id)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = Convert.ToInt32(id);
                NongSan temp = db.NongSans.Where(p => p.MaNS == ma).SingleOrDefault();
                db.NongSans.Remove(temp);
                db.SaveChanges();
            }
        }
        public void Edit(NongSan o)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = o.MaNS;
                NongSan temp = db.NongSans.Find(ma);
                temp.ThoiGianBaoQuan = o.ThoiGianBaoQuan;
                temp.SanLuongTonKho = o.SanLuongTonKho;
                temp.DonGia = o.DonGia;
                temp.BaoQuan = o.BaoQuan;
                db.SaveChanges();
            }
        }
        public void View(BunifuCustomDataGrid dataGrid)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //var result = from c in db.NongSans select new { TenPB=c.TenPB, Loai=c} ;
                var result = from c in db.NongSans
                             select new { ThoiGianBaoQuan = c.ThoiGianBaoQuan, SanLuongTonKho = c.SanLuongTonKho, DonGia = c.DonGia, BaoQuan = c.BaoQuan };
                dataGrid.DataSource = result.ToList();
            }
        }
        /*public void Search(BunifuCustomDataGrid dataGrid, string s)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                var result = from c in db.NongSans
                              where c./*Tencay.Contains(s)
                              select new { TenPB = c.TenPB, Loai = c.Loai, KhoiLuong = c.KhoiLuong.ToString(), SoLuong = c.SoLuong, DonGia = c.DonGia, NgaySX = c.NgaySX.Day + "/" + c.NgaySX.Month + "/" + c.NgaySX.Year, HanSD = c.HanSD.Day + "/" + c.HanSD.Month + "/" + c.HanSD.Year, MaPB = c.MaPB };
                dataGrid.DataSource = result.ToList();
            }
        }*/
        
    }
}
