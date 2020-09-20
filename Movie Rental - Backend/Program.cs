using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Movie_Rental___Backend.DbMovieRental.MovieRentalModel;

namespace Movie_Rental___Backend
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new MovieRentalBackendContext();

            Console.WriteLine("Action Movies Sorted by Name by Name First\n");

            var ActionMoviesByName = context.Videos.Where(v => v.Genre.Name == "Action").OrderBy(v => v.Name);

            foreach (var x in ActionMoviesByName)
                Console.WriteLine(x.Name);

            Console.WriteLine("\n\n\n");

            Console.WriteLine("Gold Drama Movies by Name by Newest First\n");

            var GoldDramaMoviesByNewestFirst = context.Videos
                .Where(v => v.Genre.Name == "Drama" && v.Classification == Classification.Gold)
                .OrderByDescending(v => v.ReleaseDate);

            foreach(var x in GoldDramaMoviesByNewestFirst)
                Console.WriteLine(x.Name);

            Console.WriteLine("\n\n\n");

            Console.WriteLine("All movies projected into an anonymous type with two properties\n");

            var MoviesWithTwoProperties = context.Videos
                .Select(v => new { MovieName = v.Name, Genre = v.Genre.Name });

            foreach(var x in MoviesWithTwoProperties)
                Console.WriteLine("{0}\t{1}", x.Genre, x.MovieName);

            Console.WriteLine("\n\n\n");

            Console.WriteLine("All movies grouped by their classification\n");

            var MoviesGroupedByClassification = context.Videos
                .GroupBy(v => v.Classification)
                .Select(g => new
                {
                    Classification = g.Key.ToString(),
                    Videos = g.OrderBy(v => v.Name)
                });

            foreach(var x in MoviesGroupedByClassification)
            {
                Console.WriteLine("Classification : {0}", x.Classification);

                foreach(var y in x.Videos)
                    Console.WriteLine("\t{0}", y.Name);
            }

            Console.WriteLine("\n\n\n");

            Console.WriteLine("List of classifications sorted alphabetically and count of videos in them\n");

            var VideosCountByClassification = context.Videos
                .GroupBy(v => v.Classification)
                .Select(v => new
                {
                    Classification = v.Key.ToString(),
                    Videos = v.Count()
                })
                .OrderBy(c => c.Classification);

            foreach(var x in VideosCountByClassification)
                Console.WriteLine("{0}({1})", x.Classification, x.Videos);

            Console.WriteLine("\n\n\n");

            Console.WriteLine("List of genres and number of videos they include, sorted by the number of videos\n");

            var GenresCountByNumber = context.Genres
                .GroupJoin(context.Videos, g => g.ID, v => v.GenreID, (genre, videos) => new
                {
                    Name = genre.Name,
                    VideosCount = videos.Count()
                })
                .OrderByDescending(g => g.VideosCount);

            foreach(var x in GenresCountByNumber)
                Console.WriteLine("{0}({1})", x.Name, x.VideosCount);

            Console.WriteLine("\n\n\n");

            var abcde = context.Videos
                .GroupBy(v => v.Genre.Name)
                .Select(g => new
                {
                    GenreName = g.Key.ToString(),
                    VideosCount = g.Count()
                })
                .OrderByDescending(c => c.VideosCount);

            foreach(var x in abcde)
                Console.WriteLine("{0}({1})", x.GenreName, x.VideosCount);
        }
    }
}
