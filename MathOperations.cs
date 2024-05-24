using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleBackendWithDotNet
{
    delegate int MathOperation(int a, int b);
    internal class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public void BasicDelegateUsage()
        {
            MathOperation operation = new MathOperation(Add);
            int result = operation.Invoke(5, 3);
            Console.WriteLine($"La suma es: {result}");

            operation = new MathOperation(Subtract);
            result = operation.Invoke(5, 3);
            Console.WriteLine($"La resta es: {result}");
        }

        public void MulticastDelegates()
        {
            MathOperation operation = null;
            operation += Add;
            operation += Subtract;


            Delegate[] delegateList = operation.GetInvocationList();
            foreach (MathOperation op in delegateList)
            {
                int result = op.Invoke(5, 3);
                Console.WriteLine("Result: " + result);
            }
        }
    }
}
