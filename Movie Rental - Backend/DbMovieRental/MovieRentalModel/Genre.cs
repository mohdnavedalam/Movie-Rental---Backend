using System.Collections.Generic;

namespace Movie_Rental___Backend.DbMovieRental.MovieRentalModel
{
    public class Genre
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IList<Video> Videos { get; set; }
        public Genre()
        {
            Videos = new List<Video>();
        }
    }
}
