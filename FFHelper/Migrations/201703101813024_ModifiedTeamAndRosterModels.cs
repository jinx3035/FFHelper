namespace FFHelper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedTeamAndRosterModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rosters", "primary_position", c => c.String());
            AddColumn("dbo.Rosters", "Team_Id", c => c.Int());
            CreateIndex("dbo.Rosters", "Team_Id");
            AddForeignKey("dbo.Rosters", "Team_Id", "dbo.Teams", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rosters", "Team_Id", "dbo.Teams");
            DropIndex("dbo.Rosters", new[] { "Team_Id" });
            DropColumn("dbo.Rosters", "Team_Id");
            DropColumn("dbo.Rosters", "primary_position");
        }
    }
}
