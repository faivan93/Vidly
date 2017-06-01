namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypesName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes('Name') VALUES ('Pay as You Go') WHERE DiscountRate=0");
            Sql("UPDATE MembershipTypes('Name') VALUES ('Monthly') WHERE DiscountRate=10");
            Sql("UPDATE MembershipTypes('Name') VALUES ('Quarterly') WHERE DiscountRate=15");
            Sql("UPDATE MembershipTypes('Name') VALUES ('Yearly') WHERE DiscountRate=20");
        }
        
        public override void Down()
        {
        }
    }
}
