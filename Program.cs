internal class Program
{    private static void Main(string[] args)
    {
        Console.Write("Tell me your name...");
        Player player = new Player(Console.ReadLine());

        Console.WriteLine($"Hello, {player.PlayerName}. What do you want to do?");
        InputHandler.ParseInput(Console.ReadLine());
    }
}