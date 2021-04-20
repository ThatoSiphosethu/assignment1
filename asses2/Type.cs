public abstract class Type
{
    public abstract void Display();

    public abstract void addMovie(int MovieID, string movieTitle, string[] Genre);

    public abstract void addShow(int ID,string Title, int season, int episode, string[] writers);

    public abstract void addVideo(int ID, string Title, int length,string format, string[] regions);

    public abstract void ReadMovie();
    public abstract void ReadShow();
    public abstract void ReadVideos();
  
}