using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataSolutions
{
    public class Counter
    {
        public static int CountWordsWithLetter(string[] words, char letter)
        {
            int counter1 = 0;
            for (int i = 0; i < words.Length; i++)
            {
                string str = words[i];
                char[] chars = str.ToCharArray();

            }
        }
            
      

        public static int CountWordsWithLetterFast(string[] words, char letter)
        {
            throw new NotImplementedException();
        }
    }
}
