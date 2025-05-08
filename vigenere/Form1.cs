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
                        txtResult.Text = Crypt.VigenereEncrypt(message, key);
                        break;
                    case "caesar":
                        int shift = int.Parse(key);
                        txtResult.Text = Crypt.CaesarEncrypt(message, shift);
                        break;
                    case "atbash":
                        txtResult.Text = Crypt.AtbashTransform(message);
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
                        txtResult.Text = Crypt.VigenereDecrypt(message, key);
                        break;
                    case "caesar":
                        int shift = int.Parse(key);
                        txtResult.Text = Crypt.CaesarDecrypt(message, shift);
                        break;
                    case "atbash":
                        txtResult.Text = Crypt.AtbashTransform(message);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
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
