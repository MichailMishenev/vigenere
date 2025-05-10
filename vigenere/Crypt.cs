using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vigenere
{
    public class Crypt
    {
        private static readonly char[] LatinLower = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private static readonly char[] LatinUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static readonly char[] CyrillicLower = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
        private static readonly char[] CyrillicUpper = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
        
        /// <summary>
        /// Gets the shift of a character for the Vigenere cypher.
        /// </summary>
        /// <param name="keyChar">Character.</param>
        /// <returns>Shift as integer</returns>
        private static int GetShift(char keyChar)
        {
            int shift = 0;
            if (Array.IndexOf(LatinLower, keyChar) != -1)
            {
                shift = Array.IndexOf(LatinLower, keyChar) + 1;
            }
            else if (Array.IndexOf(LatinUpper, keyChar) != -1)
            {
                shift = Array.IndexOf(LatinUpper, keyChar) + 1;
            }
            else if (Array.IndexOf(CyrillicLower, keyChar) != -1)
            {
                shift = Array.IndexOf(CyrillicLower, keyChar) + 1;
            }
            else if (Array.IndexOf(CyrillicUpper, keyChar) != -1)
            {
                shift = Array.IndexOf(CyrillicUpper, keyChar) + 1;
            }
            return shift;
        }

        /// <summary>
        /// Encrypts text with the vigenere cypher.
        /// </summary>
        /// <param name="text">Text</param>
        /// <param name="key">Encryption key</param>
        /// <returns>Encrypted text.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static string VigenereEncrypt(string text, string key)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("Key cannot be null or empty.", nameof(key));

            StringBuilder result = new StringBuilder();
            int keyIndex = 0;

            foreach (char ch in text)
            {
                if (Array.IndexOf(LatinLower, ch) != -1)
                {
                    int alphaLen = LatinLower.Length;
                    int currentIndex = Array.IndexOf(LatinLower, ch);
                    int shift = GetShift(key[keyIndex % key.Length]);
                    int newIndex = (currentIndex + shift) % alphaLen;
                    result.Append(LatinLower[newIndex]);
                    keyIndex++;
                }
                else if (Array.IndexOf(LatinUpper, ch) != -1)
                {
                    int alphaLen = LatinUpper.Length;
                    int currentIndex = Array.IndexOf(LatinUpper, ch);
                    int shift = GetShift(key[keyIndex % key.Length]);
                    int newIndex = (currentIndex + shift) % alphaLen;
                    result.Append(LatinUpper[newIndex]);
                    keyIndex++;
                }
                else if (Array.IndexOf(CyrillicLower, ch) != -1)
                {
                    int alphaLen = CyrillicLower.Length;
                    int currentIndex = Array.IndexOf(CyrillicLower, ch);
                    int shift = GetShift(key[keyIndex % key.Length]);
                    int newIndex = (currentIndex + shift) % alphaLen;
                    result.Append(CyrillicLower[newIndex]);
                    keyIndex++;
                }
                else if (Array.IndexOf(CyrillicUpper, ch) != -1)
                {
                    int alphaLen = CyrillicUpper.Length;
                    int currentIndex = Array.IndexOf(CyrillicUpper, ch);
                    int shift = GetShift(key[keyIndex % key.Length]);
                    int newIndex = (currentIndex + shift) % alphaLen;
                    result.Append(CyrillicUpper[newIndex]);
                    keyIndex++;
                }
                else
                {
                    result.Append(ch);
                }
            }
            return result.ToString();
        }

        /// <summary>
        /// Decrypts text with the vigenere cypher.
        /// </summary>
        /// <param name="text">Text</param>
        /// <param name="key">Decryption key</param>
        /// <returns>Decrypted text.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static string VigenereDecrypt(string text, string key)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("Key cannot be null or empty.", nameof(key));

            StringBuilder result = new StringBuilder();
            int keyIndex = 0;

            foreach (char ch in text)
            {
                if (Array.IndexOf(LatinLower, ch) != -1)
                {
                    int alphaLen = LatinLower.Length;
                    int currentIndex = Array.IndexOf(LatinLower, ch);
                    int shift = GetShift(key[keyIndex % key.Length]);
                    int newIndex = (currentIndex - shift + alphaLen) % alphaLen;
                    result.Append(LatinLower[newIndex]);
                    keyIndex++;
                }
                else if (Array.IndexOf(LatinUpper, ch) != -1)
                {
                    int alphaLen = LatinUpper.Length;
                    int currentIndex = Array.IndexOf(LatinUpper, ch);
                    int shift = GetShift(key[keyIndex % key.Length]);
                    int newIndex = (currentIndex - shift + alphaLen) % alphaLen;
                    result.Append(LatinUpper[newIndex]);
                    keyIndex++;
                }
                else if (Array.IndexOf(CyrillicLower, ch) != -1)
                {
                    int alphaLen = CyrillicLower.Length;
                    int currentIndex = Array.IndexOf(CyrillicLower, ch);
                    int shift = GetShift(key[keyIndex % key.Length]);
                    int newIndex = (currentIndex - shift + alphaLen) % alphaLen;
                    result.Append(CyrillicLower[newIndex]);
                    keyIndex++;
                }
                else if (Array.IndexOf(CyrillicUpper, ch) != -1)
                {
                    int alphaLen = CyrillicUpper.Length;
                    int currentIndex = Array.IndexOf(CyrillicUpper, ch);
                    int shift = GetShift(key[keyIndex % key.Length]);
                    int newIndex = (currentIndex - shift + alphaLen) % alphaLen;
                    result.Append(CyrillicUpper[newIndex]);
                    keyIndex++;
                }
                else
                {
                    result.Append(ch);
                }
            }
            return result.ToString();
        }

        /// <summary>
        /// Encrypts text with the Caesar cypher.
        /// </summary>
        /// <param name="input">Text</param>
        /// <param name="shift">Shift</param>
        /// <returns>Encrypted text</returns>
        public static string CaesarEncrypt(string input, int shift)
        {
            return Transform(input, shift);
        }

        /// <summary>
        /// Decrypts text with the Caesar cypher.
        /// </summary>
        /// <param name="input">Text</param>
        /// <param name="shift">Shift</param>
        /// <returns>Decrypted text</returns>
        public static string CaesarDecrypt(string input, int shift)
        {
            return Transform(input, -shift);
        }

        /// <summary>
        /// Transforms text according to a shift for the Caesar cypher.
        /// </summary>
        /// <param name="input">Text</param>
        /// <param name="shift">Shift</param>
        /// <returns>Shifted text</returns>
        private static string Transform(string input, int shift)
        {
            var result = new System.Text.StringBuilder();

            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    bool isUpper = char.IsUpper(ch);
                    char baseChar = GetAlphabetBase(ch);

                    int alphabetSize = GetAlphabetSize(ch);
                    if (baseChar != '\0')
                    {
                        int offset = ch - baseChar;
                        int newOffset = (offset + shift + alphabetSize) % alphabetSize;
                        char shiftedChar = (char)(baseChar + newOffset);
                        result.Append(shiftedChar);
                    }
                    else
                    {
                        result.Append(ch); // unrecognized alphabet
                    }
                }
                else
                {
                    result.Append(ch); // non-letter characters remain unchanged
                }
            }

            return result.ToString();
        }

        /// <summary>
        /// Gets the alphabet base of a character for the Caesar cypher
        /// </summary>
        /// <param name="ch">Character</param>
        /// <returns>Base as character</returns>
        private static char GetAlphabetBase(char ch)
        {
            if (ch >= 'A' && ch <= 'Z') return 'A';
            if (ch >= 'a' && ch <= 'z') return 'a';
            if (ch >= 'А' && ch <= 'Я') return 'А';
            if (ch >= 'а' && ch <= 'я') return 'а';
            return '\0'; // unsupported
        }

        /// <summary>
        /// Gets the alphabet size of a character for the Caesar cypher
        /// </summary>
        /// <param name="ch">Character</param>
        /// <returns>Alphabet size as int</returns>
        private static int GetAlphabetSize(char ch)
        {
            if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z')) return 26;
            if ((ch >= 'А' && ch <= 'Я') || (ch >= 'а' && ch <= 'я')) return 32;
            return 0;
        }

        /// <summary>
        /// Transforms text with the Atbash cypher.
        /// </summary>
        /// <param name="input">Text</param>
        /// <returns>Transformed text.</returns>
        public static string AtbashTransform(string input)
        {
            var result = new System.Text.StringBuilder();

            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    char transformed = TransformChar(ch);
                    result.Append(transformed);
                }
                else
                {
                    result.Append(ch);
                }
            }

            return result.ToString();
        }

        /// <summary>
        /// Transforms a character for the Atbash cypher.
        /// </summary>
        /// <param name="ch">Character.</param>
        /// <returns>Transformed character.</returns>
        private static char TransformChar(char ch)
        {
            if (ch >= 'A' && ch <= 'Z') return (char)('Z' - (ch - 'A'));
            if (ch >= 'a' && ch <= 'z') return (char)('z' - (ch - 'a'));
            if (ch >= 'А' && ch <= 'Я') return (char)('Я' - (ch - 'А'));
            if (ch >= 'а' && ch <= 'я') return (char)('я' - (ch - 'а'));

            return ch; // unhandled characters
        }
    }
}
