using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Movie_Rental___Backend.DbMovieRental.MovieRentalModel
{
    class MovieRentalBackendContext : DbContext
    {
        public MovieRentalBackendContext() : base("name=MovieRentalBackendContext") { }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }

    class Video
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Classification Classification { get; set; }
        public int GenreID { get; set; }
        public Genre Genre { get; set; }      
    }

    class Genre
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IList<Video> Videos { get; set; }
        public Genre()
        {
            Videos = new List<Video>();
        }
    }

    public enum Classification
    {
        Silver = 1,
        Gold = 2,
        Platinum = 3
    }
}
