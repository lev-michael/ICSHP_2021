using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Excercise04
{
    class Words
    { 
        private List<String> listOfWords;
        Random random;
        public Words()
        {
            listOfWords = new List<string>(System.IO.File.ReadAllText("..\\..\\words.txt").Split('\n'));
            random = new Random();
            Debug.WriteLine(GetRandomWord());
        }
        

        public string GetRandomWord()
        {
            int randomInt = random.Next(0, listOfWords.Count-1);
            return listOfWords[randomInt].Trim();
        }
    }
}
