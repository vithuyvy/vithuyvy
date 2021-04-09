namespace vtv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_khachhangs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.khachhangs",
                c => new
                    {
                        Tenkhachhang = c.String(nullable: false, maxLength: 128),
                        Sdt = c.String(),
                        Diachi = c.String(),
                    })
                .PrimaryKey(t => t.Tenkhachhang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.khachhangs");
        }
    }
}
