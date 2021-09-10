﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManProject
{
    public class WordBank
    {
        //int MyProperty { get; set; }
        public List<string> Words = new List<string>()
        {
          "greeting",
          "goodbye",
          "hello",
        };
        public int WordCount { get; set; }

        public string GetWord()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, Words.Count);
            //Console.WriteLine("\nindex : " + randomIndex);
            return Words[randomIndex];
        }


    }
}