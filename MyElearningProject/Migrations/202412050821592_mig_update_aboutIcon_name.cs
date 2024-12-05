namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_aboutIcon_name : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "AboutIcon", c => c.String());
            DropColumn("dbo.Abouts", "AboutCard");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abouts", "AboutCard", c => c.String());
            DropColumn("dbo.Abouts", "AboutIcon");
        }
    }
}
