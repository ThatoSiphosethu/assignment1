using System;
using NLog;
using System.IO;
using System.Collections.Generic;
using assignment1.asses2;

namespace MovieLibrary
{
    class Program
    {           
       
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            menu.Questions();
        }
    }
}