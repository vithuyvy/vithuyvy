
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vtv.Models
{
    [Table ("persons")]
    public class person
    {
        [Key]
        public string CCCD { get; set; }
        public string HoTen { get; set; }
        public string Address { get; set; }
    }
}