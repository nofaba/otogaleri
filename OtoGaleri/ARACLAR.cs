

namespace OtoGaleri
{
    using System;
    using System.Collections.Generic;
    
    public partial class ARACLAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ARACLAR()
        {
            this.MUSTERI = new HashSet<MUSTERI>();
        }
    
        public int Arac_ID { get; set; }
        public string Arac_Marka { get; set; }
        public string Arac_Model { get; set; }
        public string Arac_Renk { get; set; }
        public string Arac_Yil { get; set; }
        public string Arac_KM { get; set; }
        public string Arac_Kasa { get; set; }
        public string Arac_Durumu { get; set; }
        public string Arac_Fiyati { get; set; }
        public string Arac_Foto { get; set; }
        public string Arac_Vites { get; set; }
        public string Arac_Yakit { get; set; }
        public string Arac_Plaka { get; set; }
        public Nullable<bool> Arac_SatılıkMi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUSTERI> MUSTERI { get; set; }
    }
}
