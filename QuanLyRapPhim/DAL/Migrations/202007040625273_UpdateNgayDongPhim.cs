namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNgayDongPhim : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ePhims", "ngayDongPhim", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ePhims", "ngayDongPhim");
        }
    }
}
