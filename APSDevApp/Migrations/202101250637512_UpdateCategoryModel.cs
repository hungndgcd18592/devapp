namespace APSDevApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCategoryModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Dc", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "Dc", c => c.String());
        }
    }
}
