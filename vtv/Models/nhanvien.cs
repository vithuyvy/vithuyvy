namespace vtv.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("nhanvienS")]
    public partial class nhanvien
    {
        [Key]
        public string Tennhanvien { get; set; }

        public string Sdt { get; set; }
        [AllowHtml]
        public string Diachi { get; set; }
    }
}
