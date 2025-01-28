// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// int first = 2;
// string second = "4";
// int result = first + int.Parse(second);
// Console.WriteLine(result);

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");


// string first = "5.35";
// string second = "7";
// decimal sum = decimal.Parse(first) + decimal.Parse(second);
// Console.WriteLine(sum);

string input = "123";
int number;

if (int.TryParse(input, out number))
{
    Console.WriteLine($"Conversion succeeded! The number is {number}");
}
else
{
    Console.WriteLine("Conversion failed. The input is not a valid number.");
}
