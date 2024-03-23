using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSeeder
{
    public class MovieService
    {
        private MovieDbContext db = new MovieDbContext();
        public string Path { get; set; }
        public void AddMovie(string title, string imageUrl, string note, int rating, DateTime releaseDate)
        {
            this.EnsureDbCreated();

            var movie = new Movie
            {
                Title = title,
                ImageUrl = ConvertPath(Path) + imageUrl,
                Note = note,
                Rating = rating,
                ReleaseDate = releaseDate
            };

            if (db.Movies.Any(x => x.Title == title))
            {
                return;
            }
            db.Movies.Add(movie);
            db.SaveChanges();
        }

        private void EnsureDbCreated()
        {
            db.Database.EnsureCreated();
        }
        static string ConvertPath(string inputPath)
        {
            // Replace backslashes with double backslashes
            inputPath = inputPath.Replace("\\", "\\\\");
            string outputPath = inputPath + "\\\\";
            return outputPath;
        }
    }
    
}
