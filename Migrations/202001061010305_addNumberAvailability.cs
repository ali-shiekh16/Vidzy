namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNumberAvailability : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvailability", c => c.Int(nullable: false));
            Sql("UPDATE Movies SET NumberAvailability = NumberInStock");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvailability");
        }
    }
}
