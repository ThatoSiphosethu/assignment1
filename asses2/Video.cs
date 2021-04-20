public class Video : Type
{
        public int ID { get; set;}
        public string Title { get; set;}
        public int length { get; set;}

        public string format {get; set;}
        public string[] regions{get; set;}
        private static string File = "video.csv";

    public override void Display()
    {
        throw new System.NotImplementedException();
    }

    public override void addMovie(int MovieID, string movieTitle, string[] Genre)
    {
        throw new System.NotImplementedException();
    }

    public override void addShow(int ID, string Title, int season, int episode, string[] writers)
    {
        throw new System.NotImplementedException();
    }
    public override void addVideo(int ID, string Title, int length,string format, string[] regions)
    {
       // ID = VideoID;
        //Title = VideoTitle;
        //length = VideoLength;
        //format = VideoFormat;
        //regions = Regions;
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
        