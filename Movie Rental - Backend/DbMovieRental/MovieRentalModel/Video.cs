using System;

namespace Movie_Rental___Backend.DbMovieRental.MovieRentalModel
{
    public class Video
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Classification Classification { get; set; }
        public int GenreID { get; set; }
        public Genre Genre { get; set; }      
    }
}
