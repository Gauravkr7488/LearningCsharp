
class Greet{
	public static int count = 0;
	public void Greeting(){
        Console.WriteLine("Hi how are you ?");
        count++;
	}
}

class programm{
    static void Main(){
        Greet Greeting_1 = new();
        Greet Greeting_2 = new();
        Greeting_1.Greeting();
        Greeting_2.Greeting();
        Console.WriteLine(Greet.count);
    }
}