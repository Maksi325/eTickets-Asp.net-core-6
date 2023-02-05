using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContent>();

                context.Database.EnsureCreated();

                //ClearDb(applicationBuilder);


                //Cinema 
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema(){
                            Name = "Cinema 1",
                            Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSOvKbvRwl9z2o20Vc5-0ecKaCXeksK8u7JcQ&usqp=CAU",
                            Description = "This is description of the first cinema"
                        },
                        new Cinema(){
                            Name = "Cinema 2",
                            Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSOvKbvRwl9z2o20Vc5-0ecKaCXeksK8u7JcQ&usqp=CAU",
                            Description = "This is description of the second cinema"
                        },
                        new Cinema(){
                            Name = "Cinema 3",
                            Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSOvKbvRwl9z2o20Vc5-0ecKaCXeksK8u7JcQ&usqp=CAU",
                            Description = "This is description of the third cinema"
                        },
                        new Cinema(){
                            Name = "Cinema 4",
                            Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSOvKbvRwl9z2o20Vc5-0ecKaCXeksK8u7JcQ&usqp=CAU",
                            Description = "This is description of the fourth cinema"
                        }
                    });
                    context.SaveChanges();
                }
                //Actors 
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>() {
                        new Actor()  {
                            FullName = "Actor 1",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-1.jpeg",
                            Bio = "This is the bio of the first Actor"
                        },
                        new Actor()  {
                            FullName = "Actor 2",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-2.jpeg",
                            Bio = "This is the bio of the first Actor"
                        },
                        new Actor()  {
                            FullName = "Actor 3",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-3.jpeg",
                            Bio = "This is the bio of the first Actor"
                        },
                        new Actor()  {
                            FullName = "Actor 4",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-4.jpeg",
                            Bio = "This is the bio of the first Actor"
                        },
                        new Actor()  {
                            FullName = "Actor 5",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-5.jpeg",
                            Bio = "This is the bio of the first Actor"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers 
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>() {
                        new Producer()
                        {
                            FullName = "Actor 1",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-1.jpeg",
                            Bio = "This is the bio of the first Actor"
                        },
                        new Producer()
                        {
                            FullName = "Actor 2",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-2.jpeg",
                            Bio = "This is the bio of the first Actor"
                        },
                        new Producer()
                        {
                            FullName = "Actor 3",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-3.jpeg",
                            Bio = "This is the bio of the third producer"
                        },
                        new Producer()
                        {
                            FullName = "Actor 4",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-4.jpeg",
                            Bio = "This is the bio of the fourth Producer"
                        }
                        });
                    context.SaveChanges();
                }
                //Movies 
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>(){
                        new Movie(){
                            Name = "The Shawshank Redemption",
                            Description = "This is the 'The Shawshank Redemption' movie description",
                            Price = 33.9,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 4,
                            MovieCategory = Enums.MovieCategory.Mister
                        },
                        new Movie(){
                            Name = "No Country For Old Men",
                            Description = "This is the 'No Country For Old Men' movie description",
                            Price = 42,
                            ImageURL = "http://dotnethow.net/images/movies/movie-2.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId =3,
                            ProducerId = 1,
                            MovieCategory = Enums.MovieCategory.Action
                        },
                        new Movie(){
                            Name = "life",
                            Description = "this is the 'life' movie description",
                            Price = 54.9,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 3,
                            ProducerId = 2,
                            MovieCategory = Enums.MovieCategory.Adventure
                        },
                        new Movie() {
                            Name = "Ghost",
                            Description = "This is the 'Ghost' movie description",
                            Price = 10.5,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 4,
                            ProducerId = 1,
                            MovieCategory = Enums.MovieCategory.Horror
                        },
                        new Movie() {
                            Name = "Old Boy",
                            Description = "This is the 'Old Boy' movie description",
                            Price = 36.9,
                            ImageURL = "http://dotnethow.net/images/movies/movie-5.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = Enums.MovieCategory.Comedy
                        },
                        new Movie() {
                            Name = "Race",
                            Description = "This is the 'Race' movie description",
                            Price = 39.9,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 2,
                            ProducerId = 2,
                            MovieCategory = Enums.MovieCategory.Action
                        },
                        new Movie(){
                            Name = "Scoob",
                            Description = "This is the 'Scoob' movie description",
                            Price = 39.5,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 3,
                            ProducerId = 1,
                            MovieCategory = Enums.MovieCategory.Comedy
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie(){
                            MovieId = 1,
                            ActorId = 2
                        },
                        new Actor_Movie(){
                            MovieId = 1,
                            ActorId = 3
                        },
                        new Actor_Movie(){
                            MovieId = 1,
                            ActorId = 5
                        },
                        new Actor_Movie(){
                            MovieId = 2,
                            ActorId = 2
                        },
                        new Actor_Movie(){
                            MovieId = 2,
                            ActorId = 5
                        },
                        new Actor_Movie(){
                            MovieId = 3,
                            ActorId = 1
                        },
                        new Actor_Movie(){
                            MovieId = 3,
                            ActorId = 3
                        },
                        new Actor_Movie(){
                            MovieId = 3,
                            ActorId = 4
                        },
                        new Actor_Movie(){
                            MovieId = 4,
                            ActorId = 1
                        },
                        new Actor_Movie(){
                            MovieId = 4,
                            ActorId = 3
                        },
                        new Actor_Movie(){
                            MovieId = 4,
                            ActorId = 4
                        },
                        new Actor_Movie(){
                            MovieId = 5,
                            ActorId = 5
                        },
                        new Actor_Movie(){
                            MovieId = 6,
                            ActorId = 1
                        },
                        new Actor_Movie(){
                            MovieId = 6,
                            ActorId = 5
                        }
                    });
                    context.SaveChanges();
                }
            }
        }

        public static void ClearDb(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContent>();

                context.Database.EnsureCreated();

                //Clear the Data stored in Db
                context.Cinemas.RemoveRange(context.Cinemas);
                context.Actors.RemoveRange(context.Actors);
                context.Producers.RemoveRange(context.Producers);
                context.Movies.RemoveRange(context.Movies);
                context.Actors_Movies.RemoveRange(context.Actors_Movies);

                context.SaveChanges();
            }
        }
    }
}
