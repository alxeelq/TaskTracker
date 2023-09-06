namespace TaskTracker;

public class Program
{
    private static char _key = ' ';
    private static string _errorMessage = "";

    public static void Main(string[] args)
    {

        while (true)
        {
            Console.Clear();

            if (_errorMessage != "")
                Console.WriteLine(_errorMessage);

            int choosedMenuOption = ChooseMenuOption();

            ExecuteMenuAction(choosedMenuOption);
        }
    }

    private static int ChooseMenuOption()
    {
        DisplayMenu();
        int choosedOption = GetKeyInput();

        return choosedOption;
    }

    private static int GetKeyInput()
    {
        _key = Console.ReadKey().KeyChar;
        bool doesParsed = int.TryParse(_key.ToString(), result: out int keyInput);

        if (doesParsed)
            return keyInput;
        else
            return -1;
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("Welcome to task tracker!");
        Console.WriteLine("1. Display tasks");
        Console.WriteLine("2. Add task");
        Console.WriteLine("3. Update task");
        Console.WriteLine("4. Delete task");
        Console.WriteLine("5. Save tasks");
        Console.WriteLine("6. Load tasks");
        Console.WriteLine("0. Exit");
    }

    private static void ExecuteMenuAction(int choosedMenuOption)
    {
        switch (choosedMenuOption)
        {
            case 1:
                HandleDisplayingOfTasks();
                break;

            case 2:
                break;

            case 3:
                break;

            case 4:
                break;

            case 5:
                break;

            case 6:
                break;

            case 0:
                Environment.Exit(0);
                break;

            default:
                break;
        }
    }

    public static void HandleDisplayingOfTasks()
    {   
        while (true)
        {
            Console.Clear();

            if (_errorMessage != "")
                Console.WriteLine(_errorMessage);

            DisplayTasks();
            int choosedOption = GetKeyInput();

            switch (choosedOption)
            {
                case 0:
                    _errorMessage = "";
                    return;

                default:
                    _errorMessage = "There is no such option";
                    break;
            }
        }
    }

    public static void DisplayTasks()
    {
        Console.WriteLine("Viewing tasks!");
        Console.WriteLine("0. Return to menu");
    }

    public static int ChooseDisplayTasksOption()
    {
        int choosedOption = GetKeyInput();

        return choosedOption;
    }
}
