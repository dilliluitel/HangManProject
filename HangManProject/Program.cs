using System;
using System.Text;

namespace HangManProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var hangMan = new HangMan();

            Welcome.WelcomeMessage();

            #region Run HangMan
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
            #endregion
        }
    }
}
