using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WordBank class to host the banks of words for the HangMan game

namespace HangManProject
{
    public class WordBank
    {
        public List<string> Words = new List<string>()
        {
          "Greeting",
          "Goodbye",
          "Hello",
          "Guess",
          "Namaste"
        };
        //public int WordCount { get; set; }

        //randomly picks up a word from the WordBank
        //returns the word typed lower case
        public string GetWord()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, Words.Count);
            return Words[randomIndex].ToLower();
        }


    }
}
