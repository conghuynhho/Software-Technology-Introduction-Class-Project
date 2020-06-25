namespace WebCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAICAUTHU")]
    public partial class LOAICAUTHU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAICAUTHU()
        {
            CAUTHUs = new HashSet<CAUTHU>();
        }

        [Key]
        [StringLength(20)]
        public string MaLoaiCauThu { get; set; }

        [Column("LoaiCauThu")]
        [StringLength(30)]
        public string LoaiCauThu1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAUTHU> CAUTHUs { get; set; }
    }
}
