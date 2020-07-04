namespace WebCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MUAGIAI")]
    public partial class MUAGIAI
    {
        public MUAGIAI()
        {
            TRAUDAUs = new HashSet<TRAUDAU>();

        }
        [Key]
        [StringLength(20)]
        public string MaMua { get; set; }

        [Required]
        [StringLength(500)]
        public string TenMua { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBatDau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }

        [StringLength(16)]
        public string MaTS { get; set; }

        [StringLength(20)]
        public string MaTTUT { get; set; }

        public virtual ICollection<TRAUDAU> TRAUDAUs { get; set; }

        public virtual ICollection<BXH> BXHs { get; set; }

        public virtual THAMSO THAMSO { get; set; }
    }
}
