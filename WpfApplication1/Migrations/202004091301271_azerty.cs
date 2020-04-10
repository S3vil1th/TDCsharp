namespace WpfApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class azerty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Depenses", "Personne_PersonneID", c => c.Int());
            CreateIndex("dbo.Depenses", "Personne_PersonneID");
            AddForeignKey("dbo.Depenses", "Personne_PersonneID", "dbo.Personnes", "PersonneID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Depenses", "Personne_PersonneID", "dbo.Personnes");
            DropIndex("dbo.Depenses", new[] { "Personne_PersonneID" });
            DropColumn("dbo.Depenses", "Personne_PersonneID");
        }
    }
}
