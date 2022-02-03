// Challenge #1
int number = 123;
string word = "duck";
DateTime date1 = DateTime.Now;
char atSymbol = '@';
Console.WriteLine(word + date1 + atSymbol + number);

// Challenge #2
int math = 2000-187;
Console.WriteLine(math);

// Challenge #3
Console.Write("What color is your hair? ");
string hairColor = Console.ReadLine();
Console.WriteLine($"You said you have {hairColor} hair. That's weird.");

// Challenge #4
Console.Write("Are you wearing clothes right now? ");
string wearingClothes = Console.ReadLine();

switch (wearingClothes) {
    case "yes": 
    Console.WriteLine("You're doing it right.");
    break;
    case "no":
    Console.WriteLine("That's cool. I like being naked too.");
    break;
    default:
    Console.WriteLine("It was a yes or no question, dummy.");
    break;
}

// Challenge #5
Console.Write("Rate my outfit on a scale of 1-5: ");
string rating = Console.ReadLine();

string response = rating switch {
    "5" => "That is very kind of you.",
    "4" => "I'll take a 4 any day, thanks.",
    "3" => "Middle of the road score.",
    "2" => "Well, that is just hurtful.",
    "1" => "I don't like your outfit either.",
    _ => "Stop dodging the question."
};
Console.WriteLine(response);

// Challenge #6
Console.Write("What do you want from McDonalds? ");
string meal = Console.ReadLine();

string response2 = meal switch {
    "burger" => "I'll get you two burgers just for fun.",
    "nuggets" => "Nuggets are for kids. Do you want a kids' meal?",
    "fries" => "Excellent choice. I'm also getting fries.",
    "salad" => "Salads are for women on diets. No.",
    _ => "You always have to order something unusual."
};
Console.WriteLine(response2);

// Challenge #7
bool happy = true;

if(happy) {
    Console.WriteLine("I'm so glad to hear that.");
}
else {
    Console.WriteLine("Man that sucks. Is there anything I can do?");
}

// Challenge #8
Console.Write("What is your annual salary? ");
string answer = Console.ReadLine();
int salary = int.Parse(answer);

if (salary >= 1000 && salary <= 10000){
    Console.WriteLine("That's really low. You need a new job.");
}
else if (salary > 10000 && salary <= 50000) {
    Console.WriteLine("Not bad. You're getting there.");
}
else if (salary > 50000 && salary <= 100000) {
    Console.WriteLine("You've got it made. Congrats!");
}
else {
    Console.WriteLine("I don't understand that answer. You're either really rich or broke like me.");
}
