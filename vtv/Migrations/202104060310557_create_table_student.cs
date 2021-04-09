namespace vtv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_student : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.persons",
                c => new
                    {
                        CCCD = c.String(nullable: false, maxLength: 128),
                        HoTen = c.String(),
                        Address = c.String(),
                        Truong = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.CCCD);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.persons");
        }
    }
}
