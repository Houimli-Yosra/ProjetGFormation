namespace ProjetGFormation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajoutdesTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LeFormateurs",
                c => new
                    {
                        LeFormateurId = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Mot_De_Passe = c.String(),
                        E_mail = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.LeFormateurId);
            
            CreateTable(
                "dbo.LesSessionDeFormations",
                c => new
                    {
                        LesSessionDeFormationId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.LesSessionDeFormationId);
            
            CreateTable(
                "dbo.LesSessionDeCursus",
                c => new
                    {
                        LesSessionDeCursusId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        url = c.String(),
                        LeStagiaire_LeStagiaireId = c.Int(),
                    })
                .PrimaryKey(t => t.LesSessionDeCursusId)
                .ForeignKey("dbo.LeStagiaires", t => t.LeStagiaire_LeStagiaireId)
                .Index(t => t.LeStagiaire_LeStagiaireId);
            
            CreateTable(
                "dbo.LeStagiaires",
                c => new
                    {
                        LeStagiaireId = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        E_mail = c.String(maxLength: 50),
                        Url = c.String(),
                        Date_de_Naissance = c.DateTime(nullable: false),
                        Mot_De_Passe = c.String(maxLength: 8),
                    })
                .PrimaryKey(t => t.LeStagiaireId);
            
            CreateTable(
                "dbo.LesSessionDeFormationLeFormateurs",
                c => new
                    {
                        LesSessionDeFormation_LesSessionDeFormationId = c.Int(nullable: false),
                        LeFormateur_LeFormateurId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.LesSessionDeFormation_LesSessionDeFormationId, t.LeFormateur_LeFormateurId })
                .ForeignKey("dbo.LesSessionDeFormations", t => t.LesSessionDeFormation_LesSessionDeFormationId, cascadeDelete: true)
                .ForeignKey("dbo.LeFormateurs", t => t.LeFormateur_LeFormateurId, cascadeDelete: true)
                .Index(t => t.LesSessionDeFormation_LesSessionDeFormationId)
                .Index(t => t.LeFormateur_LeFormateurId);
            
            CreateTable(
                "dbo.LesSessionDeCursusLesSessionDeFormations",
                c => new
                    {
                        LesSessionDeCursus_LesSessionDeCursusId = c.Int(nullable: false),
                        LesSessionDeFormation_LesSessionDeFormationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.LesSessionDeCursus_LesSessionDeCursusId, t.LesSessionDeFormation_LesSessionDeFormationId })
                .ForeignKey("dbo.LesSessionDeCursus", t => t.LesSessionDeCursus_LesSessionDeCursusId, cascadeDelete: true)
                .ForeignKey("dbo.LesSessionDeFormations", t => t.LesSessionDeFormation_LesSessionDeFormationId, cascadeDelete: true)
                .Index(t => t.LesSessionDeCursus_LesSessionDeCursusId)
                .Index(t => t.LesSessionDeFormation_LesSessionDeFormationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LesSessionDeCursus", "LeStagiaire_LeStagiaireId", "dbo.LeStagiaires");
            DropForeignKey("dbo.LesSessionDeCursusLesSessionDeFormations", "LesSessionDeFormation_LesSessionDeFormationId", "dbo.LesSessionDeFormations");
            DropForeignKey("dbo.LesSessionDeCursusLesSessionDeFormations", "LesSessionDeCursus_LesSessionDeCursusId", "dbo.LesSessionDeCursus");
            DropForeignKey("dbo.LesSessionDeFormationLeFormateurs", "LeFormateur_LeFormateurId", "dbo.LeFormateurs");
            DropForeignKey("dbo.LesSessionDeFormationLeFormateurs", "LesSessionDeFormation_LesSessionDeFormationId", "dbo.LesSessionDeFormations");
            DropIndex("dbo.LesSessionDeCursusLesSessionDeFormations", new[] { "LesSessionDeFormation_LesSessionDeFormationId" });
            DropIndex("dbo.LesSessionDeCursusLesSessionDeFormations", new[] { "LesSessionDeCursus_LesSessionDeCursusId" });
            DropIndex("dbo.LesSessionDeFormationLeFormateurs", new[] { "LeFormateur_LeFormateurId" });
            DropIndex("dbo.LesSessionDeFormationLeFormateurs", new[] { "LesSessionDeFormation_LesSessionDeFormationId" });
            DropIndex("dbo.LesSessionDeCursus", new[] { "LeStagiaire_LeStagiaireId" });
            DropTable("dbo.LesSessionDeCursusLesSessionDeFormations");
            DropTable("dbo.LesSessionDeFormationLeFormateurs");
            DropTable("dbo.LeStagiaires");
            DropTable("dbo.LesSessionDeCursus");
            DropTable("dbo.LesSessionDeFormations");
            DropTable("dbo.LeFormateurs");
        }
    }
}
