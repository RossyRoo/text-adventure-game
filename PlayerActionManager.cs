internal class PlayerActionManager()
{

    public static void GoToNewArea(int direction)
    {
        switch(direction)
        {
            case 0:
                Console.WriteLine("You head north.");
                break;
            case 1:
                Console.WriteLine("You head south.");
                break;
            case 2:
                Console.WriteLine("You head east.");
                break;
            case 3:
                Console.WriteLine("You head west.");
                break;
        }
    }

}