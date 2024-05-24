using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleBackendWithDotNet
{
    internal class QueueManager
    {
        private Queue<string> _customers = new Queue<string>();

        public QueueManager()
        {
            _customers.Enqueue("Customer 1");
            _customers.Enqueue("Customer 2");
            _customers.Enqueue("Customer 3");
            _customers.Enqueue("Customer 4");
            _customers.Enqueue("Customer 5");
        }

        public void Print()
        {
            Console.WriteLine("Print Queue Customers");
            foreach (var item in _customers)
            {
                Console.WriteLine(item);
            }
        }

        public void DeleteCustomer()
        {
            _customers.Dequeue();
        }
    }
}
