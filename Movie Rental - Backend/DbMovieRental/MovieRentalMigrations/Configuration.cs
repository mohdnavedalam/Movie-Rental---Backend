namespace Movie_Rental___Backend.DbMovieRental.MovieRentalMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MovieRentalModel;

    internal sealed class Configuration : DbMigrationsConfiguration<Movie_Rental___Backend.DbMovieRental.MovieRentalModel.MovieRentalBackendContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DbMovieRental\MovieRentalMigrations";
        }

        protected override void Seed(Movie_Rental___Backend.DbMovieRental.MovieRentalModel.MovieRentalBackendContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Videos.AddOrUpdate(v => v.ID, new Video
            {
                ID = 1,
                Name = "The Godfather",
                ReleaseDate = new DateTime(1972, 3, 24),
                Classification = Classification.Platinum,
                GenreID = 7
            });

            context.Videos.AddOrUpdate(v => v.ID, new Video
            {
                ID = 2,
                Name = "The Shawshank Redemption",
                ReleaseDate = new DateTime(1994, 9, 14),
                Classification = Classification.Gold,
                GenreID = 7
            });

            context.Videos.AddOrUpdate(v => v.ID, new Video
            {
                ID = 3,
                Name = "Schindler's List",
                ReleaseDate = new DateTime(1994, 2, 4),
                Classification = Classification.Gold,
                GenreID = 7
            });

            context.Videos.AddOrUpdate(v => v.ID, new Video
            {
                ID = 4,
                Name = "The Hangover",
                ReleaseDate = new DateTime(2009, 6, 11),
                Classification = Classification.Gold,
                GenreID = 1
            });

            context.Videos.AddOrUpdate(v => v.ID, new Video
            {
                ID = 5,
                Name = "Anchorman",
                ReleaseDate = new DateTime(2004, 4, 11),
                Classification = Classification.Silver,
                GenreID = 1
            });

            context.Videos.AddOrUpdate(v => v.ID, new Video
            {
                ID = 6,
                Name = "Die Hard",
                ReleaseDate = new DateTime(1988, 6, 13),
                Classification = Classification.Gold,
                GenreID = 2
            });

            context.Videos.AddOrUpdate(v => v.ID, new Video
            {
                ID = 7,
                Name = "The Dark Knight",
                ReleaseDate = new DateTime(2008, 1, 5),
                Classification = Classification.Gold,
                GenreID = 2
            });

            context.Videos.AddOrUpdate(v => v.ID, new Video
            {
                ID = 8,
                Name = "Terminator 2: Judgment Day",
                ReleaseDate = new DateTime(1991, 5, 15),
                Classification = Classification.Platinum,
                GenreID = 2
            });
        }
    }
}
