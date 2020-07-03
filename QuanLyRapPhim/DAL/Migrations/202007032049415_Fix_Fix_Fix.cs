namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fix_Fix_Fix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.eVes", "idNhanVien", "dbo.eNhanViens");
            DropForeignKey("dbo.eVes", "idRapPhim", "dbo.eRapPhims");
            DropForeignKey("dbo.eSuatChieux", "idPhim", "dbo.ePhims");
            DropForeignKey("dbo.eVes", "idSuatChieu", "dbo.eSuatChieux");
            DropIndex("dbo.eVes", new[] { "idNhanVien" });
            DropIndex("dbo.eVes", new[] { "idSuatChieu" });
            DropIndex("dbo.eVes", new[] { "idRapPhim" });
            DropIndex("dbo.eSuatChieux", new[] { "idPhim" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.eSuatChieux", "idPhim");
            CreateIndex("dbo.eVes", "idRapPhim");
            CreateIndex("dbo.eVes", "idSuatChieu");
            CreateIndex("dbo.eVes", "idNhanVien");
            AddForeignKey("dbo.eVes", "idSuatChieu", "dbo.eSuatChieux", "idSuatChieu", cascadeDelete: true);
            AddForeignKey("dbo.eSuatChieux", "idPhim", "dbo.ePhims", "idPhim", cascadeDelete: true);
            AddForeignKey("dbo.eVes", "idRapPhim", "dbo.eRapPhims", "idRapPhim", cascadeDelete: true);
            AddForeignKey("dbo.eVes", "idNhanVien", "dbo.eNhanViens", "idNhanVien", cascadeDelete: true);
        }
    }
}
