using System.Collections.Generic;
using System.Linq;

namespace CryptoApp
{
    public static class Atbash
    {
        private const string DefaultAlphabet = "abcdefghijklmnopqrstuvwxyz";

        public static string Decode(string input, string alphabet = DefaultAlphabet)
        {
            var plain = alphabet.ToUpperInvariant();
            return Transform(input, plain);
        }

        public static string Encode(string input, string alphabet = DefaultAlphabet)
        {
            var cipher = new string(alphabet.ToUpperInvariant().Reverse().ToArray());
            return Transform(input, cipher);
        }

        private static string Transform(string input, string code)
        {
            var letters = new List<char>(input.Length);
            foreach (var c in input.ToUpperInvariant())
            {
                if (char.IsLetter(c))
                {
                    var index = code.Length - code.IndexOf(c) - 1;
                    letters.Add(code[index]);
                }
            }
            return new string(letters.ToArray());
        }
    }
}
