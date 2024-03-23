namespace MovieSeeder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieService movieService = new MovieService();
            Console.Write("Enter your pictures folder path here: ");
            string path = Console.ReadLine();
            movieService.Path = path;

            // Add movie 1
            movieService.AddMovie("The Shawshank Redemption",
                "shawshank_redemption.jpg",
                "A timeless classic that explores the human spirit and friendship.",
                10,
                new DateTime(1994, 10, 14));

            // Add movie 2
            movieService.AddMovie("The Godfather",
                "the_godfather.jpg",
                "An epic tale of power, family, and loyalty in the mafia underworld.",
                10,
                new DateTime(1972, 3, 24));

            // Add movie 3
            movieService.AddMovie("The Dark Knight",
                "the_dark_knight.jpg",
                "A gripping and intense superhero film with stellar performances.",
                9,
                new DateTime(2008, 7, 18));

            // Add movie 4
            movieService.AddMovie("The Lord of the Rings: The Return of the King",
                "return_of_the_king.jpg",
                "A breathtaking conclusion to the epic fantasy trilogy.",
                10,
                new DateTime(2003, 12, 17));

            // Add movie 5
            movieService.AddMovie("Pulp Fiction",
                "pulp_fiction.jpg",
                "A bold and stylish film that redefined the crime genre.",
                9,
                new DateTime(1994, 10, 14));

            // Add movie 6
            movieService.AddMovie("Forrest Gump",
                "forrest_gump.jpg",
                "A heartwarming tale of an unlikely hero's journey through history.",
                9,
                new DateTime(1994, 7, 6));

            // Add movie 7
            movieService.AddMovie("Inception",
                "inception.jpg",
                "A mind-bending thriller that challenges perception and reality.",
                9,
                new DateTime(2010, 7, 16));

            // Add movie 8
            movieService.AddMovie("The Matrix",
                "the_matrix.jpg",
                "An action-packed sci-fi adventure with groundbreaking special effects.",
                9,
                new DateTime(1999, 3, 31));

            // Add movie 9
            movieService.AddMovie("Schindler's List",
                "schindlers_list.jpg",
                "A powerful and moving portrayal of courage and humanity during the Holocaust.",
                10,
                new DateTime(1993, 12, 15));

            // Add movie 10
            movieService.AddMovie("Fight Club",
                "fight_club.jpg",
                "A provocative exploration of masculinity and consumerism.",
                9,
                new DateTime(1999, 10, 15));

            // Add movie 11
            movieService.AddMovie("Goodfellas",
                "goodfellas.jpg",
                "A gripping and authentic portrayal of organized crime.",
                9,
                new DateTime(1990, 9, 19));

            // Add movie 12
            movieService.AddMovie("The Silence of the Lambs",
                "silence_of_the_lambs.jpg",
                "A chilling psychological thriller with iconic performances.",
                9,
                new DateTime(1991, 2, 14));

            // Add movie 13
            movieService.AddMovie("Saving Private Ryan",
                "saving_private_ryan.jpg",
                "A visceral and emotionally powerful depiction of war.",
                9,
                new DateTime(1998, 7, 24));

            // Add movie 14
            movieService.AddMovie("The Green Mile",
                "the_green_mile.jpg",
                "A touching and profound story of miracles and redemption.",
                9,
                new DateTime(1999, 12, 10));

            // Add movie 15
            movieService.AddMovie("The Departed",
                "the_departed.jpg",
                "A tense and thrilling tale of crime and corruption.",
                9,
                new DateTime(2006, 10, 6));

            // Add movie 16
            movieService.AddMovie("Gladiator",
                "gladiator.jpg",
                "An epic historical drama with breathtaking action sequences.",
                9,
                new DateTime(2000, 5, 5));

            // Add movie 17
            movieService.AddMovie("Interstellar",
                "interstellar.jpg",
                "A visually stunning and intellectually stimulating sci-fi epic.",
                9,
                new DateTime(2014, 11, 7));

            // Add movie 18
            movieService.AddMovie("The Godfather: Part II",
                "the_godfather_part_ii.jpg",
                "A compelling continuation of the Corleone family saga.",
                10,
                new DateTime(1974, 12, 20));

            // Add movie 19
            movieService.AddMovie("The Prestige",
                "the_prestige.jpg",
                "A mesmerizing and intricate tale of rivalry and obsession.",
                9,
                new DateTime(2006, 10, 20));

            // Add movie 20
            movieService.AddMovie("The Usual Suspects",
                "the_usual_suspects.jpg",
                "A brilliantly crafted mystery with a mind-blowing twist ending.",
                9,
                new DateTime(1995, 8, 16));

            // Add movie 21
            movieService.AddMovie("Amélie",
                "amelie.jpg",
                "A whimsical and charming romantic comedy set in Paris.",
                9,
                new DateTime(2001, 4, 25));

            // Add movie 22
            movieService.AddMovie("Death Becomes Her",
                "death_becomes_her.jpg",
                "A darkly comedic tale of vanity and immortality.",
                8,
                new DateTime(1992, 7, 31));

            // Add movie 23
            movieService.AddMovie("Everything, Everywhere, All at Once",
                "everything_everywhere_all_at_once.jpg",
                "A mind-bending and genre-bending journey through multiple dimensions.",
                9,
                new DateTime(2022, 3, 25));

            // Add movie 24
            movieService.AddMovie("Shrek",
                "shrek.jpg",
                "A hilarious and heartwarming fairy tale parody.",
                9,
                new DateTime(2001, 4, 22));

            // Add movie 25
            movieService.AddMovie("Shrek 2",
                "shrek_2.jpg",
                "A delightful sequel with more humor and memorable characters.",
                8,
                new DateTime(2004, 5, 19));

            // Add movie 26
            movieService.AddMovie("Shrek the Third",
                "shrek_the_third.jpg",
                "An entertaining continuation of the Shrek saga with new adventures.",
                7,
                new DateTime(2007, 5, 6));

            // Add movie 27
            movieService.AddMovie("Shrek Forever After",
                "shrek_forever_after.jpg",
                "A satisfying conclusion to the Shrek series with a fresh twist.",
                7,
                new DateTime(2010, 5, 16));

            // Add movie 28
            movieService.AddMovie("Whiplash",
                "whiplash.jpg",
                "An intense and gripping drama about the pursuit of greatness in music.",
                9,
                new DateTime(2014, 10, 10));

            // Add movie 29
            movieService.AddMovie("Avatar",
                "avatar.jpg",
                "A visually stunning sci-fi epic set on the alien world of Pandora.",
                9,
                new DateTime(2009, 12, 18));

            // Add movie 30
            movieService.AddMovie("Avatar 2",
                "avatar_2.jpg",
                "The highly anticipated sequel to the groundbreaking original.",
                -1, // You may not have a rating yet for Avatar 2 as it's not released at the time of this response.
                new DateTime(2022, 12, 16)); // Adjust release date if necessary.

        }
    }
}
