internal class InputHandler
{
    // This function attempts to massage the player's input into a valid game command
    static public void ParseInput(string input)
    {
        input = input.ToUpper().Trim().Replace(" ","");

        switch(input)
            {
                case "GONORTH":
                    PlayerActionManager.GoToNewArea(0);
                    break;
                case "GOSOUTH":
                    PlayerActionManager.GoToNewArea(1);
                    break;
                case "GOEAST":
                    PlayerActionManager.GoToNewArea(2);
                    break;
                case "GOWEST":
                    PlayerActionManager.GoToNewArea(3);
                    break;
                default:
                    Console.WriteLine("Please enter a valid command.");
                    break;
            }
    }
}