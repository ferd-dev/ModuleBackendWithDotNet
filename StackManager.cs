using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleBackendWithDotNet
{
    internal class StackManager
    {
        private Stack<string> _books = new Stack<string>();
        public StackManager() 
        {
            _books.Push("IT");
            _books.Push("El Resplando");
            _books.Push("Carrie");
            _books.Push("El Visitante");
            _books.Push("La Niebla");
        }

        public void Print()
        {
            Console.WriteLine("Print Stack Books");
            foreach (var book in _books)
            {
                Console.WriteLine($"Title: {book}");
            }
        }

        public void Remove()
        {
            _books.Pop();
        }
    }
}
