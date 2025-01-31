class Animal
{
    public string name;
    public virtual void Attack()
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

    public override void Attack(){
        Console.WriteLine($"{name} just kicked you in the face.");
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