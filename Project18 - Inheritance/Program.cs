class Animal
{
    public string name;
    public void Attack()
    {
        Console.WriteLine($"{name} just bit you");
    }
}

class Monkey : Animal
{
    public void Greet()
    {
        Console.WriteLine($"This is {name}, he is a bad monkey");
    }
}

class Application
{

    static void Main()
    {
        Monkey Sam = new()
        {
            name = "Sam"
        };
        Sam.Greet();
        Sam.Attack();
    }
}