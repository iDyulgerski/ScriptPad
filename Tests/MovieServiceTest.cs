using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieSeeder;

namespace Tests
{
    internal class MovieServiceTest
    {
        [Test]
        public void AddMovie_WhenValidInput_ShouldAddMovie()
        {
            // Arrange
            var movieService = new MovieService();
            movieService.Path = "test\\URL";
            string title = "Test Movie";
            string imageUrl = "test_image.jpg";
            string note = "This is a test movie";
            int rating = 4;
            DateTime releaseDate = new DateTime(2024, 3, 23);

            // Act
            movieService.AddMovie(title, imageUrl, note, rating, releaseDate);

            // Assert
            using (var db = new MovieDbContext())
            {
                var addedMovie = db.Movies.FirstOrDefault(x => x.Title == title);
                Assert.IsNotNull(addedMovie, "The movie should have been added to the database.");
                Assert.AreEqual(title, addedMovie.Title, "The title of the added movie should match the provided title.");
                Assert.AreEqual("test\\\\URL\\\\" + imageUrl, addedMovie.ImageUrl, "The image URL of the added movie should match the provided image URL.");
                Assert.AreEqual(note, addedMovie.Note, "The note of the added movie should match the provided note.");
                Assert.AreEqual(rating, addedMovie.Rating, "The rating of the added movie should match the provided rating.");
                Assert.AreEqual(releaseDate, addedMovie.ReleaseDate, "The release date of the added movie should match the provided release date.");

                // Cleanup
                db.Movies.Remove(addedMovie);
                db.SaveChanges();
            }
        }


        [Test]
        public void AddMovie_WhenDuplicateTitle_ShouldNotAddMovie()
        {
            // Arrange
            var movieService = new MovieService();
            movieService.Path = "test\\URL";
            string existingTitle = "Existing Movie";
            string existingImageUrl = "existing_image.jpg";
            string existingNote = "This is an existing movie";
            int existingRating = 3;
            DateTime existingReleaseDate = new DateTime(2023, 1, 1);
            movieService.AddMovie(existingTitle, existingImageUrl, existingNote, existingRating, existingReleaseDate);

            // Act
            string duplicateTitle = "Existing Movie";
            string imageUrl = "duplicate_image.jpg";
            string note = "This is a duplicate movie";
            int rating = 5;
            DateTime releaseDate = new DateTime(2024, 3, 24);
            movieService.AddMovie(duplicateTitle, imageUrl, note, rating, releaseDate);

            // Assert
            using (var db = new MovieDbContext())
            {
                var addedMovies = db.Movies.Where(x => x.Title == duplicateTitle).ToList();
                Assert.AreEqual(1, addedMovies.Count, "Only one movie with duplicate title should exist in the database.");
                Assert.AreEqual(existingTitle, addedMovies[0].Title, "The existing movie with the duplicate title should not be replaced.");
                Assert.AreEqual("test\\\\URL\\\\" + existingImageUrl, addedMovies[0].ImageUrl, "The image URL of the existing movie should remain unchanged.");
                Assert.AreEqual(existingNote, addedMovies[0].Note, "The note of the existing movie should remain unchanged.");
                Assert.AreEqual(existingRating, addedMovies[0].Rating, "The rating of the existing movie should remain unchanged.");
                Assert.AreEqual(existingReleaseDate, addedMovies[0].ReleaseDate, "The release date of the existing movie should remain unchanged.");
            }

            // Cleanup
            using (var db = new MovieDbContext())
            {
                var duplicateMovie = db.Movies.FirstOrDefault(x => x.Title == duplicateTitle);
                if (duplicateMovie != null)
                {
                    db.Movies.Remove(duplicateMovie);
                    db.SaveChanges();
                }
            }
        }

    }
}
