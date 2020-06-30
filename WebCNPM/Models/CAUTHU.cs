namespace WebCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CAUTHU")]
    public partial class CAUTHU
    {
        [Key]
        [StringLength(20)]
        public string MaCauThu { get; set; }

        [Required]
        [StringLength(20)]
        public string MaDoi { get; set; }

        [Required]
        [StringLength(20)]
        public string TenCauThu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(20)]
        public string MaLoaiCauThu { get; set; }

        [StringLength(10)]
        public string QuocTich { get; set; }

        [StringLength(20)]
        public string GhiChu { get; set; }

        [StringLength(1000)]
        public string HinhAnh { get; set; }

        public virtual DOIBONG DOIBONG { get; set; }

        public virtual LOAICAUTHU LOAICAUTHU { get; set; }

        public virtual ICollection<CAUTHU_GHIBAN> CAUTHU_GHIBANs { get; set; }
    }
}
