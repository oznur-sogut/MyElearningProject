namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_relation_course_instructor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "InstructorID", c => c.Int(nullable: false));
            AddColumn("dbo.Instructors", "Instructor_InstructorID", c => c.Int());
            CreateIndex("dbo.Courses", "InstructorID");
            CreateIndex("dbo.Instructors", "Instructor_InstructorID");
            AddForeignKey("dbo.Instructors", "Instructor_InstructorID", "dbo.Instructors", "InstructorID");
            AddForeignKey("dbo.Courses", "InstructorID", "dbo.Instructors", "InstructorID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "InstructorID", "dbo.Instructors");
            DropForeignKey("dbo.Instructors", "Instructor_InstructorID", "dbo.Instructors");
            DropIndex("dbo.Instructors", new[] { "Instructor_InstructorID" });
            DropIndex("dbo.Courses", new[] { "InstructorID" });
            DropColumn("dbo.Instructors", "Instructor_InstructorID");
            DropColumn("dbo.Courses", "InstructorID");
        }
    }
}
