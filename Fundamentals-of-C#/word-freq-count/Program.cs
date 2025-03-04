Console.WriteLine("Please, Enter a word: ");
string word = Console.ReadLine() ?? string.Empty;

word = word.ToLower();

Dictionary<char, int> charCount = new Dictionary<char, int>();
foreach (char c in word)
{
    if (charCount.ContainsKey(c))
    {
        charCount[c]++;
    }
    else
    {
        charCount.Add(c, 1);
    }
}

foreach (var item in charCount)
{
    Console.WriteLine($"Character: {item.Key}, Count: {item.Value}");
}