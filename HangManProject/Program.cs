using System;
using System.Text;

namespace HangManProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome.WelcomeMessage();
            var hangMan = new HangMan();

            //for testing purpose only
            //Console.WriteLine(hangMan.word);
            // Console.WriteLine(hangMan.pWord.ToString());

            while (hangMan.Misses < hangMan.count)
            {
                hangMan.TakeAGuess();
               
                if (hangMan.GuessEqualsWord())
                {
                    hangMan.YouWin();
                    break;
                }
                if (hangMan.IsHit())
                {
                    hangMan.CorrectGuess();
                    if (hangMan.WordEqualsPword())
                    {
                        hangMan.YouWin();
                        break;
                    }
                }
                else
                    hangMan.IncorrectGuess();
            }
        }
    }
}
