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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("***Welcome to HangMan Game***");
            Console.WriteLine("You will guess a letter at a time for a randomly selected word.");
            Console.WriteLine("You can also guess the complete word any time during the game.");
            Console.WriteLine("If you correctly guess the word before six misses, you win. Otherwise you loose.");
            Console.WriteLine("You will receive the hints along the way for help.");
            Console.ResetColor();
        }
    }
}
