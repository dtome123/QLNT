using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlnt.DTO
{
    class ChiTietKHDungThuocDTO
    {
        private int MaThuoc { set; get; }
        private int MaKH { set; get; }
        private float LieuLuong { set; get; }
        private bool HoanThanh { set; get; }

        public ChiTietKHDungThuocDTO() { }
        public ChiTietKHDungThuocDTO(int MaThuoc,int MaKH,float LieuLuong,bool HoanThanh)
        {
            this.MaThuoc = MaThuoc;
            this.MaKH = MaKH;
            this.LieuLuong = LieuLuong;
            this.HoanThanh = HoanThanh;
        }
        public ChiTietKHDungThuocDTO(ChiTietKHDungThuocDTO d)
        {
            MaThuoc = d.MaThuoc;
            MaKH = d.MaKH;
            LieuLuong = d.LieuLuong;
            HoanThanh = d.HoanThanh;
        }

    }
}
