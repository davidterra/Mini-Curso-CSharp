namespace Exemplo6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Facade
            // Com o Padrão Facade você pode simplificar a utilização de um subsistema complexo implementando uma classe que fornece uma interface única e mais amigável.

            var amplifier = new Amplifier();
            var tuner = new Turner();
            var dvdPlayer = new DvdPlayer();
            var cdPlayer = new CdPlayer();
            var projector = new Projector();
            var screen = new Screen();
            var theaterLigths = new TheaterLigths();
            var popcornPopper = new PopcornPopper();
            var movie = new Movie("Blade Runner", 1982);
            var homeTheater = new HomeTheaterFacade(amplifier, tuner, dvdPlayer, cdPlayer, projector, screen, theaterLigths, popcornPopper);

            homeTheater.WatchMovie(movie);
            homeTheater.EndMovie(movie);

            System.Console.ReadKey();
        }
    }
}
