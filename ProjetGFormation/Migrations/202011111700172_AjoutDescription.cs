namespace ProjetGFormation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LesCursus", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.LesCursus", "Description");
        }
    }
}
