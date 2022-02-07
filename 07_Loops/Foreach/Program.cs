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