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
            var candidates = sentence.ToLower();
            numberOfVowels = candidates.Count(c => c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'å' || c == 'ä' || c == 'ö');
            numberOfConsonants = candidates.Count(c => c >= 'a' && c <= 'z' || c == 'å' || c == 'ä' || c == 'ö') - numberOfVowels;
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
