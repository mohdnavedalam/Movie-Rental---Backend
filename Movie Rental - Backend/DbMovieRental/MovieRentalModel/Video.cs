using System;
using System.Collections.Generic;

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
        public IList<Tag> Tags { get; set; }
        public Video()
        {
            Tags = new List<Tag>();
        }
    }
}
