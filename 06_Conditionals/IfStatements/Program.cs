bool isSnowing = false;
bool isGoingOutside = true;
//  if (true/false value)
// {
// body of the code, execute this code if above is true
// }
if(isSnowing) 
{
    Console.WriteLine("It is snowing out!");
}
/* comment 
covering
multiple lines */

if(isSnowing && isGoingOutside)
{
    Console.WriteLine("Better wear some snow boots!!!");
}
// bang operator (!) means false or opposite
if(!isSnowing || !isGoingOutside)
{
    Console.WriteLine("I do not need any boots!!");
}
if(isSnowing ^ isGoingOutside)
{
    Console.WriteLine("I will only go outside once the snow stops.");
}
// && means and, || means or, ^ means only 1 is true, not neither or both
// | is a pipe, ^ is a carat

if(!isSnowing)
{
    Console.WriteLine("There is no need to shovel snow.");
}
else
{
    Console.WriteLine("I guess I need to shovel the driveway.");
}

if(isSnowing){
    Console.WriteLine("I guess I have to go clear off the wifes car.");
}
else if(!isSnowing){
    Console.WriteLine("I don't have to clear off the car!");
}
else {
    Console.WriteLine("I don't know what we are even talking about!!");
}

bool hasUmbrella = false;
bool isGoingOutWhileRaining = true;

if(hasUmbrella && isGoingOutWhileRaining){
    Console.WriteLine("You are good to go, sir!");
}
else if (isGoingOutWhileRaining) {
    Console.WriteLine("Get an umbrella or else you'll get wet.");
}
else {
    Console.WriteLine("What are you worried about? It's not raining.");
}
