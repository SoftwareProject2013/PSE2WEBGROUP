namespace BeerShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        userID = c.String(nullable: false, maxLength: 128),
                        firstName = c.String(nullable: false),
                        lastName = c.String(nullable: false),
                        email = c.String(nullable: false),
                        password = c.String(nullable: false),
                        phone = c.String(),
                        address = c.String(),
                        birth = c.DateTime(nullable: false),
                        locked = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.userID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
