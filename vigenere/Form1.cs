using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace vigenere
{
    public partial class Form1 : Form
    {
        private static readonly char[] LatinLower = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private static readonly char[] LatinUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static readonly char[] CyrillicLower = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
        private static readonly char[] CyrillicUpper = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();

        public string cypherMode = "vigenere"; 

        public Form1()
        {
            InitializeComponent();

            // Turn on all the styles we need:
            this.SetStyle(ControlStyles.UserPaint              // we handle all painting
                          | ControlStyles.AllPaintingInWmPaint // paint in WM_PAINT only
                          | ControlStyles.OptimizedDoubleBuffer // double buffer
                          | ControlStyles.ResizeRedraw,        // redraw on resize
                          true);
            this.UpdateStyles();

            // And also for the TableLayoutPanel specifically:
            tableLayoutPanel1.GetType()
                .GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(tableLayoutPanel1, true, null);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            string key = txtKey.Text;
            try
            {
                switch (cypherMode)
                {
                    case "vigenere":
                        txtResult.Text = VigenereEncrypt(message, key);
                        break;
                    case "caesar":
                        int shift = int.Parse(key);
                        txtResult.Text = CaesarEncrypt(message, shift);
                        break;
                    case "atbash":
                        txtResult.Text = AtbashTransform(message);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            string key = txtKey.Text;
            try
            {
                switch (cypherMode)
                {
                    case "vigenere":
                        txtResult.Text = VigenereDecrypt(message, key);
                        break;
                    case "caesar":
                        int shift = int.Parse(key);
                        txtResult.Text = CaesarDecrypt(message, shift);
                        break;
                    case "atbash":
                        txtResult.Text = AtbashTransform(message);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

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

        private static string VigenereEncrypt(string text, string key)
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

        private static string VigenereDecrypt(string text, string key)
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

        public static string CaesarEncrypt(string input, int shift)
        {
            return Transform(input, shift);
        }

        public static string CaesarDecrypt(string input, int shift)
        {
            return Transform(input, -shift);
        }

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

        private static char GetAlphabetBase(char ch)
        {
            if (ch >= 'A' && ch <= 'Z') return 'A';
            if (ch >= 'a' && ch <= 'z') return 'a';
            if (ch >= 'А' && ch <= 'Я') return 'А';
            if (ch >= 'а' && ch <= 'я') return 'а';
            return '\0'; // unsupported
        }

        private static int GetAlphabetSize(char ch)
        {
            if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z')) return 26;
            if ((ch >= 'А' && ch <= 'Я') || (ch >= 'а' && ch <= 'я')) return 32;
            return 0;
        }

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

        private static char TransformChar(char ch)
        {
            if (ch >= 'A' && ch <= 'Z') return (char)('Z' - (ch - 'A'));
            if (ch >= 'a' && ch <= 'z') return (char)('z' - (ch - 'a'));
            if (ch >= 'А' && ch <= 'Я') return (char)('Я' - (ch - 'А'));
            if (ch >= 'а' && ch <= 'я') return (char)('я' - (ch - 'а'));

            return ch; // unhandled characters
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.Title = "Select a Text File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileContent = File.ReadAllText(openFileDialog.FileName);
                    txtMessage.Text = fileContent; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message);
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save Result to File";
            saveFileDialog.DefaultExt = "txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, txtResult.Text); 
                    MessageBox.Show("Файл успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message);
                }
            }
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            switch (cypherMode)
            {
                case "vigenere":
                    MessageBox.Show("Шифр Виженера\n\nДля шифрования текста используется текст-\"ключ\", на основе которого сдвигаются символы текста. Дешифровать текст возможно только при наличии ключа, которым он был шифрован. Ключ может быть произвольным текстом любого размера.\n\nПример: для текста \"Привет\" и ключа \"абв\" выводится результат \"Ртлгжх\". Ключ повторяется на всю длину текста - \"абвабв\" - и каждый символ текста сдвигается по алфавиту в зависимости от символа ключа на этой позиции. \"а\" - сдвиг на 1 символ вперёд, \"б\" - сдвиг на 2, \"в\" - на 3.\n\nТекст, который вы хотите (де)шифровать, вводится в \"поле ввода\". Ключ вводится в поле \"ключ\". При нажатии кнопок шифрования или дешифрования результат выводится в поле \"результат\".\n\nКнопки загрузки и сохранения находятся рядом с полем ввода и полем результата соответственно, и позволяют: \n1. Выбирать текстовый файл, чтобы загрузить его текст в поле ввода\n2. Сохранить текст из поля результата в текстовый файл", "Справка");
                    break;
                case "caesar":
                    MessageBox.Show("Шифр Цезаря\n\nКаждый символ текста сдвигается по алфавиту на основе \"сдвига\". Сдвиг может быть только числом. Пример: для текста \"Привет\" и сдвига \"3\" выводится результат \"Тулеих\". Каждая буква сдвинулась вправо по алфавиту на три шага: П -> Р -> С -> Т, Р -> С -> Т -> У, и так далее.\n\nТекст, который вы хотите (де)шифровать, вводится в \"поле ввода\". Сдвиг вводится в поле \"сдвиг\". При нажатии кнопок шифрования или дешифрования результат выводится в поле \"результат\".\n\nКнопки загрузки и сохранения находятся рядом с полем ввода и полем результата соответственно, и позволяют: \n1. Выбирать текстовый файл, чтобы загрузить его текст в поле ввода\n2. Сохранить текст из поля результата в текстовый файл", "Справка");
                    break;
                case "atbash":
                    MessageBox.Show("Шифр Атбаш\n\nДля шифра Атбаш не существует разницы между шифрованием и дешифрованием. Каждый символ текста заменяется на его эквивалент в алфавите, идущим в противоположную сторону.\n\nПример: текст \"Привет\" превращается в \"Рпчэън\", а текст \"АБЮЯ\" превращается в \"ЯЮБА\".\n\nТекст, который вы хотите (де)шифровать, вводится в \"поле ввода\". При нажатии кнопок шифрования или дешифрования результат выводится в поле \"результат\".\n\nКнопки загрузки и сохранения находятся рядом с полем ввода и полем результата соответственно, и позволяют: \n1. Выбирать текстовый файл, чтобы загрузить его текст в поле ввода\n2. Сохранить текст из поля результата в текстовый файл", "Справка");
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Виженер":
                    cypherMode = "vigenere";
                    label4.Visible = true;
                    label4.Text = "Ключ:";
                    btnDecrypt.Visible = true;
                    txtKey.Visible = true;
                    break;
                case "Цезарь":
                    cypherMode = "caesar";
                    label4.Visible = true;
                    label4.Text = "Сдвиг:";
                    btnDecrypt.Visible = true;
                    txtKey.Visible = true;
                    break;
                case "Атбаш":
                    cypherMode = "atbash";
                    label4.Visible = false;
                    btnDecrypt.Visible = false;
                    txtKey.Visible = false;
                    break;
            }
        }
    }
}
