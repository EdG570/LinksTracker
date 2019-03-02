namespace LinksTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHoleModelAndPopulateSeeds : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Holes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        Yardage = c.Int(nullable: false),
                        Par = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Holes", "CourseId", "dbo.Courses");
            DropIndex("dbo.Holes", new[] { "CourseId" });
            DropTable("dbo.Holes");
        }
    }
}
