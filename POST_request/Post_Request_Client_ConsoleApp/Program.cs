
using System.Text;

class Program
{
    static async Task Main()
    {
        using HttpClient client = new HttpClient();

        while (true)
        {
            Console.Write("Enter a message (or 'exit' to quit): ");
            string message = Console.ReadLine();

            if (message?.ToLower() == "exit")
                break;

            await SendMessage(client, message);
        }
    }

    static async Task SendMessage(HttpClient client, string message)
    {
        string url = "http://localhost:5119/api/string"; // Enter the url here

        var content = new StringContent($"\"{message}\"", Encoding.UTF8, "application/json");

        HttpResponseMessage response = await client.PostAsync(url, content);

        string responseText = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"Response : {responseText}");
    }
}