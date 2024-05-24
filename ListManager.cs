using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleBackendWithDotNet
{
    internal class ListManager
    {
        List<int> _numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public void Print()
        {
            Console.WriteLine("Print List integers");
            foreach (var item in _numbers)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }

        public void Delete()
        {
            _numbers.RemoveAt(0);
            _numbers.RemoveAt(_numbers.Count - 1);
        }
    }
}
