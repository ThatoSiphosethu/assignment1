using System;
using NLog;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace assignment1.asses2
{
    public class Actions
    {
        //what to add 1. movies 2. show 3.video
        private static string File = "movies.csv";
         private static string File2 = "shows.csv";
          private static string File3 = "videos.csv";
        int MovieID;
        int ShowID;
        int VideoID;

        Movie movie = new Movie();
        Show show = new Show();
        Video video = new Video();

        public object Title { get; private set; }

        public void ReadMovie(){
           Console.WriteLine("How many movie do you want to be displayed? ");
            int numberOfMovies = Int32.Parse(Console.ReadLine());

            StreamReader reader = new StreamReader("movies.csv");

            for (int i = 0; i < numberOfMovies + 1; i++)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }

            Console.WriteLine("\n1.Back\n2.Exit");
            int option = Int32.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Clear();
                   // Menu.Questions();
                    break;
                default:
                    break;
            }
              

        }
        public void ReadShow(){
            Console.WriteLine("How many shows do you want to be displayed? ");
             int numberOfShows = Int32.Parse(Console.ReadLine());

             StreamReader reader = new StreamReader("shows.csv");

           for (int i = 0; i < numberOfShows + 1; i++)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
             Console.WriteLine("\n1.Back\n2.Exit");
            int option = Int32.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Clear();
                   // Menu.Questions();
                    break;
                default:
                    break;
            }
            reader.Close();

        }
        public void ReadVideos(){
             Console.WriteLine("How many videos do you want to be displayed? ");
            int numberOfVidoes = Int32.Parse(Console.ReadLine());

            StreamReader reader = new StreamReader("videos.csv");

            for (int i = 0; i < numberOfVidoes + 1; i++)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
             Console.WriteLine("\n1.Back\n2.Exit");
            int option = Int32.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Clear();
                    //Menu.Questions();
                    break;
                default:
                    break;
            } 

        }

        public void AddMovie()
        {
            MovieID = getLastID() + 1;
            StreamWriter sw = new StreamWriter(File, true);

            Console.WriteLine("Enter a new Title: ");
            string movieTitle = Console.ReadLine();

            var genres = new List<string>();
            string genre;
            string option;

            do
            {
                Console.WriteLine("Add genres: ");
                genre = Console.ReadLine();
                genres.Add(genre);
                Console.WriteLine("Do you want to add a genre: (Y/N)");
                option = Console.ReadLine().ToUpper();
            } while (option == "Y");
            
            string newGenres =  string.Join("|", genres); 
            sw.WriteLine("{0},{1},{2}", MovieID, movieTitle, newGenres);
            string[] stringArray = new string[]{ newGenres };
            movie.addMovie(MovieID,movieTitle,stringArray );
            sw.Close();
        }
        private int getLastID()
        {
            int lastID = 0;
            try
            {
                string lastLine = System.IO.File.ReadLines(File).Last();
                string[] lastLineSplit = lastLine.Split(',');
                lastID = Convert.ToInt32(lastLineSplit[0]);
                Console.WriteLine(lastID);
                return lastID;
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("File does not exist.");
            }


            return lastID;
        }

        //add show
        public void AddShow()
        {
            ShowID = getLastID() + 1;
            StreamWriter sw = new StreamWriter(File2, true);

            Console.WriteLine("Enter a new Title: ");
            string movieTitle = Console.ReadLine();

            Console.WriteLine("Input season number: ");
            int Season = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input episode number: ");
            int Episode = Int32.Parse(Console.ReadLine());

            

            var Writers = new List<string>();
            string Writer;
            string option;
        

            do
            {
                Console.WriteLine("Add writer/s: ");
                Writer = Console.ReadLine();
                Writers.Add(Writer);
                Console.WriteLine("Do you want to add writer/s: (Y/N)");
                option = Console.ReadLine().ToUpper();
            } while (option == "Y");
            
            string newWriter =  string.Join("|", Writers); 
            sw.WriteLine("{0},{1},{2},{3},{4},{5}", ShowID, Title, Season, Episode, Writers);
            string[] stringArray = new string[]{ newWriter };
            show.addShow(ShowID,Title,Season,Episode,stringArray );
            sw.Close();
        }
           private int showLastID()
        {
            int lastID = 0;
            try
            {
                string lastLine = System.IO.File.ReadLines(File).Last();
                string[] lastLineSplit = lastLine.Split(',');
                lastID = Convert.ToInt32(lastLineSplit[0]);
                Console.WriteLine(lastID);
                return lastID;
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("File does not exist.");
            }


            return lastID;
        }

        //add videos
         public void addVideo()
        {
            VideoID = getLastID() + 1;
            StreamWriter sw = new StreamWriter(File3, true);

            Console.WriteLine("Enter a new Title: ");
            string Title = Console.ReadLine();
            
            Console.WriteLine("Enter a format: ");
            string Format = Console.ReadLine();

            Console.WriteLine("Enter length of video: ");
            int Length = Int32.Parse(Console.ReadLine());

            var Regions = new List<string>();
            string Region;
            string option;


            do
            {
                Console.WriteLine("Add region: ");
                Region = Console.ReadLine();
                Regions.Add(Region);
                Console.WriteLine("Do you want to add another region: (Y/N)");
                option = Console.ReadLine().ToUpper();
            } while (option == "Y");
            
            string newRegions =  string.Join("|", Regions); 
            sw.WriteLine("{0},{1},{2},{3},{4},{5}", VideoID, Title, newRegions, Length, Format);
            string[] stringArray = new string[]{ newRegions };
            video.addVideo(VideoID,Title, Length,Format, stringArray );
            sw.Close();
        }
        private int VideoLastID()
        {
            int lastID = 0;
            try
            {
                string lastLine = System.IO.File.ReadLines(File).Last();
                string[] lastLineSplit = lastLine.Split(',');
                lastID = Convert.ToInt32(lastLineSplit[0]);
                Console.WriteLine(lastID);
                return lastID;
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("File does not exist.");
            }


            return lastID;
        }

    }


}