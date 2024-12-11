namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_carousel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carousels",
                c => new
                    {
                        CarouselID = c.Int(nullable: false, identity: true),
                        CarouselImageUrl = c.String(),
                        CarouselTitle = c.String(),
                        CarouselDescription = c.String(),
                    })
                .PrimaryKey(t => t.CarouselID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Carousels");
        }
    }
}
