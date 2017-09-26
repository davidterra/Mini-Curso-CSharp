namespace Exemplo6
{
    public class Movie
    {
        public Movie(string title, int year)
        {
            Title = title;
            Year = year;
        }
        public string Title { get; private set; }
        public int Year { get; private set; }
    }
}
