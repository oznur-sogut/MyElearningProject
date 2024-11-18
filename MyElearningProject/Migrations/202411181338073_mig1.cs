namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Testimonials",
                c => new
                    {
                        TestimonialID = c.Int(nullable: false, identity: true),
                        TestimonialNameSurname = c.String(),
                        TestimonialTitle = c.String(),
                        TestimonialImageUrl = c.String(),
                        TestimonialComment = c.String(),
                        TestimonialStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TestimonialID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Testimonials");
        }
    }
}
