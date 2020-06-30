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
        [StringLength(20)]
        public string MaCTGB { get; set; }

        [Required]
        [StringLength(20)]
        public string MaTranDau { get; set; }

        [Required]
        [StringLength(20)]
        public string MaCauThu { get; set; }

        [Required]
        [StringLength(10)]
        public string ThoiDiem { get; set; }

        [StringLength(20)]
        public string MaLoaiBanThang { get; set; }
        
        public virtual BANTHANG BANTHANG { get; set; }
        public virtual TRAUDAU TRANDAU { get; set; }

        public virtual CAUTHU CAUTHU { get; set; }

    }
}
