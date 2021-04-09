namespace vtv.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class khachhang
    {
        [Key]
        public string Tenkhachhang { get; set; }

        public string Sdt { get; set; }

        public string Diachi { get; set; }
    }
}
