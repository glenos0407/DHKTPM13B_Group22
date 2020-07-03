namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        idNhanVien = c.Int(nullable: false, identity: true),
                        hoTen = c.String(),
                        cmnd = c.String(),
                        email = c.String(),
                        password = c.String(),
                        soDienThoai = c.String(),
                        chucVu = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idNhanVien);
            
            CreateTable(
                "dbo.Ves",
                c => new
                    {
                        idVe = c.Int(nullable: false, identity: true),
                        gheNgoi = c.String(),
                        giaVe = c.Double(nullable: false),
                        idNhanVien = c.Int(nullable: false),
                        idSuatChieu = c.Int(nullable: false),
                        idRapPhim = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idVe)
                .ForeignKey("dbo.NhanViens", t => t.idNhanVien, cascadeDelete: true)
                .ForeignKey("dbo.RapPhims", t => t.idRapPhim, cascadeDelete: true)
                .ForeignKey("dbo.SuatChieux", t => t.idSuatChieu, cascadeDelete: true)
                .Index(t => t.idNhanVien)
                .Index(t => t.idSuatChieu)
                .Index(t => t.idRapPhim);
            
            CreateTable(
                "dbo.RapPhims",
                c => new
                    {
                        idRapPhim = c.Int(nullable: false, identity: true),
                        diaChi = c.String(),
                        tenRnap = c.String(),
                        hotLine = c.String(),
                        soLuongChoNgoi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idRapPhim);
            
            CreateTable(
                "dbo.SuatChieux",
                c => new
                    {
                        idSuatChieu = c.Int(nullable: false, identity: true),
                        thoiGianChieu = c.String(),
                        idPhim = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idSuatChieu)
                .ForeignKey("dbo.Phims", t => t.idPhim, cascadeDelete: true)
                .Index(t => t.idPhim);
            
            CreateTable(
                "dbo.Phims",
                c => new
                    {
                        idPhim = c.Int(nullable: false, identity: true),
                        luaTuoi = c.Int(nullable: false),
                        ngayCongChieu = c.DateTime(nullable: false),
                        ngonNgu = c.String(),
                        noiDungPhim = c.String(),
                        poster = c.String(),
                        tenDaoDien = c.String(),
                        tenPhim = c.String(),
                        theLoai = c.String(),
                        thoiLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idPhim);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ves", "idSuatChieu", "dbo.SuatChieux");
            DropForeignKey("dbo.SuatChieux", "idPhim", "dbo.Phims");
            DropForeignKey("dbo.Ves", "idRapPhim", "dbo.RapPhims");
            DropForeignKey("dbo.Ves", "idNhanVien", "dbo.NhanViens");
            DropIndex("dbo.SuatChieux", new[] { "idPhim" });
            DropIndex("dbo.Ves", new[] { "idRapPhim" });
            DropIndex("dbo.Ves", new[] { "idSuatChieu" });
            DropIndex("dbo.Ves", new[] { "idNhanVien" });
            DropTable("dbo.Phims");
            DropTable("dbo.SuatChieux");
            DropTable("dbo.RapPhims");
            DropTable("dbo.Ves");
            DropTable("dbo.NhanViens");
        }
    }
}
