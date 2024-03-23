using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSeeder
{
    public class MovieDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=scriptpad;user=root;password=1234;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
