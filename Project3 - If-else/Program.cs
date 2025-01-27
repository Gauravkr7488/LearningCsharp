Random dice = new();

int roll1 = dice.Next(1, 6);
int roll2 = dice.Next(1, 6);
int roll3 = dice.Next(1, 6);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"The Total is:{total}");

if (total < 10)
{
    Console.WriteLine("Damn thats low");
}else{
    Console.WriteLine("Good enough");
}