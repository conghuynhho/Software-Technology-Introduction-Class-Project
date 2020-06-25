namespace WebCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANTHANG")]
    public partial class BANTHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANTHANG()
        {
            CAUTHU_GHIBAN = new HashSet<CAUTHU_GHIBAN>();
        }

        [Key]
        [StringLength(20)]
        public string MaLoaiBanThang { get; set; }

        [Column("BanThang")]
        [StringLength(20)]
        public string BanThang1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAUTHU_GHIBAN> CAUTHU_GHIBAN { get; set; }
    }
}
