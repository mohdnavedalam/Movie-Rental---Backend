namespace Movie_Rental___Backend.DbMovieRental.MovieRentalMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

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
        }
    }
}
