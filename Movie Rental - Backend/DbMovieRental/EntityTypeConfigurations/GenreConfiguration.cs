using System.Data.Entity.ModelConfiguration;

using Movie_Rental___Backend.DbMovieRental.MovieRentalModel;

namespace Movie_Rental___Backend.DbMovieRental.EntityTypeConfigurations
{
    public class GenreConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            Property(g => g.Name).IsRequired().HasMaxLength(255);
        }
    }
}
