namespace MVCClub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Applicationuserfieldsadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "JoinDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Surname", c => c.String());
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUsers", "Surname");
            DropColumn("dbo.AspNetUsers", "JoinDate");
        }
    }
}
