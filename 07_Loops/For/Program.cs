// For Loops

int number = 100;
// for (initializer; condition; iterator) {body}

for (int i = 0; i < number; i++)
{
    Console.WriteLine(i);
}

// More complicated for loop
int numberTwo = 200;
for (int i = 1; i <= numberTwo; i++)
{
    numberTwo = numberTwo - i;
    Console.WriteLine(numberTwo);
    Console.WriteLine($"i is {i}");
}

// Exercise

Console.WriteLine("Choose a number for me to count to: ");
string yourInput = Console.ReadLine();

int yourNumber = int.Parse(yourInput);

for (int i = 0; i<= yourNumber; i++)
{
    Console.WriteLine(i);
}