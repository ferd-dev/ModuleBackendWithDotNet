using ModuleBackendWithDotNet;

Console.WriteLine("Part 1: Lists");
ListManager listManager = new ListManager();
listManager.Print();
listManager.Delete();
listManager.Print();

Console.WriteLine();

Console.WriteLine("Part 2: Dictionaries");
DictionarieManager dictionarieManager = new DictionarieManager();
dictionarieManager.PrintPar();
dictionarieManager.UpdateAndDelete();
dictionarieManager.PrintPar();

Console.WriteLine();

Console.WriteLine("Part 3: Queues");
QueueManager queueManager = new QueueManager();
queueManager.Print();
queueManager.DeleteCustomer();
queueManager.DeleteCustomer();
queueManager.Print();

Console.WriteLine();

Console.WriteLine("Part 4: Stacks");
StackManager stackManager = new StackManager();
stackManager.Print();
stackManager.Remove();
stackManager.Remove();
stackManager.Print();

