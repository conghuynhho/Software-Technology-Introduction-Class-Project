namespace WebCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAUTHU_GHIBAN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaTranDau { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MaCauThu { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string ThoiDiem { get; set; }

        [Required]
        [StringLength(20)]
        public string MaLoaiBanThang { get; set; }

        public virtual BANTHANG BANTHANG { get; set; }
    }
}
