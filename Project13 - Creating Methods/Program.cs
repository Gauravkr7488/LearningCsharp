// void DisplayRandomNumbers()
// {
//     Random random = new();

//     for (int i = 0; i < 5; i++)
//     {
//         Console.WriteLine($"{random.Next(1, 6)}");
//     }
// }

// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers();


// void DisplayRandomNumbers(int start, int end, int length)
// {
//     Random random = new();

//     for (int i = 0; i < length; i++)
//     {
//         Console.WriteLine($"{random.Next(start, end)}");
//     }
// }

// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers(9, 22, 10);

// int add(int a, int b){
//     return(a+b);
// }

// int sum = add(10, 15);
// Console.WriteLine(sum);

char[] GenerateCharacterArray(string a)
{
    char[] chars = a.ToCharArray();

    return chars;
}

char[] array = GenerateCharacterArray("Hello");
foreach (var item in array)
{
    Console.WriteLine(item);
}