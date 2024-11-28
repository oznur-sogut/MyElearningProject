namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_instructor_coverImage_and_title : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Instructors", "InstructorTitle", c => c.String());
            AddColumn("dbo.Instructors", "InstructorCoverImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Instructors", "InstructorCoverImage");
            DropColumn("dbo.Instructors", "InstructorTitle");
        }
    }
}
