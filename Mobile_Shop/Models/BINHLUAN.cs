//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mobile_Shop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BINHLUAN
    {
        public int MaBL { get; set; }
        public Nullable<int> MaTV { get; set; }
        public Nullable<int> MaSP { get; set; }
        public string NoiDungBL { get; set; }
    
        public virtual SANPHAM SANPHAM { get; set; }
        public virtual THANHVIEN THANHVIEN { get; set; }
    }
}
