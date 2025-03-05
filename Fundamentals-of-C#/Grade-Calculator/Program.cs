// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello there!");
Console.WriteLine("Please, Enter your name:");
String studName = Console.ReadLine() ?? "Student";

Console.WriteLine("Enter the number of subjects:");
string input = Console.ReadLine() ?? "0"; // Read input once

int numSub;
while (!int.TryParse(input, out numSub) || numSub < 1)
{
    Console.WriteLine("Please enter a valid number of subjects:");
    input = Console.ReadLine() ?? "0"; // Read input again if invalid
}

Dictionary<string, int> grades = new Dictionary<string, int>();
for ( int i =0; i < numSub; i++) {
    Console.WriteLine($"Enter the name of the subject {i + 1}: ");
    string subName = Console.ReadLine() ?? "subject";

    double grade;
    while ( true ){
        Console.WriteLine($"Enter the grade of {subName}: ");
        if (double.TryParse(Console.ReadLine(), out grade) && grade >= 0 && grade <= 100)
        {
            grades[subName] = (int)grade;
            break;
        }
        else
        {
            Console.WriteLine("Please enter a valid grade(0 - 100)");
        }
    }
}

static double CalculateAverage(Dictionary<string, int> grades) {

    if (grades.Count == 0) return 0; 


    double sum = 0;
    foreach (var grade in grades.Values) {
        sum += grade;
    }
    return sum / grades.Count;
}

Console.WriteLine($"Student Name: {studName}");
foreach (var gradee in grades)
{
    Console.WriteLine($"Subject: {gradee.Key}, Grade: {gradee.Value}");
}

Console.WriteLine("The average grade is: " + CalculateAverage(grades));