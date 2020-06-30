namespace WebCNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THAMSO")]
    public partial class THAMSO
    {
        [Key]
        [StringLength(16)]
        public string MaTS { get; set; }

        public int TuoiTT { get; set; }

        public int TuoiTD { get; set; }

        public int SoCauThuTT { get; set; }

        public int SoCauThuTD { get; set; }

        public int? SoCauThuNgoaiTD { get; set; }

        public int? ThoiDiemTT { get; set; }

        public int? ThoiDiemTD { get; set; }

        public int? DiemThang { get; set; }

        public int? DiemHoa { get; set; }

        public int? DiemThua { get; set; }
    }
}
