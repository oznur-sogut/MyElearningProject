namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_instructor : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Instructors", "Instructor_InstructorID", "dbo.Instructors");
            DropIndex("dbo.Instructors", new[] { "Instructor_InstructorID" });
            CreateTable(
                "dbo.CourseRegisters",
                c => new
                    {
                        CourseRegisterID = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CourseRegisterID)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.CourseID);
            
            DropColumn("dbo.Instructors", "Instructor_InstructorID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Instructors", "Instructor_InstructorID", c => c.Int());
            DropForeignKey("dbo.CourseRegisters", "StudentID", "dbo.Students");
            DropForeignKey("dbo.CourseRegisters", "CourseID", "dbo.Courses");
            DropIndex("dbo.CourseRegisters", new[] { "CourseID" });
            DropIndex("dbo.CourseRegisters", new[] { "StudentID" });
            DropTable("dbo.CourseRegisters");
            CreateIndex("dbo.Instructors", "Instructor_InstructorID");
            AddForeignKey("dbo.Instructors", "Instructor_InstructorID", "dbo.Instructors", "InstructorID");
        }
    }
}
