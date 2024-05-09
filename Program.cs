internal class Program
{
    private static void Main(string[] args)
    {
        string playerName = "";
        
        Console.WriteLine("What is your name?");
        playerName = Console.ReadLine();

        Console.WriteLine("Hello " + playerName);
    }
}