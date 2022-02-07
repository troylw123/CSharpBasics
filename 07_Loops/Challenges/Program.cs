// Bronze Challenge - write a for loop to print numbers 500 through 525

int number = 525;

for (int i = 500; i <= number; i++)
{
    Console.WriteLine(i);
}

// Silver Challenge - write a for loop to print 0-100 by 5's

int numberTwo = 101;

for (int fives = 0; fives < numberTwo; fives+=5)
{
    Console.WriteLine(fives);
}

// Gold Challenge - write a for loop to print 1-100. If the number is divisible by 3, print Fizz instead. If divisible by 5, print Buzz instead. If divisible by both 3 and 5, print FizzBuzz instead.

int numberThree = 101;

for (int fizzle = 1; fizzle < numberThree; fizzle++)
{
    if (fizzle % 5 == 0 && fizzle % 3 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (fizzle % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (fizzle % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else 
    {
        Console.WriteLine(fizzle);
    }
}