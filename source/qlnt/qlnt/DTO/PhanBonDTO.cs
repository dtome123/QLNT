using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlnt.DTO
{
    class PhanBonDTO
    {
        private int MaPB { set; get; }
        private string TenPB { set; get; }
        private string Loai { set; get; }
        private float KhoiLuong { set; get; }
        private int SoLuong { set; get; }
        private DateTime NgaySD { set; get; }
        private DateTime HanSD { set; get; }
        private float DonGia { set; get; }

        public PhanBonDTO(){}
        public PhanBonDTO(int MaPB, string TenPB, string Loai, float KhoiLuong, int SoLuong, DateTime NgaySD, DateTime HanSD,float DonGia)
        {
            this.MaPB = MaPB;
            this.TenPB = TenPB;
            this.Loai = Loai;
            this.KhoiLuong = KhoiLuong;
            this.SoLuong = SoLuong;
            this.NgaySD = NgaySD;
            this.HanSD = HanSD;
            this.DonGia = DonGia;
        }
        public PhanBonDTO(PhanBonDTO p)
        {
            MaPB = p.MaPB;
            TenPB = p.TenPB;
            Loai = p.Loai;
            KhoiLuong = p.KhoiLuong;
            SoLuong = p.SoLuong;
            NgaySD = p.NgaySD;
            HanSD = p.HanSD;
            DonGia = p.DonGia;
        }
    }
}
