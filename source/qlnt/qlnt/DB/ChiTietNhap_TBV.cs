//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace qlnt.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietNhap_TBV
    {
        public int MaPhieuNhap { get; set; }
        public int MaThuoc { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
    
        public virtual PhieuNhap PhieuNhap { get; set; }
        public virtual ThuocBaoVeTV ThuocBaoVeTV { get; set; }
    }
}
