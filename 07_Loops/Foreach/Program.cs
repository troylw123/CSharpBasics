string instructorName = "Jacob";
// Creating an array
string[] instructors = new string[] {"Adam", "Kate", instructorName};

// foreach (declaredIterator in enumberableCollection) { body}

// created new variable "name" that only exists within loop
foreach (string name in instructors) 
{
    Console.WriteLine($"Hello {name}");
}

foreach (char letter in instructorName)
{
    Console.WriteLine(letter);
}
// Strings are collections of letters and can be interated over in foreach's

// Exercise

int[] points = new int[] {8, -12, 16, -20, 24};
foreach (int score in points)
{
    if (score >= 0)
    {
        Console.WriteLine("positive number");
    }
    else {
        Console.WriteLine("negative number");
    }
}

// Quicker way using a ternary

int [] numbers = new int[] {5, 10, -8, 0, 4, -203};

foreach (int answer in numbers) 
{
    string sign = answer > 0 ? "positive" : answer == 0 ? "neutral" : "negative";
    Console.WriteLine($"{answer} is a {sign} number.");
}