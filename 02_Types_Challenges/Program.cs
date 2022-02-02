// Bronze Challenge
int myAge = 37;
int myWeight;

string myHairColor = "red";
string myEyeColor;

bool isTall = false;
bool isShort;

float myNumber = 2f;
float notMyNumber;

double trouble = 15.6d;
double bubble;

decimal myWallet = 25.00m;
decimal myAccount;

ulong longNumber = 68686;
ulong shortNumber;

Console.WriteLine(myHairColor);
Console.WriteLine(isTall);
Console.WriteLine(myWallet);
Console.WriteLine(trouble);

// Silver Challenge
string question = "What is the weather doing right now? ";
string answer = "It is currently raining, which is uncalled for.";

string concatenatedResult = question + answer;
Console.WriteLine(concatenatedResult);

Console.WriteLine(question + longNumber);

// Gold Challenge

Console.WriteLine("What year is it?");
string theYear = Console.ReadLine();
Convert.ToInt16(theYear);
Console.WriteLine($"You entered the year " + theYear);

// Other ways I could have done it:
string year = "2021";
int yearNumber = int.Parse(year);
Console.WriteLine(yearNumber);

int anotherNumber = Convert.ToInt32(year);
Console.WriteLine(anotherNumber);





