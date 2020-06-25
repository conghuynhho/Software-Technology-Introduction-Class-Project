namespace WebCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAN")]
    public partial class SAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SAN()
        {
            DOIBONGs = new HashSet<DOIBONG>();
        }

        [Key]
        [StringLength(20)]
        public string MaSan { get; set; }

        [StringLength(20)]
        public string TenSan { get; set; }

        [StringLength(30)]
        public string Diachi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOIBONG> DOIBONGs { get; set; }
    }
}
