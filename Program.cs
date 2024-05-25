using ModuleBackendWithDotNet;

TextProcessor textProcessor = new TextProcessor("texto.txt");

// Step 2: Reading the Text File
textProcessor.ReadTextFile();

Console.WriteLine("Step 3: Word Count");
int count = textProcessor.CountWords();
Console.WriteLine($"Count = {count}");

Console.WriteLine("\nStep 4: Character Frequency Analysis");
var frequency = textProcessor.CalculateCharacterFrequency();
foreach (var item in frequency) {
    Console.Write($"{item.Key}: {item.Value} | ");
}

Console.WriteLine("\n\nStep 5: Finding the Longest Word\r");
var longestWord = textProcessor.FindLongestWord();
Console.WriteLine($"Long Word = {longestWord}");


