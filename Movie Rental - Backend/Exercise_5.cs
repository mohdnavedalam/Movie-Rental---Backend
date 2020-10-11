using Movie_Rental___Backend.DbMovieRental.MovieRentalModel;
using System;
using System.Data.Entity;
using System.Linq;

namespace Movie_Rental___Backend
{
    class Exercise_5
    {
        internal static void AddVideo(Video video)
        {
            using(var context = new MovieRentalBackendContext())
            {
                context.Videos.Add(video);
                context.SaveChanges();
            }
        }

        internal static void AddTags(params string[] tagNames)
        {
            using(var context = new MovieRentalBackendContext())
            {
                //First load tags with the given names to prevent adding duplicates.
                var tags = context.Tags.Where(t => tagNames.Contains(t.Name)).ToList();
                foreach(var name in tagNames)
                {
                    if (!tags.Any(t => t.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase)))
                        context.Tags.Add(new Tag { Name = name });
                }
                context.SaveChanges();
            }
        }

        internal static void AddTagsToVideo(int videoID, params string[] tagNames)
        {
            using(var context = new MovieRentalBackendContext())
            {
                var tags = context.Tags.Where(t => tagNames.Contains(t.Name)).ToList();
                foreach(var tagName in tagNames)
                {
                    if (!tags.Any(t => t.Name.Equals(tagName, StringComparison.CurrentCultureIgnoreCase)))
                        tags.Add(new Tag { Name = tagName });
                }
                var video = context.Videos.Single(v => v.ID == videoID);
                tags.ForEach(t => video.AddTag(t));
                context.SaveChanges();
            }
        }

        internal static void RemoveTagsFromVideo(int videoID, params string[] tagNames)
        {
            using(var context = new MovieRentalBackendContext())
            {
                //Explicit loading could be used to only load tags that are needed to be deleted.
                context.Tags.Where(t => tagNames.Contains(t.Name)).Load();
                var video = context.Videos.Single(v => v.ID == videoID);
                foreach(var tagName in tagNames)
                {
                    // The concept of removing a tag has been encapsulated inside the Video class. 
                    // This is the object-oriented way to implement this. The Video class
                    // should be responsible for adding/removing objects to its Tags collection. 
                    video.RemoveTag(tagName); 
                }
                context.SaveChanges();
            }
        }

        internal static void RemoveVideo(int videoID)
        {
            using(var context = new MovieRentalBackendContext())
            {
                var video = context.Videos.SingleOrDefault(v => v.ID == videoID);
                if (video == null) return;

                context.Videos.Remove(video);
                context.SaveChanges();
            }
        }

        internal static void RemoveGenre(int genreID, bool enforceDeletingVideos)
        {
            using(var context = new MovieRentalBackendContext())
            {
                var genre = context.Genres.Include(g => g.Videos).SingleOrDefault(g => g.ID == genreID);
                if (genre == null) return;

                if (enforceDeletingVideos)
                    context.Videos.RemoveRange(genre.Videos);

                context.Genres.Remove(genre);
                context.SaveChanges();
            }
        }
    }
}
