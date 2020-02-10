namespace Perfume.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Gender = c.String(nullable: false, maxLength: 10),
                        Brand = c.String(nullable: false, maxLength: 100),
                        Producer = c.String(nullable: false, maxLength: 50),
                        Price = c.Double(nullable: false),
                        Sale = c.Double(nullable: false),
                        Amount = c.Int(nullable: false),
                        image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
