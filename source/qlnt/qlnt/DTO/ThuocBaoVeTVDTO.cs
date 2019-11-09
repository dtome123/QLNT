using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlnt.DTO
{
    class ThuocBaoVeTVDTO
    {
        private int MaThuoc { set; get; }
        private string TenThuoc { set; get; }
        private int ThoiGianCachLy { set; get; }
        private string NoiSX { set; get; }
        private string Dang { set; get; }
        private int SoLuong { set; get; }
        private string CongDung { set; get; }
        private DateTime NgaySX { set; get; }
        private DateTime HanSD { set; get; }
        private string MaDoc { set; get; }

        public ThuocBaoVeTVDTO() { }
        public ThuocBaoVeTVDTO(int MaThuoc, string TenThuoc,int ThoiGianCachLy, string NoiSX, string Dang,int SoLuong,string CongDung,DateTime NgaySX, DateTime HanSD,string MaDoc)
        {
            this.MaThuoc = MaThuoc;
            this.TenThuoc = TenThuoc;
            this.ThoiGianCachLy = ThoiGianCachLy;
            this.NoiSX = NoiSX;
            this.Dang = Dang;
            this.SoLuong = SoLuong;
            this.CongDung = CongDung;
            this.NgaySX = NgaySX;
            this.HanSD = HanSD;
            this.MaDoc = MaDoc;
        }
        public ThuocBaoVeTVDTO (ThuocBaoVeTVDTO d)
        {
            MaThuoc = d.MaThuoc;
            TenThuoc = d.TenThuoc;
            ThoiGianCachLy = d.ThoiGianCachLy;
            NoiSX = d.NoiSX;
            Dang = d.Dang;
            SoLuong = d.SoLuong;
            CongDung = d.CongDung;
            NgaySX = d.NgaySX;
            HanSD = d.HanSD;
            MaDoc = d.MaDoc;
        }
        
    }
}


    
