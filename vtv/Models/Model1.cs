using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace vtv.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=vtv")
        {
        }
        public virtual DbSet<nhanvien> Nhanviens { get; set; }
        public virtual DbSet<khachhang> Khachhangs { get; set; }
        public virtual DbSet<person> Persons  { get; set; }
        public virtual DbSet<student> Students { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
