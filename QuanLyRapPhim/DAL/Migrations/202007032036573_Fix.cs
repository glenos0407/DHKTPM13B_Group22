namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fix : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.NhanViens", newName: "eNhanViens");
            RenameTable(name: "dbo.Ves", newName: "eVes");
            RenameTable(name: "dbo.RapPhims", newName: "eRapPhims");
            RenameTable(name: "dbo.SuatChieux", newName: "eSuatChieux");
            RenameTable(name: "dbo.Phims", newName: "ePhims");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ePhims", newName: "Phims");
            RenameTable(name: "dbo.eSuatChieux", newName: "SuatChieux");
            RenameTable(name: "dbo.eRapPhims", newName: "RapPhims");
            RenameTable(name: "dbo.eVes", newName: "Ves");
            RenameTable(name: "dbo.eNhanViens", newName: "NhanViens");
        }
    }
}
