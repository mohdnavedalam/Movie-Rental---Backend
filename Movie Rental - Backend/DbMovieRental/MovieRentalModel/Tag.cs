using System.Collections.Generic;

namespace Movie_Rental___Backend.DbMovieRental.MovieRentalModel
{
    public class Tag
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IList<Video> Videos { get; set; }
        public Tag()
        {
            Videos = new List<Video>();
        }
    }
}
