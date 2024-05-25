using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleBackendWithDotNet
{
    internal class TextProcessor
    {
        private string _filePath;
        private string _text;
        public TextProcessor(string filePath)
        {
            _filePath = filePath;
            string text = ReadTextFile();
            _text = text;
        }
        public string ReadTextFile()
        {
            try
            {
                return File.ReadAllText("../../../" + _filePath);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("El archivo no fue encontrado.");
                return "";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
                return "";
            }
        }

        public int CountWords()
        {
            if (string.IsNullOrWhiteSpace(_text))
            {
                return 0;
            }

            var words = _text.Split(new[] { ' ', '\n', '\r', '\t', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        public Dictionary<char, int> CalculateCharacterFrequency()
        {
            return _text.Where(char.IsLetterOrDigit)
                    .GroupBy(c => c)
                    .ToDictionary(g => g.Key, g => g.Count());
        }

        public string FindLongestWord()
        {
            var words = _text.Split(new[] { ' ', '\n', '\r', '\t', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return words.OrderByDescending(word => word.Length).FirstOrDefault();
        }
    }
}
