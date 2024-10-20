using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Lab1_StepanovDmitriy_6411
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Метод, который вызывается при нажатии кнопки "Закодировать"
        private void btnEncode_Click(object sender, EventArgs e)
        {
            string input = txtFIO.Text; // Получаем строку ФИО
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Введите строку для кодирования!");
                return;
            }

            // Вычисляем вероятности символов
            var probabilities = CalculateProbabilities(input);

            // Кодируем методом Шеннона-Фано
            var codes = ShannonFano(probabilities);

            // Выводим закодированную строку
            txtCode.Text = EncodeString(input, codes);

            // Выводим вероятности
            txtProbabilities.Text = "";
            foreach (var pair in probabilities)
            {
                txtProbabilities.AppendText($"{pair.Key}: {pair.Value:P2}\r\n");
            }

            // Выводим объемы строки
            txtOriginalSize.Text = (input.Length * 8).ToString(); // объем исходной строки в битах (1 символ = 8 бит)
            txtEncodedSize.Text = txtCode.Text.Length.ToString(); // объем закодированной строки в битах
            txtCompression.Text = ((double)txtCode.Text.Length / (input.Length * 8)).ToString("P2"); // степень сжатия
        }

        // Метод для вычисления вероятностей появления каждого символа
        private Dictionary<char, double> CalculateProbabilities(string input)
        {
            Dictionary<char, double> probabilities = new Dictionary<char, double>();
            foreach (char c in input)
            {
                if (!probabilities.ContainsKey(c))
                {
                    probabilities[c] = 0;
                }
                probabilities[c]++;
            }

            // Рассчитываем вероятность
            int totalChars = input.Length;
            foreach (char c in probabilities.Keys.ToList())
            {
                probabilities[c] /= totalChars;
            }

            return probabilities.OrderByDescending(p => p.Value).ToDictionary(p => p.Key, p => p.Value);
        }

        // Метод кодирования методом Шеннона-Фано
        private Dictionary<char, string> ShannonFano(Dictionary<char, double> probabilities)
        {
            Dictionary<char, string> codes = new Dictionary<char, string>();
            ShannonFanoRecursive(probabilities.Keys.ToList(), probabilities, codes, "");
            return codes;
        }

        private void ShannonFanoRecursive(List<char> symbols, Dictionary<char, double> probabilities, Dictionary<char, string> codes, string prefix)
        {
            if (symbols.Count == 1)
            {
                codes[symbols[0]] = prefix;
                return;
            }

            double total = symbols.Sum(s => probabilities[s]);
            double half = total / 2;
            double cumulative = 0;
            int splitIndex = 0;

            for (int i = 0; i < symbols.Count; i++)
            {
                cumulative += probabilities[symbols[i]];
                if (cumulative >= half)
                {
                    splitIndex = i;
                    break;
                }
            }

            List<char> left = symbols.Take(splitIndex + 1).ToList();
            List<char> right = symbols.Skip(splitIndex + 1).ToList();

            ShannonFanoRecursive(left, probabilities, codes, prefix + "0");
            ShannonFanoRecursive(right, probabilities, codes, prefix + "1");
        }

        // Метод для кодирования строки с помощью полученных кодов
        private string EncodeString(string input, Dictionary<char, string> codes)
        {
            string encoded = "";
            foreach (char c in input)
            {
                encoded += codes[c];
            }
            return encoded;
        }
    }
}
