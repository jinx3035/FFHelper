namespace FFHelper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VariousChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rosters", "full_name", c => c.String());
            AddColumn("dbo.Rosters", "ApiPlayerId", c => c.String());
            DropColumn("dbo.Rosters", "name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rosters", "name", c => c.String());
            DropColumn("dbo.Rosters", "ApiPlayerId");
            DropColumn("dbo.Rosters", "full_name");
        }
    }
}
