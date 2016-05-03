using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD3
{
    public class TDD3_Methods
    {
        public void CountVowelsAndConsonants(string sentence, out int numberOfVowels, out int numberOfConsonants)
        {
            var vowels = new HashSet<char> { 'A','a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u', 'Å', 'å', 'Ä', 'ä', 'Ö', 'ö' };
            var consonants = new HashSet<char> { 'Q', 'q', 'W', 'w', 'R', 'r', 'T', 't', 'Y', 'y', 'P', 'p', 'S', 's', 'D', 'd', 'F', 'f', 'G', 'g', 'H', 'h', 'J', 'j', 'K', 'k', 'L', 'l', 'Z', 'z', 'X', 'x', 'C', 'c', 'V', 'v', 'B', 'b', 'N', 'n', 'M', 'm' };

            numberOfVowels = 0;
            numberOfConsonants = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))
                    numberOfVowels++;
            }

            for (int u = 0; u < sentence.Length; u++)
            {
                if (consonants.Contains(sentence[u]))
                    numberOfConsonants++;
            }
        }

        public string StringReplacement(string sentence, string stringToReplace, string replacementString)
        {
            
            var words = sentence.Split();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals(stringToReplace))
                    words[i] = replacementString;
            }
            return string.Join(" ", words);
        }
    }
}
