namespace FFHelper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedteamandPositionFrmRoster : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Rosters", "Position");
            DropColumn("dbo.Rosters", "Team");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rosters", "Team", c => c.String());
            AddColumn("dbo.Rosters", "Position", c => c.String());
        }
    }
}
