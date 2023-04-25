namespace CelilCavus.Energym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AboutTitle = c.String(nullable: false, maxLength: 50),
                        AboutIcon = c.String(nullable: false, maxLength: 100),
                        AboutDescription = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContactUsController",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        PhonenNumber = c.String(nullable: false, maxLength: 11),
                        Message = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiesImage = c.String(nullable: false, maxLength: 100),
                        ServiesTitle = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Services");
            DropTable("dbo.ContactUsController");
            DropTable("dbo.Abouts");
        }
    }
}
