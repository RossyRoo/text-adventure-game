internal class Program
{
    private static void Main(string[] args)
    {
        Player player = new Player();

        string playerName = "";
        
        Console.WriteLine("What is your name?");
        player.SetPlayerName(Console.ReadLine());

        Console.WriteLine("Hello " + player.GetPlayerName());
    }
}

internal class Player
{
    private string _playerName;
    public string GetPlayerName() => _playerName;

    public void SetPlayerName(string playerName) =>_playerName = playerName;
}