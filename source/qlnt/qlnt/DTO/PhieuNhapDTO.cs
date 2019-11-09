using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlnt.DTO
{
    class PhieuNhapDTO
    {
        private int MaPhieuNhap { set; get; }
        private DateTime NgayNhap { set; get; }
        private float ThanhTien { set; get; }
        private int MaNCC { set; get; }

        public PhieuNhapDTO() { }
        public PhieuNhapDTO(int MaPhieuNhap,DateTime NgayNhap,float ThanhTien,int MaNCC)
        {
            this.MaPhieuNhap = MaPhieuNhap;
            this.NgayNhap = NgayNhap;
            this.ThanhTien = ThanhTien;
            this.MaNCC = MaNCC;
        }
        public PhieuNhapDTO(PhieuNhapDTO d)
        {
            MaPhieuNhap = d.MaPhieuNhap;
            NgayNhap = d.NgayNhap;
            ThanhTien = d.ThanhTien;
            MaNCC = d.MaNCC;
        }
    }
}
