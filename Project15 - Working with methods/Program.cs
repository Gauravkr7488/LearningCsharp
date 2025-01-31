// Named arguments
class Progmamm
{

    static void makeSound(string animalOne, string animalTwo)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{animalOne}");
            Console.WriteLine($"{animalTwo}");
        }

    }



    // Method Overloading

    static void makeSound(int one, int two)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(one);
            Console.WriteLine(two);
        }
    }
    static void Main()
    {

        makeSound(1, 2);
        makeSound(animalTwo: "cat", animalOne: "dog");
    }
}