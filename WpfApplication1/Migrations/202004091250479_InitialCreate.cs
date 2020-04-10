namespace WpfApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Depenses",
                c => new
                    {
                        DepenseID = c.Int(nullable: false, identity: true),
                        Montant = c.Int(nullable: false),
                        TypeDepense = c.String(),
                    })
                .PrimaryKey(t => t.DepenseID);
            
            CreateTable(
                "dbo.Personnes",
                c => new
                    {
                        PersonneID = c.Int(nullable: false, identity: true),
                        Prenom = c.String(),
                        Nom = c.String(),
                    })
                .PrimaryKey(t => t.PersonneID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personnes");
            DropTable("dbo.Depenses");
        }
    }
}
