namespace Exemplo6
{
    public class HomeTheaterFacade
    {
        private readonly TheaterLigths _lights;
        private readonly PopcornPopper _popper;
        private readonly Screen _screen;
        private readonly Projector _projector;
        private readonly CdPlayer _cd;
        private readonly DvdPlayer _dvd;
        private readonly Turner _turner;
        private readonly Amplifier _amp;
       

        //214
        public HomeTheaterFacade(Amplifier amp, 
            Turner turner, 
            DvdPlayer dvd, 
            CdPlayer cd,
            Projector projector,
            Screen screen,
            TheaterLigths lights,
            PopcornPopper popper)
        {
            this._amp = amp;
            this._turner = turner;
            this._dvd = dvd;
            this._cd = cd;
            this._projector = projector;
            this._screen = screen;            
            this._popper = popper;
            this._lights = lights;
        }

        public void WatchMovie(Movie movie)
        {
            System.Console.WriteLine("Get ready to watch a movie...");
            _popper.On();
            _popper.Pop();
            _lights.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amp.On();
            _amp.SetDvd(_dvd);
            _amp.SetSurroundSound();
            _amp.SetVolume(5);
            _dvd.On();
            _dvd.Play(movie.Title);
        }

        public void EndMovie(Movie movie)
        {
            System.Console.WriteLine("Shutting movie theater down...");
            _popper.Off();
            _lights.On();
            _screen.Up();
            _projector.Off();
            _amp.Off();
            _dvd.Stop(movie.Title);
            _dvd.Eject();
            _dvd.Off();
        }
    }
}
