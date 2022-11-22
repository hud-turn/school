using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Analytics : Practice//Inheritance and Encapsulation
    {
        internal Analytics(Word wordlist, int computednumvowel, bool repeatingletter ) : base(wordlist)
        {
            this.WordList = wordlist;
            this.ComputedNumVowel = computednumvowel;
        }
        public List<Word> WordList { get; set; }
        public int ComputedNumVowel { get; set; }
        public int QuestionsAnswered(int count)
        {
            foreach (Word word in WordList)
            {
                count++;
            }
            return count;
        }
        public double QuestionsCorrect()
        {
            foreach (Word a in WordList)
            {
                
            }
        }
    }
}
