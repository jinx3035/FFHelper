namespace FFHelper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedTeamDropDown : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "Team_Id", c => c.Int());
            CreateIndex("dbo.Teams", "Team_Id");
            AddForeignKey("dbo.Teams", "Team_Id", "dbo.Teams", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "Team_Id", "dbo.Teams");
            DropIndex("dbo.Teams", new[] { "Team_Id" });
            DropColumn("dbo.Teams", "Team_Id");
        }
    }
}
