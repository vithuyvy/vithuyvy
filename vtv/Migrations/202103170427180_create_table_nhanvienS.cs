namespace vtv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_nhanvienS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.nhanvienS",
                c => new
                    {
                        Tennhanvien = c.String(nullable: false, maxLength: 128),
                        Sdt = c.String(),
                        Diachia = c.String(),
                    })
                .PrimaryKey(t => t.Tennhanvien);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.nhanvienS");
        }
    }
}
