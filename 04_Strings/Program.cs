string first = "The cars we sell are";
string second = "BMW, Lexus, Mercedes, and Tesla.";

// String Concatenation
string concatenatedResult = first + " " + second;
Console.WriteLine(concatenatedResult);


string firstName = "Jenn";
string lastName = "Williams";

// Composite Formatting
string compositeResult = string.Format("Her name is {0} {1}", firstName, lastName);
Console.WriteLine(compositeResult);
Console.WriteLine("Her name is {0} {1}.", firstName, lastName);

// String Interpolation
string interpolationResult = $"Her name is still {firstName} {lastName}!";
Console.WriteLine(interpolationResult);
Console.WriteLine($"Her name is still {firstName} {lastName}!");


// More Practice
string concatenation = "What is " + firstName +" up to?";
Console.WriteLine(concatenation);

string composite = string.Format("Where is Mrs. {0} today?", lastName);
Console.WriteLine(composite);

string interpolation = $"Driving {second} is for snooty, rich people.";
Console.WriteLine(interpolation);

Console.WriteLine(firstName + " drives a " + second);
Console.WriteLine("{0} {1} is a snooty, rich person", firstName, lastName);
Console.WriteLine($"We sell cars to people named {firstName} {lastName}");

