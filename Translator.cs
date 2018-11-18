using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator
{
    static class Translator
    {

        // Key and Value
        // all the Keys must be unique
        // this is a Static Class so all members must be Static as well

        private static Dictionary<char, string> _textToMorse = new Dictionary<char, string>()
        {
            {' ', "/"},
            {'A', ".-"},
            {'B', "-..."},
            {'C', "-.-."},
            {'D', "-.."},
            {'E', "."},
            {'F', "..-."},
            {'G', "--."},
            {'H', "...."},
            {'I', ".."},
            {'J', ".---"},
            {'K', "-.-"},
            {'L', ".-.."},
            {'M', "--"},
            {'N', "-."},
            {'O', "---"},
            {'P', ".--."},
            {'Q', "--.-"},
            {'R', ".-."},
            {'S', "..."},
            {'T', "-"},
            {'U', "..-"},
            {'V', "...-"},
            {'W', ".--"},
            {'X', "-..-"},
            {'Y', "-.--"},
            {'Z', "--.."},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {'0', "-----"},
            {',', "--..--"},
            {'.', ".-.-.-"},
            {'?', "..--.."},
            {';', "-.-.-."},
            {':', "---..."},
            {'/', "-..-."},
            {'-', "-....-"},
            {'\'', ".----."},
            {'"', ".-..-."},
            {'(', "-.--."},
            {')', "-.--.-"},
            {'=', "-...-"},
            {'+', ".-.-."},
            {'@', ".--.-."},
            {'!', "-.-.--"},
            {'Á', ".--.-"},
            {'É', "..-.."},
            {'Ö', "---."},
            {'Ä', ".-.-"},
            {'Ñ', "--.--"},
            {'Ü', "..--"}
        };

        public static Dictionary<string, char> _morseToText = new Dictionary<string, char>();
        // We could copy the other Dictionary and flip ther keys and values but there is an easier way...

        // using a static constructor, which is called first and run once(because of being static)
        static Translator()
        {
            // looping through the values
            // KeyValuePair is a Genereic type and macth the Dictionary being looped through
            foreach (KeyValuePair<char, string> code in _textToMorse)
            {
                // adding the mapping, passing in code.Value because that is the key
                // assign it the to value of the key
                _morseToText[code.Value] = code.Key;
                

            }
        }

        public static string ToMorse(string input)
        {
            // list of all the morse code, codes/ input.Llength so we do not have to resize it.
            List<string> output = new List<string>(input.Length);

            // looking up each char one by one
            foreach (char character in input.ToUpper())
            {
                // if we are looking for a key that is not in the Dictionary we will get an Exception
                try
                {
                    // use the Key as the index, to find the translation
                    string morseCode = _textToMorse[character];
                    // now we will add that into a list
                    output.Add(morseCode);
                }
                catch (KeyNotFoundException)
                {
                    output.Add("!");
                }

                
            }

            // creating a string, Join accepts any IEnumerable string and concatanates them togther
            return string.Join(" ", output);
        }
    }
}
