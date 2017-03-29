namespace TripPlanner.DataAcces.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trips", "Created", c => c.DateTime(false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trips", "Created");
        }
    }
}
