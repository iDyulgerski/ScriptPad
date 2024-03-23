using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptPad
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Note { get; set; }
        public int Rating { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Movie()
        { }

        public Movie(string title, string ImageUrl, string note, int rating, DateTime releaseDate)
        {
            Title = title;
            this.ImageUrl = ImageUrl;
            this.Note = note;
            Rating = rating;
            ReleaseDate = releaseDate;
        }

        public void Copy(Movie movie)
        {
            Title = movie.Title;
            ImageUrl = movie.ImageUrl;
            Note = movie.Note;
            Rating = movie.Rating;
            ReleaseDate = movie.ReleaseDate;
        }

        public void Update(Movie editedMovie)
        {
            this.Title = editedMovie.Title;
            this.ImageUrl = editedMovie.ImageUrl;
            this.Note = editedMovie.Note;
            this.Rating = editedMovie.Rating;
            this.ReleaseDate = editedMovie.ReleaseDate;
        }
    }
}
