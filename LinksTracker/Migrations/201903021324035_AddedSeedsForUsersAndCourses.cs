namespace LinksTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSeedsForUsersAndCourses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Par = c.Int(nullable: false),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Rating = c.Double(nullable: false),
                        Slope = c.Double(nullable: false),
                        TotalHoles = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Courses");
        }
    }
}
