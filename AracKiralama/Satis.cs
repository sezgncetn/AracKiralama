//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AracKiralama
{
    using System;
    using System.Collections.Generic;
    
    public partial class Satis
    {
        public int FaturaId { get; set; }
        public int MusteriId { get; set; }
        public int AracId { get; set; }
        public System.DateTime AlisTarihi { get; set; }
        public System.DateTime TeslimTarihi { get; set; }
        public decimal KiralikGunTutari { get; set; }
        public decimal ToplamTutar { get; set; }
    
        public virtual Araclar Araclar { get; set; }
        public virtual Musteriler Musteriler { get; set; }
    }
}
