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
        private const string UpperLatin = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string LowerLatin = "abcdefghijklmnopqrstuvwxyz";
        private const string UpperCyrillic = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private const string LowerCyrillic = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

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
            if (input == null) return null;
            var sb = new StringBuilder(input.Length);

            // Normalize shifts to avoid huge values:
            int shiftLatin = ((shift % 26) + 26) % 26;
            int shiftCyrillic = ((shift % 33) + 33) % 33;

            foreach (char ch in input)
            {
                if (UpperLatin.IndexOf(ch) >= 0)
                {
                    int idx = UpperLatin.IndexOf(ch);
                    int newIdx = (idx + shiftLatin) % 26;
                    sb.Append(UpperLatin[newIdx]);
                }
                else if (LowerLatin.IndexOf(ch) >= 0)
                {
                    int idx = LowerLatin.IndexOf(ch);
                    int newIdx = (idx + shiftLatin) % 26;
                    sb.Append(LowerLatin[newIdx]);
                }
                else if (UpperCyrillic.IndexOf(ch) >= 0)
                {
                    int idx = UpperCyrillic.IndexOf(ch);
                    int newIdx = (idx + shiftCyrillic) % 33;
                    sb.Append(UpperCyrillic[newIdx]);
                }
                else if (LowerCyrillic.IndexOf(ch) >= 0)
                {
                    int idx = LowerCyrillic.IndexOf(ch);
                    int newIdx = (idx + shiftCyrillic) % 33;
                    sb.Append(LowerCyrillic[newIdx]);
                }
                else
                {
                    // Any other character (digits, punctuation, whitespace) remains as is
                    sb.Append(ch);
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Transforms text with the Atbash cypher.
        /// </summary>
        /// <param name="input">Text</param>
        /// <returns>Transformed text.</returns>
        public static string AtbashTransform(string input)
        {
            if (input == null) return null;
            var sb = new StringBuilder(input.Length);

            foreach (char ch in input)
            {
                if (UpperLatin.IndexOf(ch) >= 0)
                {
                    int idx = UpperLatin.IndexOf(ch);
                    int mirrorIdx = (UpperLatin.Length - 1) - idx; // 25 - idx
                    sb.Append(UpperLatin[mirrorIdx]);
                }
                else if (LowerLatin.IndexOf(ch) >= 0)
                {
                    int idx = LowerLatin.IndexOf(ch);
                    int mirrorIdx = (LowerLatin.Length - 1) - idx; // 25 - idx
                    sb.Append(LowerLatin[mirrorIdx]);
                }
                else if (UpperCyrillic.IndexOf(ch) >= 0)
                {
                    int idx = UpperCyrillic.IndexOf(ch);
                    int mirrorIdx = (UpperCyrillic.Length - 1) - idx; // 32 - idx
                    sb.Append(UpperCyrillic[mirrorIdx]);
                }
                else if (LowerCyrillic.IndexOf(ch) >= 0)
                {
                    int idx = LowerCyrillic.IndexOf(ch);
                    int mirrorIdx = (LowerCyrillic.Length - 1) - idx; // 32 - idx
                    sb.Append(LowerCyrillic[mirrorIdx]);
                }
                else
                {
                    sb.Append(ch);
                }
            }

            return sb.ToString();
        }
    }
}
