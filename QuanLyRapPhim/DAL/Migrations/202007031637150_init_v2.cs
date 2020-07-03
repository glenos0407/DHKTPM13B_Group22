namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RapPhims", "tenRap", c => c.String());
            DropColumn("dbo.RapPhims", "tenRnap");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RapPhims", "tenRnap", c => c.String());
            DropColumn("dbo.RapPhims", "tenRap");
        }
    }
}
