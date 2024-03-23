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
        public void AddMovie(string title, string imageUrl, string note, int rating, DateTime releaseDate)
        {
            this.EnsureDbCreated();

            var movie = new Movie
            {
                Title = title,
                ImageUrl = "D:\\IT career\\VII modul\\ScriptPadSolution\\MovieSeeder\\pictures\\Movies\\" + imageUrl,
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

    }
}
