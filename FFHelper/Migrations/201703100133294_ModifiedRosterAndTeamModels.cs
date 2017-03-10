namespace FFHelper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedRosterAndTeamModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "ApiTeamId", c => c.String());
            DropColumn("dbo.Rosters", "position");
            DropColumn("dbo.Rosters", "IsStarting");
            DropColumn("dbo.Teams", "ZipCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "ZipCode", c => c.Int(nullable: false));
            AddColumn("dbo.Rosters", "IsStarting", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rosters", "position", c => c.String());
            DropColumn("dbo.Teams", "ApiTeamId");
        }
    }
}
