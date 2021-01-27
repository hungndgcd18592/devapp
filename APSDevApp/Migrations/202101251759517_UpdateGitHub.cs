namespace APSDevApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGitHub : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trainees",
                c => new
                    {
                        TraineeId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Class = c.String(),
                        Birthday = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TraineeId)
                .ForeignKey("dbo.AspNetUsers", t => t.TraineeId)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.TraineeId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        TrainerId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Birthday = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TrainerId)
                .ForeignKey("dbo.AspNetUsers", t => t.TrainerId)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.TrainerId)
                .Index(t => t.CourseId);
            
            AddColumn("dbo.Categories", "Description", c => c.String(nullable: false));
            AddColumn("dbo.Courses", "Description", c => c.String(nullable: false));
            DropColumn("dbo.Categories", "Dc");
            DropColumn("dbo.Courses", "Dc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Dc", c => c.String(nullable: false));
            AddColumn("dbo.Categories", "Dc", c => c.String(nullable: false));
            DropForeignKey("dbo.Trainers", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Trainers", "TrainerId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Trainees", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Trainees", "TraineeId", "dbo.AspNetUsers");
            DropIndex("dbo.Trainers", new[] { "CourseId" });
            DropIndex("dbo.Trainers", new[] { "TrainerId" });
            DropIndex("dbo.Trainees", new[] { "CourseId" });
            DropIndex("dbo.Trainees", new[] { "TraineeId" });
            DropColumn("dbo.Courses", "Description");
            DropColumn("dbo.Categories", "Description");
            DropTable("dbo.Trainers");
            DropTable("dbo.Trainees");
        }
    }
}
