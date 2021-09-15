using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Manipulates all the hangman game strategies

namespace HangManProject
{
   public class HangMan
    {
        public readonly int count = 6;  //max counts you can miss the guesses
        private string guess = "";
        

        private int _misses = 0;
        public int Misses
        {
            get => _misses;
            set => _misses = value;
        }

        private StringBuilder pWord = new StringBuilder();   //playingWord
        private StringBuilder incorrectGuess = new StringBuilder();

        private string word;
        WordBank words = new WordBank();

        public HangMan()
        {
            word = words.GetWord();
            foreach (var ch in word)
            {
                pWord.Append('-');
            }
        }

        //user prompts to take a guess
        //TODO : move this method to Welcome class to return a guess
        public void TakeAGuess()
        {
            //Console.WriteLine(pWord);
            SetFontColor(ConsoleColor.Blue);
            string str1 = "Take a Guess : ";
            string str2 = "Take another Guess : ";
            Console.WriteLine();            
            Console.Write(guess.Equals("") ? str1 : str2);
            guess = Console.ReadLine().Trim().ToLower();
            Console.ResetColor();
        }

        //returns true if the guess char is in the word
        //also populates the pWord with correct guess char with no repetition
        //TODO: try refactoring it using string Contains() & IndexOf() methods
        public bool IsHit()
        {
            bool hit = false;
            try
            {
                char guessChar = char.Parse(guess.Trim().ToLower());
                
                for (int i = 0; i < word.Length; i++)
                {
                    if (guessChar == word[i] && pWord[i].Equals('-'))
                    {
                        pWord[i] = guessChar;
                        hit = true;
                    }
                }
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("You entered multiple characters. Enter one letter at a time.");
            }
            return hit;
        }

        public void CorrectGuess()
        {
            SetFontColor(ConsoleColor.Green);
            Console.WriteLine("Correct guess!\n");
            Console.WriteLine($"Playing word : {pWord.ToString()}");
        }

        public void IncorrectGuess()
        {
            Misses++;
            incorrectGuess.Append(guess + " ");
            SetFontColor(ConsoleColor.DarkYellow);

            Console.WriteLine("Incorrect Guess.\n");
            Console.WriteLine($"You have {count - Misses} attempts left.");
            Console.WriteLine($"Incorrect guesses : {incorrectGuess.ToString()}");
            Console.WriteLine($"Playing word : {pWord.ToString()}");

            if (Misses == 6)
            {
                Console.WriteLine($"The Correct Word was : {word}");
                SetFontColor(ConsoleColor.Red);
                Console.WriteLine("\nSorry! You Lost. Better luck next time.");
                Console.Beep();
                Console.ResetColor();
            }
            Console.ResetColor();
        }

        public bool GuessEqualsWord()
        {
            if (word.Equals(guess)) return true;
            else return false;
        }

        public bool WordEqualsPword()
        {
            if (word.Equals(pWord.ToString())) return true;
            else return false;
        }

        //Added font and background color ,and also
        //display the message on console title bar to celebrate the win little better.
        public void YouWin()
        {
            string congrats = "CONGRATULATIONS!!! YOU WON!!!";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"\n  {congrats}  ");
            Console.Title = congrats;

            Console.ResetColor();
            Console.ReadKey(true);
        }

        private static void SetFontColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
    }
}
