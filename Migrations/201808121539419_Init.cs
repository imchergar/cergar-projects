namespace DotNet3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Predmets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        PunoIme = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentPredmets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        PredmetId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Predmets", t => t.PredmetId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.PredmetId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentPredmets", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentPredmets", "PredmetId", "dbo.Predmets");
            DropIndex("dbo.StudentPredmets", new[] { "PredmetId" });
            DropIndex("dbo.StudentPredmets", new[] { "StudentId" });
            DropTable("dbo.StudentPredmets");
            DropTable("dbo.Students");
            DropTable("dbo.Predmets");
        }
    }
}
