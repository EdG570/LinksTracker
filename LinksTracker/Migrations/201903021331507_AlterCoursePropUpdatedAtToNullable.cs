namespace LinksTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterCoursePropUpdatedAtToNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "UpdatedAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "UpdatedAt", c => c.DateTime(nullable: false));
        }
    }
}
