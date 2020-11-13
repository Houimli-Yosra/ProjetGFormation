namespace ProjetGFormation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajoutLesformations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LesFormations",
                c => new
                    {
                        LesFormationsId = c.Int(nullable: false, identity: true),
                        titre = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.LesFormationsId);
            
            CreateTable(
                "dbo.LesFormationsLesCursus",
                c => new
                    {
                        LesFormations_LesFormationsId = c.Int(nullable: false),
                        LesCursus_LesCursusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.LesFormations_LesFormationsId, t.LesCursus_LesCursusId })
                .ForeignKey("dbo.LesFormations", t => t.LesFormations_LesFormationsId, cascadeDelete: true)
                .ForeignKey("dbo.LesCursus", t => t.LesCursus_LesCursusId, cascadeDelete: true)
                .Index(t => t.LesFormations_LesFormationsId)
                .Index(t => t.LesCursus_LesCursusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LesFormationsLesCursus", "LesCursus_LesCursusId", "dbo.LesCursus");
            DropForeignKey("dbo.LesFormationsLesCursus", "LesFormations_LesFormationsId", "dbo.LesFormations");
            DropIndex("dbo.LesFormationsLesCursus", new[] { "LesCursus_LesCursusId" });
            DropIndex("dbo.LesFormationsLesCursus", new[] { "LesFormations_LesFormationsId" });
            DropTable("dbo.LesFormationsLesCursus");
            DropTable("dbo.LesFormations");
        }
    }
}
