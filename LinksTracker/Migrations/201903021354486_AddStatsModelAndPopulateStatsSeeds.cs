namespace LinksTracker.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddStatsModelAndPopulateStatsSeeds : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIR = c.Boolean(nullable: false),
                        GIR = c.Boolean(nullable: false),
                        UpAndDown = c.Boolean(nullable: false),
                        Putts = c.Int(nullable: false),
                        Penalties = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        HoleId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Holes", t => t.HoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.HoleId)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stats", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Stats", "HoleId", "dbo.Holes");
            DropIndex("dbo.Stats", new[] { "User_Id" });
            DropIndex("dbo.Stats", new[] { "HoleId" });
            DropTable("dbo.Stats");
        }
    }
}
