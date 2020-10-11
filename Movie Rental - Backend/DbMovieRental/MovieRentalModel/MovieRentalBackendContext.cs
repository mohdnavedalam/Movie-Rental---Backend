using System.Data.Entity;

using Movie_Rental___Backend.DbMovieRental.EntityTypeConfigurations;

namespace Movie_Rental___Backend.DbMovieRental.MovieRentalModel
{
    public class MovieRentalBackendContext : DbContext
    {
        public MovieRentalBackendContext() : base("name=MovieRentalBackendContext") { }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VideoConfiguration());
            modelBuilder.Configurations.Add(new GenreConfiguration());
            modelBuilder.Configurations.Add(new TagConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
