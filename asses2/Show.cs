public class Show : Type
{
        public int ID { get; set;}
        public string Title { get; set;}
        public int season { get; set;}
        public int episode { get; set;}
        public string[] writers { get; set;}
        private static string File = "shows.csv";

    public override void Display()
    {
        throw new System.NotImplementedException();
    }


    public override void addMovie(int MovieID, string movieTitle, string[] Genre)
    {
        throw new System.NotImplementedException();
    }
   

    public override void addVideo(int ID, string Title, int length, string format, string[] regions)
    {
        throw new System.NotImplementedException();
    }

   public override void addShow(int ID, string Title, int season, int episode, string[] writers)
    {
        throw new System.NotImplementedException();
    }

    internal void addShow(int showID, object title, int season, int episode, string[] stringArray)
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