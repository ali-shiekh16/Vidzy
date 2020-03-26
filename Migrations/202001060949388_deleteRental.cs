namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteRental : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Rental_Id", "dbo.Rentals");
            DropForeignKey("dbo.Movies", "Rental_Id", "dbo.Rentals");
            DropIndex("dbo.Customers", new[] { "Rental_Id" });
            DropIndex("dbo.Movies", new[] { "Rental_Id" });
            DropColumn("dbo.Customers", "Rental_Id");
            DropColumn("dbo.Movies", "Rental_Id");
            DropTable("dbo.Rentals");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateRented = c.DateTime(nullable: false),
                        DateReturned = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "Rental_Id", c => c.Int());
            AddColumn("dbo.Customers", "Rental_Id", c => c.Int());
            CreateIndex("dbo.Movies", "Rental_Id");
            CreateIndex("dbo.Customers", "Rental_Id");
            AddForeignKey("dbo.Movies", "Rental_Id", "dbo.Rentals", "Id");
            AddForeignKey("dbo.Customers", "Rental_Id", "dbo.Rentals", "Id");
        }
    }
}
