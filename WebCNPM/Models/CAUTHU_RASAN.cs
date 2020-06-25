namespace WebCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAUTHU_RASAN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaTranDau { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MaCauThu { get; set; }

        [Required]
        [StringLength(20)]
        public string MaDoi { get; set; }

        public int? SoAo { get; set; }

        [StringLength(20)]
        public string ViTri { get; set; }

        public virtual DOIBONG DOIBONG { get; set; }
    }
}
