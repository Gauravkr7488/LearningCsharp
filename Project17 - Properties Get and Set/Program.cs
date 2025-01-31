// class Person{
//     private string name;

//     public string ThisIsThePropertyForSettingUpName
//     {
//         get { return name;}
//         // set { name = value;}
//     }



//     static void Main()
//     {
//         Person Bob = new();
//         // Bob.ThisIsThePropertyForSettingUpName = "Bob";
//         Bob.name = "Bob";
//         Console.WriteLine(Bob.name);

//     }
// }

class Person
{
    private string name; // Private field

    public string Name // Property
    {
        get { return name; }
        set { name = value; }
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Name = "Alice";  // ✅ Using property to set value
        Console.WriteLine(p.Name);  // ✅ Using property to get value
    }
}
