namespace FFHelper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedApiCallToHomeControllerModifiedRosterModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rosters", "position", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rosters", "position");
        }
    }
}
