namespace WebCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRAUDAU")]
    public partial class TRAUDAU
    {
        [Key]
        [StringLength(20)]
        public string MaTranDau { get; set; }

        [Required]
        [StringLength(20)]
        public string MaMua { get; set; }

        [Required]
        [StringLength(20)]
        public string MaDoi1 { get; set; }

        [Required]
        [StringLength(20)]
        public string MaDoi2 { get; set; }

        [StringLength(10)]
        public string Luot { get; set; }

        [StringLength(10)]
        public string MaSan { get; set; }

        [Required]
        [StringLength(20)]
        public string MaTrongTai { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngay { get; set; }

        public TimeSpan? gio { get; set; }

        public int? SoBanThangDoi1 { get; set; }

        public int? SoBanThangDoi2 { get; set; }

        public virtual MUAGIAI MUAGIAI { get; set; }

        public virtual TRONGTAI TRONGTAI { get; set; }

        public virtual ICollection<CAUTHU_GHIBAN> CAUTHU_GHIBAN { get; set; }

        public virtual SAN SAN { get; set; }

        /*public virtual DOIBONG DOIBONG { get; set; }*/

        
    }
}
