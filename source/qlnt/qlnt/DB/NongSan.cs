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
    
    public partial class NongSan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NongSan()
        {
            this.ChiTiet_TH = new HashSet<ChiTiet_TH>();
            this.ChiTietXuat_NS = new HashSet<ChiTietXuat_NS>();
        }
    
        public int MaNS { get; set; }
        public double ThoiGianBaoQuan { get; set; }
        public double SanLuongTonKho { get; set; }
        public double DonGia { get; set; }
        public int MaLoaiCay { get; set; }
    
        public virtual Cay Cay { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTiet_TH> ChiTiet_TH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietXuat_NS> ChiTietXuat_NS { get; set; }
    }
}
