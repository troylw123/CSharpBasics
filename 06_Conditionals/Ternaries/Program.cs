// Write doesn't have a line break after it like WriteLine does
Console.Write("Enter your age:");
string response = System.Console.ReadLine();
// Parse changes type to int, if possible
int age = int.Parse(response);

string output = age >= 18 ? "You can vote!" : "You're too young to vote.";

Console.WriteLine(output);

// This is the challenge to write the above ternary as an if else
// if (age >= 18){
//     Console.WriteLine("You can vote!");
// }
// else {
//     Console.WriteLine("You're too young to vote.");
// }


