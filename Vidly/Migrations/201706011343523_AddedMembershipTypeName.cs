namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            Sql("UPDATE MembershipTypes('Name') VALUES ('Pay as You Go') WHERE DiscountRate=0");
            Sql("UPDATE MembershipTypes('Name') VALUES ('Monthly') WHERE DiscountRate=10");
            Sql("UPDATE MembershipTypes('Name') VALUES ('Quarterly') WHERE DiscountRate=0");
            Sql("UPDATE MembershipTypes('Name') VALUES ('Yearly') WHERE DiscountRate=0");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
