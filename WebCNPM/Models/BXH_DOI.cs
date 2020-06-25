namespace WebCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BXH_DOI
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaDoi { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MaMua { get; set; }

        public int? TongSoBanThang { get; set; }

        public int? TongSoBanThua { get; set; }

        public int? Thang { get; set; }

        public int? Hoa { get; set; }

        public int? Thua { get; set; }
    }
}
