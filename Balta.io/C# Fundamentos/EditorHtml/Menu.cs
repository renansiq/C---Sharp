public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;
        DrawScreen();
        WriteOptions();

        var option = short.Parse(Console.ReadLine());

        HandleMenuOption(option);
    }
    public static void DrawScreen()
    {
        //+-----------------------------------+
        //|                                   |
        //|                                   |
        //|                                   |
        //|                                   |
        //|                                   |
        //+-----------------------------------+        

        DrawLine();
        DrawColumn();
        DrawLine();
    }

    public static void DrawLine()
    {
        int column = 30;
        Console.Write("+");
        for (int i = 0; i <= column; i++)
            Console.Write("-");

        Console.Write("+");
        Console.Write("\n");
    }

    public static void DrawColumn()
    {
        int line = 15;
        int column = 30;

        for (int lines = 0; lines <= line; lines++)
        {
            Console.Write("|");
            for (int i = 0; i <= column; i++)
                Console.Write(" ");

            Console.Write("|");
            Console.Write("\n");
        }
    }

    public static void WriteOptions()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Editor HTML");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("============================");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Seleciona uma opção abaixo:");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("1 - Novo arquivo");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("2 - Abrir");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine("3 - Texto com <Strong>");
        Console.SetCursorPosition(3, 10);
        Console.WriteLine("0 - Sair");
        Console.SetCursorPosition(3, 12);
        Console.Write("Opção: ");
    }

    public static void HandleMenuOption(short option)
    {
        switch (option)
        {
            case 1: Editor.Show(); break;
            case 2: Editor.Abrir(); break;
            case 3: Viewer.Show("vamos testar o <strong>Negrito</strong>"); break;
            case 0:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
            default: Show(); break;
        }
    }
}