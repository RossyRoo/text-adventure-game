internal class Program
{
    private static void Main(string[] args)
    {
        string playerName = "";
        string nextDir;
        
        Console.WriteLine("What is your name?");
        playerName = Console.ReadLine();

        Console.WriteLine("Hello " + playerName);
        Console.WriteLine("Where would you like to go?");
        nextDir = Console.ReadLine();
        Console.WriteLine("Heading " + nextDir);
    }
}