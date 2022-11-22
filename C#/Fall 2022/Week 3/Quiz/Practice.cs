using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Practice
    {
        public Practice(List<Word> wordlist)//Abstraction
        {
            this.WordList = wordlist;
        }
        public List <Word> WordList { get; set; }   
    }
}
