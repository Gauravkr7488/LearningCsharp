// class Person{
//     string name;
//     string gender;
//     int age;
//     string job;

//     public void Greet(){
//         Console.Write($"Hi {name}");
//     }

//     static void Main()
//     {
//         Person Bob = new();
//         Bob.name = "Bob";
//         Bob.Greet();
//     }
// }

// Constructors

class Person
{
    string name;
        string gender;
        int age;
        string job;

    public Person()
    {
        gender = "male";
        age = 150;
        job = "Harbinger of death";
    }

    public void Greet()
    {
        Console.Write($"Hi {name} how is you'r {job} going?");
    }

    static void Main()
    {
        Person Bob = new();
        Bob.name = "Bob";
        Bob.Greet();
    }
}