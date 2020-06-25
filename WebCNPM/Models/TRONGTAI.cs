namespace WebCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRONGTAI")]
    public partial class TRONGTAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRONGTAI()
        {
            TRAUDAUs = new HashSet<TRAUDAU>();
        }

        [Key]
        [StringLength(20)]
        public string MaTrongTai { get; set; }

        [StringLength(20)]
        public string TenTrongTai { get; set; }

        [StringLength(20)]
        public string QuocTich { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAUDAU> TRAUDAUs { get; set; }
    }
}
