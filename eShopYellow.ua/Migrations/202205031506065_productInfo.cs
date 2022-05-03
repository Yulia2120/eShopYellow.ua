namespace eShopYellow.ua.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Price = c.String(maxLength: 255),
                        Description = c.String(maxLength: 2255),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductInfoes");
        }
    }
}
