using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSeeder
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Note { get; set; }
        public int Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}