Console.Write("Please give us your name: ");
string name = Console.ReadLine();
// This is a switch expression
string greeting = name switch
{
    "Troy" => "Hello Troy",
    _ => "Who are  you?"
};
// The _ means default or else

Console.WriteLine(greeting);

switch(name) 
{
    case "Troy":
    Console.WriteLine("Nice to meet you, " + name);
    break;
    default: 
    break;
}

Console.Write("How are you feeling today on a scale of 1-5? ");
string feelingRating = Console.ReadLine();
// This is a switch statement
switch(feelingRating)
{
    case "5":
    Console.WriteLine("That is great to hear");
    break;
    case "4":
    Console.WriteLine("Good Stuff");
    break;
    case "3": 
    Console.WriteLine("Hope things improve");
    break;
    case "2":
    Console.WriteLine("Oh no, sorry to hear that");
    break;
    case "1":
    Console.WriteLine("Dang, hope your day can get better soon");
    break;
    default:
    Console.WriteLine("Sorry, what you put in is not what we asked for.");
    break;
}

Console.Write("How were you feeling yesterday on a scale of 1-5? ");
string ratingInput = Console.ReadLine();
int yesterdayRating = int.Parse(ratingInput);

string response = yesterdayRating switch {
    1 => "Dang. Maybe today will be better.",
    2 => "Oh, sorry to hear that.",
    3 => "Nice, sounds like a good day",
    4 => "Good stuff ",
    5 => "That is amazing!",
    _ => "That was not a number between 1 and 5"
};

Console.WriteLine(response);
