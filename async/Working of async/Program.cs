class GetData
{
    static async Task DownloadFile()
    {
        Console.WriteLine("The File is starting to download");
        await Task.Delay(5000);
        Console.WriteLine("File is downloaded");
    }
    static async Task Main()
    {
        Task DownloadTask = DownloadFile();
        Console.WriteLine("The file is being downloaded in the background");
        await DownloadTask;
    }
}