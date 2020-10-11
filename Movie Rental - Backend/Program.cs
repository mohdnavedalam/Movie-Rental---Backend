using Movie_Rental___Backend.DbMovieRental.MovieRentalModel;
using System;

namespace Movie_Rental___Backend
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise_3.ExecuteExercise_3();

            //Exercise 5:
            //Task - 1
            //Here, the GenreID is hardcoded to 2.
            //In a real-world application,
            // the user often selects the genre from a drop-down list. There, you should
            // have the Id for each genre. If you're building a WPF application, this 
            // GenreId is already in the memory. If you're building an ASP.NET MVC application,
            // the GenreId is posted with the request and you can set it here. 
            Exercise_5.AddVideo(new Video
            {
                Name = "Terminator 1",
                GenreID = 2,
                Classification = Classification.Silver,
                ReleaseDate = new DateTime(1984, 10, 26)
            });

            // Task - 2
            Exercise_5.AddTags("classics", "drama");

            //Task - 3
            Exercise_5.AddTagsToVideo(1, "classics", "drama", "comedy");

            //Task - 4
            Exercise_5.RemoveTagsFromVideo(1, "comedy"); // Can't remove the tag. Pending

            //Task - 5
            Exercise_5.RemoveVideo(1); // Check if the video with the given ID exists

            //Task - 6
            Exercise_5.RemoveGenre(2, true);

            // The Exercise - 5 methods need validations.
            // They are behaving erratically.
            // Look into this.
        }
    }
}
