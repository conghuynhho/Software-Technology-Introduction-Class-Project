namespace WebCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOIBONG")]
    public partial class DOIBONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOIBONG()
        {
            CAUTHUs = new HashSet<CAUTHU>();
            CAUTHU_RASAN = new HashSet<CAUTHU_RASAN>();
        }

        [Key]
        [StringLength(20)]
        public string MaDoi { get; set; }

        [StringLength(100)]
        public string TenDoi { get; set; }

        [Required]
        [StringLength(20)]
        public string MaSan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThanhLap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAUTHU> CAUTHUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAUTHU_RASAN> CAUTHU_RASAN { get; set; }

        public virtual SAN SAN { get; set; }
    }
}
