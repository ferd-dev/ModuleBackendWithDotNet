using ModuleBackendWithDotNet;

class Program
{
    static void Main(string[] args)
    {
        MathOperations mathOperation = new MathOperations();

        Console.WriteLine("Basic Delegate Usage");
        mathOperation.BasicDelegateUsage();

        Console.WriteLine("\nMulticast Delegate Usage:");
        mathOperation.MulticastDelegates();
    }
}