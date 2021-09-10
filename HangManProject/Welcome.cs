using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManProject
{
    public static class Welcome
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("***Welcome to HangMan Game***");
            Console.WriteLine("You will guess a letter.");
            Console.WriteLine("If you miss six times then you loose. Otherwise you win");
            Console.WriteLine("You will receive the hints along the way to help.");
            Console.Write("Guess a letter : ");

        }
    }
}
