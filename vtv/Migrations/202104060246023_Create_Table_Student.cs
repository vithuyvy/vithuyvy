namespace vtv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Student : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.nhanvienS", "Diachi", c => c.String());
            DropColumn("dbo.nhanvienS", "Diachia");
        }
        
        public override void Down()
        {
            AddColumn("dbo.nhanvienS", "Diachia", c => c.String());
            DropColumn("dbo.nhanvienS", "Diachi");
        }
    }
}
