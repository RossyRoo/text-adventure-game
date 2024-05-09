internal class Program
{
    private static void Main(string[] args)
    {
        string playerName = "";
        
        Console.WriteLine("What is your name?");
        playerName = Console.ReadLine();

        Console.WriteLine("Hello " + playerName);
        Console.WriteLine("Where would you like to go?");
    }
}