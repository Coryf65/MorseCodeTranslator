using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Title = "Morse Code from Text";
                Console.WriteLine("Type any text to change into Morse Code... | <Enter> to Quit");
                Console.Write(": ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                string output = Translator.ToMorse(input);

                Console.WriteLine(output);
            }
            
        }
    }
}
