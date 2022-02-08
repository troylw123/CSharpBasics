bool numTest (int number) {
int range = 10;
return Math.Abs(number-100) <= range || Math.Abs(number-200) <= range;
}

Console.WriteLine(numTest(50));
Console.WriteLine(numTest(90));
Console.WriteLine(numTest(3000));
Console.WriteLine(numTest(205));


