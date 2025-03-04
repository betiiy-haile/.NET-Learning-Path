Console.WriteLine("Please the word you want to check for palindrome: ");
string word = Console.ReadLine() ?? string.Empty;

string normalizedWord = NormalizeString(word);
if(isPalindrome(normalizedWord))
{
    Console.WriteLine($"{word} is a palindrome");
}
else
{
    Console.WriteLine($"{word} is not a palindrome");
}

static bool isPalindrome(string word)
{
    int left = 0;
    int right = word.Length - 1;

    while (left < right)
    {
        if (word[left] != word[right])
        {
            return false;
        }
        left++;
        right--;
    }
    return true;
}

static string NormalizeString(string input)
{
    string result = "";

    foreach(char c in input)
    {
        if (char.IsLetter(c))
        {
            result += c;
        }

    }
    return result;
}