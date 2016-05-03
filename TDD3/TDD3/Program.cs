using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD3
{
    class Program
    {
        static void Main(string[] args)
        {
            var methods = new TDD3_Methods();

            Console.WriteLine("Skriv en mening: ");
            var sentence = Console.ReadLine();

            int numberOfVowels;
            int numberOfConsonants;

            methods.CountVowelsAndConsonants(sentence, out numberOfVowels, out numberOfConsonants);

            Console.WriteLine($"vowels: {numberOfVowels} & consonants: {numberOfConsonants}");

            Console.WriteLine("Skriv en mening: ");
            sentence = Console.ReadLine();

            Console.WriteLine("ord som ska ersätta: ");
            var stringToReplace = Console.ReadLine();

            Console.WriteLine("ord som ersätts med: ");
            var replacementString = Console.ReadLine();

            var result = methods.StringReplacement(sentence, stringToReplace, replacementString);

            Console.WriteLine($"Resultat: {result}");
            Console.ReadLine();
        }
    }
}
