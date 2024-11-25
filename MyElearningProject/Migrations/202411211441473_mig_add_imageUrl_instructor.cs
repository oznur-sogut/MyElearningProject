﻿namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_imageUrl_instructor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Instructors", "InstructorImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Instructors", "InstructorImageUrl");
        }
    }
}
