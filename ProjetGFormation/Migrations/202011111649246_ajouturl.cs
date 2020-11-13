namespace ProjetGFormation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajouturl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LesCursus",
                c => new
                    {
                        LesCursusId = c.Int(nullable: false, identity: true),
                        Titre = c.String(),
                        Url = c.String(),
                        Duree = c.String(),
                    })
                .PrimaryKey(t => t.LesCursusId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LesCursus");
        }
    }
}
