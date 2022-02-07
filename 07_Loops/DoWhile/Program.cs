// Will run at least one time before even checking condition

int iterator = 0;

do
{
    Console.WriteLine("Hello!");
    iterator++;
}
while (iterator < 5);

do 
{
    Console.WriteLine("My condition is false");
}
while(false);
