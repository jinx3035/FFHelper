namespace FFHelper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDbSetAndControllersToTeamAndRoster : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rosters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Position = c.String(),
                        Team = c.String(),
                        IsStarting = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ZipCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teams");
            DropTable("dbo.Rosters");
        }
    }
}
