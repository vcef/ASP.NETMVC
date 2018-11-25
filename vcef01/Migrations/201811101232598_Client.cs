namespace vcef01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Client : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cin = c.String(nullable: false),
                        Sexe = c.String(nullable: false),
                        Nom = c.String(nullable: false, maxLength: 255),
                        Prenom = c.String(nullable: false, maxLength: 255),
                        Telephone = c.String(nullable: false, maxLength: 250),
                        DateNaissance = c.String(nullable: false),
                        Address = c.String(nullable: false, maxLength: 400),
                        Ville = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false),
                        Date = c.DateTime(nullable: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clients");
        }
    }
}
