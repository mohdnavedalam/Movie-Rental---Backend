namespace Movie_Rental___Backend.DbMovieRental.MovieRentalMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyRelationshipTablesVideoGenre : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.VideoGenres", "Video_ID", "dbo.Videos");
            DropForeignKey("dbo.VideoGenres", "Genre_ID", "dbo.Genres");
            DropIndex("dbo.VideoGenres", new[] { "Video_ID" });
            DropIndex("dbo.VideoGenres", new[] { "Genre_ID" });
            AddColumn("dbo.Videos", "GenreID", c => c.Int(nullable: false));
            CreateIndex("dbo.Videos", "GenreID");
            AddForeignKey("dbo.Videos", "GenreID", "dbo.Genres", "ID", cascadeDelete: true);
            DropTable("dbo.VideoGenres");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.VideoGenres",
                c => new
                    {
                        Video_ID = c.Int(nullable: false),
                        Genre_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Video_ID, t.Genre_ID });
            
            DropForeignKey("dbo.Videos", "GenreID", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "GenreID" });
            DropColumn("dbo.Videos", "GenreID");
            CreateIndex("dbo.VideoGenres", "Genre_ID");
            CreateIndex("dbo.VideoGenres", "Video_ID");
            AddForeignKey("dbo.VideoGenres", "Genre_ID", "dbo.Genres", "ID", cascadeDelete: true);
            AddForeignKey("dbo.VideoGenres", "Video_ID", "dbo.Videos", "ID", cascadeDelete: true);
        }
    }
}
