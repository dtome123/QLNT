using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlnt.DTO
{
    class ChiTietKHPhanBonDTO
    {
        private int MaPB { set; get; }
        private int MaKH { set; get; }
        private float LieuLuong { set; get; }
        private bool HoanThanh { set; get; }


        public ChiTietKHPhanBonDTO() { }
        public ChiTietKHPhanBonDTO(int MaPB,int MaKH,float LieuLuong,bool HoanThanh)
        {
            this.MaPB = MaPB;
            this.MaKH = MaKH;
            this.LieuLuong = LieuLuong;
            this.HoanThanh = HoanThanh;
        }
        public ChiTietKHPhanBonDTO(ChiTietKHPhanBonDTO d)
        {
            MaPB = d.MaPB;
            MaKH = d.MaKH;
            LieuLuong = d.LieuLuong;
            HoanThanh = d.HoanThanh;
        }
    }
}
