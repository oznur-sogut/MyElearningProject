namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_student_imageUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "StudentImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "StudentImageUrl");
        }
    }
}
