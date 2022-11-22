using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Word//Using Classes and Objects
    {
        public Word(string wordinput, int vowelcount, bool repeatingletters )
        {
            this.WordInput = wordinput;
            this.VowelCount = vowelcount;
            this.RepeatingLetters = repeatingletters;
        }
        public string WordInput { get; set; }
        public int VowelCount { get; set; }
        public bool RepeatingLetters { get; set; }  
    }
}
