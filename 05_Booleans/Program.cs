bool isCool = false;
isCool = true;

bool isTrue = !false;
bool isFalse = !true;

bool trueAndExample = true && true;
bool falseAndExample = true && false;

bool trueOrExample = true || false;
bool falseOrExample = false || false;

bool trueExclusiveOr = true ^ false;
bool falseExclusiveOr = true ^ true;

Console.WriteLine($"NOT False = {isTrue}");
Console.WriteLine($"False AND True = {falseAndExample}");
Console.WriteLine($"True OR True = {trueOrExample}");
Console.WriteLine($"True XOR True = {falseExclusiveOr}");

bool isGreaterThan = 10 > 10;
bool isGreaterThanOrEqualTo = 10 >= 10;
Console.WriteLine($"10 > 10 is {isGreaterThan}, and 10 >= 10 is {isGreaterThanOrEqualTo}.");

bool isLessThan = 5 < 5;
bool isLessThanOrEqualTo = 5 <=5;
Console.WriteLine($"5 < 5 is {isLessThan} and 5 <= 5 is {isLessThanOrEqualTo}.");

bool equality = 17 == 9;
bool inequality = 17 != 9;
Console.WriteLine($"17 == 9 is {equality} and 17 != 9 is {inequality}.");

