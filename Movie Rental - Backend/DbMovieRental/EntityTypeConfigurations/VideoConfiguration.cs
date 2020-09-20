using System.Data.Entity.ModelConfiguration;

using Movie_Rental___Backend.DbMovieRental.MovieRentalModel;

namespace Movie_Rental___Backend.DbMovieRental.EntityTypeConfigurations
{
    public class VideoConfiguration : EntityTypeConfiguration<Video>
    {
        public VideoConfiguration()
        {
            Property(v => v.Name).IsRequired().HasMaxLength(255);

            HasRequired(v => v.Genre).WithMany(g => g.Videos).HasForeignKey(v=>v.GenreID);

            HasMany(v => v.Tags).WithMany(t => t.Videos)
                .Map(m =>
                {
                    m.ToTable("VideoTags");
                    m.MapLeftKey("VideoID");
                    m.MapRightKey("TagID");
                });
        }
    }
}
