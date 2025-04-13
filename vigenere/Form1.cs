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

namespace vigenere
{
    public partial class Form1 : Form
    {
        private static readonly char[] LatinLower = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private static readonly char[] LatinUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static readonly char[] CyrillicLower = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
        private static readonly char[] CyrillicUpper = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            string key = txtKey.Text;
            txtResult.Text = VigenereEncrypt(message, key);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            string key = txtKey.Text;
            txtResult.Text = VigenereDecrypt(message, key);
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return "";
            }
        }

        private static string VigenereDecrypt(string text, string key)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return "";
            }
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
            MessageBox.Show("Шифр Виженера\n\nДля шифрования текста используется текст-\"ключ\", на основе которого сдвигаются символы текста. Дешифровать текст возможно только при наличии ключа, которым он был шифрован. Ключ может быть произвольным текстом любого размера.\n\nПример: для текста \"Привет\" и ключа \"абв\" выводится результат \"Ртлгжх\". Ключ повторяется на всю длину текста - \"абвабв\" - и каждый символ текста сдвигается по алфавиту в зависимости от символа ключа на этой позиции. \"а\" - сдвиг на 1 символ вперёд, \"б\" - сдвиг на 2, \"в\" - на 3.\n\nТекст, который вы хотите (де)шифровать, вводится в \"поле ввода\". Ключ вводится в поле \"ключ\". При нажатии кнопок шифрования или дешифрования результат выводится в поле \"результат\".\n\nКнопки загрузки и сохранения находятся рядом с полем ввода и полем результата соответственно, и позволяют: \n1. Выбирать текстовый файл, чтобы загрузить его текст в поле ввода\n2. Сохранить текст из поля результата в текстовый файл", "Справка");
        }
    }
}
