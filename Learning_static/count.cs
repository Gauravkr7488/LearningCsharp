
class Greet{
	public static int count = 0;
	public void Greet(){
        Console.WriteLine("Hi how are you ?");
        count++;
	}
}

class programm{
    static void main(){
        Greet Greeting_1 = new();
        Greeting_1.Greet();
    }
}