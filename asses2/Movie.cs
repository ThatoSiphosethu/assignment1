public class Movie : Type
{
        public int ID { get; set;}
        public string Title { get; set;}
        public string[] Genres { get; set;}
        private static string File = "movies.csv";

    public override void Display()
    {
        throw new System.NotImplementedException();
    }

    public override void addMovie(int MovieID, string movieTitle, string[] Genre)
    {
       ID = MovieID;
       Title = movieTitle;
       Genres = Genre;
    }

    

    public override void addShow(int ID, string Title, int season, int episode, string[] writers)
    {
        throw new System.NotImplementedException();
    }

    public override void addVideo(int ID, string Title, int length, string format, string[] regions)
    {
        throw new System.NotImplementedException();
    }

    public override void ReadMovie()
    {
        throw new System.NotImplementedException();
    }

    public override void ReadShow()
    {
        throw new System.NotImplementedException();
    }

    public override void ReadVideos()
    {
        throw new System.NotImplementedException();
    }
}