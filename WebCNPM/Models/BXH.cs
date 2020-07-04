namespace WebCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BXH")]
    public partial class BXH
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaDoi { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MaMua { get; set; }

        public int? TongHieuSo { get; set; }

        public int? SoTranThang { get; set; }

        public int? SoTranThua { get; set; }

        public int? SoTranHoa { get; set; }

        public int? BanThangSanKhach { get; set; }

        public virtual MUAGIAI MUAGIAI { get; set; }

        public virtual DOIBONG DOIBONG { get; set; }
    }
}
