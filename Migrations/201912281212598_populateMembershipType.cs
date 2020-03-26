namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Name, SignUpFee, DurationInMonths, Discount) VALUES('PAY AS YOU GO', 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes(Name, SignUpFee, DurationInMonths, Discount) VALUES('MONTHLY', 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes(Name, SignUpFee, DurationInMonths, Discount) VALUES('QUARTERLY', 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes(Name, SignUpFee, DurationInMonths, Discount) VALUES('ANNUALY', 300, 12, 20)");
        }

        public override void Down()
        {
        }
    }
}
