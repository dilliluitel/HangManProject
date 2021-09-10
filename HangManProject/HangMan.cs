using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManProject
{
   public class HangMan
    {
        
        public StringBuilder PlayingWord { get; set; }
        public char Guess { get; set; }
        public string Misses { get; set; }
        public int Attempts { get; set; }

        //public StringBuilder pWord = new StringBuilder();
        

        public bool IsHit(char guess, string word, out StringBuilder pWord)
        {
           pWord = PlayingWord;
            bool hit = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (guess == word[i] && pWord[i].Equals('-'))
                {
                    pWord[i] = guess;
                    hit = true;
                }
                else
                    hit = false;
            }
            return hit;
        }

    }
}
