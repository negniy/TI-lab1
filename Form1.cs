using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        // Класс узла дерева Хаффмана
        public class HuffmanNode
        {
            public char Symbol { get; set; }
            public double Frequency { get; set; }
            public int Id { get; set; }
            public HuffmanNode Left { get; set; }
            public HuffmanNode Right { get; set; }
        }

        // Класс интервала символа
        public class SymbolInterval
        {
            public char Symbol { get; set; }
            public double Low { get; set; }  // Нижняя граница интервала
            public double High { get; set; } // Верхняя граница интервала
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
            txtCompression.Text = (1.0 - (double)txtCode.Text.Length / (input.Length * 8)).ToString("P2"); // степень сжатия
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
        
        // Рекурсивный метод для построения кодов символов
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

        // Метод, который вызывается при нажатии кнопки "Закодировать" для метода Хаффмана
        private void btnHuffmanEncode_Click(object sender, EventArgs e)
        {
            string input = txtFIO2.Text; // Получаем строку ФИО
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Введите строку для кодирования!");
                return;
            }

            // Вычисляем вероятности символов
            var frequencies = CalculateProbabilities(input);

            // Кодируем методом Хаффмана
            var huffmanCodes = Huffman(frequencies);

            

            // Выводим закодированную строку
            txtCode2.Text = EncodeString(input, huffmanCodes);

            // Выводим вероятности в TextBox
            txtProbabilities2.Text = "";
            foreach (var pair in frequencies)
            {
                txtProbabilities2.AppendText($"{pair.Key}: {pair.Value:P2}\r\n");
            }

            // Выводим объемы строки
            txtOriginalSize2.Text = (input.Length * 8).ToString(); // объем исходной строки в битах (1 символ = 8 бит)
            txtEncodedSize2.Text = txtCode2.Text.Length.ToString(); // объем закодированной строки в битах
            txtCompression2.Text = (1.0-(double)txtCode2.Text.Length / (input.Length * 8)).ToString("P2"); // степень сжатия
        }

        // Метод кодирования методом Хаффмана
        private Dictionary<char, string> Huffman(Dictionary<char, double> frequencies)
        {
            int id = 0;

            // Создаем очередь с приоритетом для узлов
            var priorityQueue = new SortedSet<HuffmanNode>(
            Comparer<HuffmanNode>.Create((x, y) =>
            {
                int compare = x.Frequency.CompareTo(y.Frequency);
                if (compare == 0)
                {
                    return x.Id.CompareTo(y.Id);
                }
                return compare;
            }));

            // Создаем узлы для каждого символа
            foreach (var kvp in frequencies)
            {
                priorityQueue.Add(new HuffmanNode { Symbol = kvp.Key, Frequency = kvp.Value, Id = id, Left=null, Right=null });
                id++;
            }

            // Строим дерево Хаффмана
            while (priorityQueue.Count > 1)
            {
                id++;
                HuffmanNode left = priorityQueue.Min; priorityQueue.Remove(left);
                HuffmanNode right = priorityQueue.Min; priorityQueue.Remove(right);

                HuffmanNode parent = new HuffmanNode
                {
                    Symbol = '\0',
                    Frequency = left.Frequency + right.Frequency,
                    Id = id,
                    Left = left,
                    Right = right
                };
                priorityQueue.Add(parent);
            }

            foreach (var node in priorityQueue)
            {
                if (node.Symbol != '0')
                {
                    Debug.WriteLine($"Символ: {node.Symbol}, Частота: {node.Frequency}");
                }
                else
                {
                    Debug.WriteLine($"Внутренний узел, Частота: {node.Frequency}");
                }
            }

            // Создаем коды символов
            var root = priorityQueue.Min;
            var huffmanCodes = new Dictionary<char, string>();
            BuildHuffmanCodes(root, "", huffmanCodes);

            return huffmanCodes;
        }

        // Рекурсивный метод для построения кодов символов
        private void BuildHuffmanCodes(HuffmanNode node, string code, Dictionary<char, string> huffmanCodes)
        {
            if (node == null)
                return;

            // Если это лист, то добавляем символ и его код
            if (node.Left == null && node.Right == null)
            {
                huffmanCodes[node.Symbol] = code;
            }

            // Проходим по левому и правому узлу
            BuildHuffmanCodes(node.Left, code + "0", huffmanCodes);
            BuildHuffmanCodes(node.Right, code + "1", huffmanCodes);
        }

        // Метод построения интервалов
        private List<SymbolInterval> BuildIntervals(Dictionary<char, double> probabilities)
        {
            List<SymbolInterval> intervals = new List<SymbolInterval>();
            double low = 0.0;

            foreach (var kvp in probabilities)
            {
                double high = low + kvp.Value; // Верхняя граница интервала для символа

                intervals.Add(new SymbolInterval
                {
                    Symbol = kvp.Key,
                    Low = low,
                    High = high
                });

                low = high; // Обновляем нижнюю границу для следующего символа
            }

            return intervals;
        }

        // Метод для кодирования строки по арифметическому методу
        public double Encode(string input)
        {
            var probabilities = CalculateProbabilities(input);
            var intervals = BuildIntervals(probabilities);

            // Начальные границы интервала для всего сообщения
            double low = 0.0;
            double high = 1.0;

            // Обрабатываем каждый символ строки
            foreach (char c in input)
            {
                // Находим интервал для текущего символа
                SymbolInterval interval = intervals.First(i => i.Symbol == c);

                // Обновляем границы интервала
                double range = high - low;
                high = low + range * interval.High;
                low = low + range * interval.Low;
            }

            // Итоговое значение в финальном интервале
            // Мы можем взять любое число между low и high
            double encodedValue = (low + high) / 2.0;

            return encodedValue;
        }

        // Обработка нажатия кнопки "Закодировать"
        private void btnAlgEncode_Click(object sender, EventArgs e)
        {
            string input = txtFIO3.Text;

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Введите строку для кодирования!");
                return;
            }

            // Кодирование строки
            double encodedValue = Encode(input);
            txtCode3.Text = encodedValue.ToString();

            // Вывод объема строки
            txtOriginalSize3.Text = (input.Length * 8).ToString(); // объем исходной строки в битах (8 бит на символ)
            txtEncodedSize3.Text = encodedValue.ToString().Length.ToString(); // объем закодированного значения

            // Вывод степени сжатия
            txtCompression3.Text = (1.0 - (double)txtEncodedSize3.Text.Length / (input.Length * 8)).ToString("P2");
        }
    }
}
