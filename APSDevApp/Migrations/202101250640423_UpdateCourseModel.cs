namespace APSDevApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCourseModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Dc", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "Dc", c => c.String());
        }
    }
}
