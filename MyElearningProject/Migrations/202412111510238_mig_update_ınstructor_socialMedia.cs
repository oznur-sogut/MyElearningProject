namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_ınstructor_socialMedia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Instructors", "InstructorInstagram", c => c.String());
            AddColumn("dbo.Instructors", "InstructorTwitter", c => c.String());
            AddColumn("dbo.Instructors", "InstructorLinkedin", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Instructors", "InstructorLinkedin");
            DropColumn("dbo.Instructors", "InstructorTwitter");
            DropColumn("dbo.Instructors", "InstructorInstagram");
        }
    }
}
