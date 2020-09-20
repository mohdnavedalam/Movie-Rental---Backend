namespace Movie_Rental___Backend.DbMovieRental.MovieRentalMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableTagsRelateWithTableVideosSetNamesOfColumnsForTableVideoTag : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VideoTags",
                c => new
                    {
                        VideoID = c.Int(nullable: false),
                        TagID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.VideoID, t.TagID })
                .ForeignKey("dbo.Videos", t => t.VideoID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.VideoID)
                .Index(t => t.TagID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VideoTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.VideoTags", "VideoID", "dbo.Videos");
            DropIndex("dbo.VideoTags", new[] { "TagID" });
            DropIndex("dbo.VideoTags", new[] { "VideoID" });
            DropTable("dbo.VideoTags");
            DropTable("dbo.Tags");
        }
    }
}
