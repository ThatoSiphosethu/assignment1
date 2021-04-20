  
using System;
using System.IO;

namespace MovieLibrary
{
    public class Menu
    {
        public static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public void Questions(){
            Console.WriteLine("Make a selection\n");
            Console.WriteLine("1. See movies");
            Console.WriteLine("2. Add movie");
            Console.WriteLine("3. Exit\n");
 
        }

        public void MenuSelection() {
        int choice = 0;
        string option;
           

        do{
            Questions();
            choice = Int32.Parse(Console.ReadLine());
            if(choice == 1){
                 Movie readMovies = new Movie();
                do{
                    readMovies.ReadMovies();
                    Console.WriteLine("Do you want to display more movies? (Y/N)");
                    option = Console.ReadLine().ToUpper();
                }while(option == "Y");
                        
            }else if(choice == 2)
            {
                Movie addMovie = new Movie();
                do{
                    addMovie.AddMovie();
                    Console.WriteLine("Do you want to add another movie? (Y/N)");
                    option = Console.ReadLine().ToUpper();
                }while(option == "Y");
            }
            else
                {
                     Console.WriteLine("Closing program....");
                }
            }while( choice != 3);   
        }
    }
} 