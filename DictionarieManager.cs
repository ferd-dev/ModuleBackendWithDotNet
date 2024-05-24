using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleBackendWithDotNet
{
    internal class DictionarieManager
    {
        private Dictionary<string, int> _students = new Dictionary<string, int>();

        public DictionarieManager()
        {
            _students.Add("Fernando", 75);
            _students.Add("Ana", 80);
            _students.Add("Carlos", 70);
            _students.Add("Jose", 55);
            _students.Add("Maria", 91);
        }

        public void PrintPar()
        {
            Console.WriteLine("Print Dictionary Students");
            foreach (string key in _students.Keys)
            {
                Console.WriteLine($"Name: {key} Value: {_students[key]} ");
            }
        }

        public void UpdateAndDelete()
        {
            _students["Fernando"] = 91;
            _students.Remove("Jose");
        }
    }
}
