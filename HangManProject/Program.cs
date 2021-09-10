using System;
using System.Text;

namespace HangManProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var hangMan = new HangMan();
            var options = new WordBank();
            string word = options.GetWord();

            //string[] pWord = new string[word.Length];
            var pWord = new StringBuilder();
            int misses = 0, count = 6;
            bool hit = false;

            Welcome.WelcomeMessage();
            char guess = char.Parse(Console.ReadLine());
            Console.WriteLine();

            //Console.WriteLine(word);
            foreach (var ch in word)
            {
                pWord.Append('-');
            }
            Console.WriteLine(pWord.ToString());

            //has some redundancy, needs to refactor it to use methods instead
            
            while (misses >= 0 && misses < 6)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (guess == word[i] && pWord[i].Equals('-'))
                    {
                        pWord[i] = guess;
                        hit = true;
                    }
                }
               // Console.WriteLine(hit);
                
                if (hit)
                {
                    hit = false;
                    Console.WriteLine("Correct guess!");
                    Console.WriteLine($"Playing word : {pWord.ToString()}");

                    if (word.Equals(pWord.ToString()))
                    {
                        Console.WriteLine("You Win!!!");
                        break;
                    }

                }
                else {
                    misses++;
                    Console.WriteLine("Incorrect Guess.");
                    Console.WriteLine($"You have {count - misses} attempts left.");
                    if (misses == 6)
                    {
                        Console.WriteLine("You Loose");
                        break;
                    }
 
                }                
                Console.Write($"Guess another letter : ");
                guess = char.Parse(Console.ReadLine());
                Console.WriteLine(); 
            }
        }
    }
}
