// Write doesn't have a line break after it like WriteLine does
Console.Write("Enter your age:");
string response = System.Console.ReadLine();
// Parse changes type to int, if possible
int age = int.Parse(response);

string output = age >= 18 ? "You can vote!" : "You're too young to vote.";

Console.WriteLine(output);


