// Class is the noun, property is the adjective, method is the verb
// alt + shift + f to auto format
// Classes and properties use PascalCase

using Classes;

Donut doug = new Donut("Jelly filled", true, false);
doug.SetDonutType("Glazed");
doug.Filling = "Strawberry Jam";
Console.WriteLine(doug.GetDonutType());
Console.WriteLine(doug.Filling);

Donut derrick = new Donut("Chocolate", false, true, 3.99);
Console.WriteLine(derrick.Price);

Greeter greet = new Greeter();
Console.WriteLine(greet.SayHello("Jacob"));
Console.WriteLine(greet.SayHello());

greet.PrintHello("Alex");
greet.PrintHello("Tony");

greet.PrintRandomGreeting();

Calculator calculator = new Calculator();
Console.WriteLine(calculator.Age(new DateTime(1984,12,09)));


namespace Classes
{
    class Donut
    {

        private string donutType;

        public Donut(string type, bool sprinkles, bool icing)
        // public Donut() {} <- Implicit constructor
        // When define constructor (like above), implicit constructor removed
        {
            donutType = type;
            IsSprinkled = sprinkles;
            HasIcing = icing;
        }

        public Donut(string type, bool sprinkles, bool icing, double price)

        {
            donutType = type;
            IsSprinkled = sprinkles;
            HasIcing = icing;
            Price = price;
        }
        // 1     2        3
        public string GetDonutType()
        {
            //  4
            return donutType;
        }
        // 1 Access modifier (public or private)
        // 2 Return type - what type will I get back when I run the method
        // 3 Method signature - Name(Parameters)
        // 4 The body and the return

        public void SetDonutType(string type)
        {
            donutType = type;
        }
        // Properties
        public string Filling { get; set; }
        public bool IsSprinkled { get; set; }
        public bool HasIcing { get; set; }
        public double Price { get; set; }
    }



    // public exists everywhere, private exists only within the class


    class Greeter
    {
        Random _random = new Random();
        public string SayHello()
        {
            return "Hello!";
        }

        // overloaded methods, same names but different parameters, so different signatures
        public string SayHello(string name)
        {
            return $"Hello {name}!";
        }
        // void means not returning any "type" 
        public void PrintHello(string name)
        {
            Console.WriteLine($"Greetings {name}!");
        }
        public void PrintRandomGreeting()
        {
            // Lists/arrays/enumberable index at zero    0       1       3      3       4
            string[] availableGreetings = new string[]{"Hey", "Howdy", "Sup", "Yo", "Good day"};
            int randomNumber = _random.Next(0, availableGreetings.Length);
            string randomGreeting = availableGreetings.ElementAt(randomNumber);
            Console.WriteLine(randomGreeting);
        }
    }

    class Calculator 
    {
        public int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }
        public int Age(DateTime birthdate)
        {
            TimeSpan ageSpan = DateTime.Now - birthdate;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
    }
}