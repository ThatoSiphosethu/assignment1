using System;
using System.IO;

namespace assignment1.asses2
{
    public class MainMenu
    {
        public void Questions()
        {

            int option = 0;
            Console.WriteLine("1. View\n2. Add\n3. Exit");

            do
            {

                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    MainMenu ViewMenu = new MainMenu();
                    Actions actions = new Actions();

                    Console.Clear();
                    Console.WriteLine("1. Movie\n2. Video\n3. Show\n4. Back\n5. Exit");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        actions.ReadMovie();
                    }
                    else if (choice == 2)
                    {
                       actions.ReadShow();
                    }
                    else if (choice == 3)
                    {
                        actions.ReadVideos();
                    }
                    else if (choice == 4)
                    {
                        return;
                    }
                }
                else if (option == 2)
                {
                    Console.Clear();
                    MainMenu AddMenu = new MainMenu();
                    Console.WriteLine("Add into 1. Movie\n. 2 Video\n. 3 Show\n ");
                    int choice = int.Parse(Console.ReadLine());
                    Actions actions = new Actions();
                    if (choice == 1)
                    {
                        actions.AddMovie();
                    }
                    else if (choice == 2)
                    {
                        actions.addVideo();

                    }
                    else if (choice == 3)
                    {
                        actions.AddShow();
                    }

                }

                else if (option == 3)
                {
                    MainMenu exit = new MainMenu();
                }
            } while (option > 3 || option < 1);


        }

        
    }

}
