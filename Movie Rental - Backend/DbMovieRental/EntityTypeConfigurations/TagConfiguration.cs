using System.Data.Entity.ModelConfiguration;
using Movie_Rental___Backend.DbMovieRental.MovieRentalModel;

namespace Movie_Rental___Backend.DbMovieRental.EntityTypeConfigurations
{
    public class TagConfiguration : EntityTypeConfiguration<Tag>
    {
        public TagConfiguration()
        {
            Property(t => t.Name).IsRequired().HasMaxLength(255);
        }
    }
}
