using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Movie_Rental___Backend.DbMovieRental.MovieRentalModel
{
    public class MovieRentalBackendContext : DbContext
    {
        public MovieRentalBackendContext() : base("name=MovieRentalBackendContext") { }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
