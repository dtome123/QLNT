//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace qlnt.DB.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class BangThuHoach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BangThuHoach()
        {
            this.ChiTiet_TH = new HashSet<ChiTiet_TH>();
        }
    
        public int MaBang { get; set; }
        public System.DateTime NgayThuHoach { get; set; }
        public int MaNV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTiet_TH> ChiTiet_TH { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}