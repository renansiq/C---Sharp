using System.Text;

public class Editor
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("MODO EDITOR");
        Console.WriteLine("-------------------------");
        Start();
    }

    static void Start()
    {
        var file = new StringBuilder();

        do
        {
            file.Append(Console.ReadLine());
            file.Append(Environment.NewLine);
        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Console.WriteLine("------------------");
        Console.WriteLine("Deseja salvar o arquivo?");

        char escolha = char.Parse(Console.ReadLine().ToLower());
        if (escolha == 's')
            Salvar(file.ToString());

        Console.Clear();
        Console.WriteLine("O arquivo NÃO foi salvo pelo operador!");
        Thread.Sleep(3000);
        Menu.Show();
    }

    // 1- Novo arquivo
    static void Salvar(string text)
    {
        Console.Clear();
        Console.WriteLine("Qual o caminho para salvar o arquivo?");
        var path = Console.ReadLine();

        using (var file = new StreamWriter(path))
        {
            file.Write(text);
        }

        Console.WriteLine($"Arquivo {path} salvo com Sucesso");
        Console.Beep();
        Console.ReadLine();
        Menu.Show();
    }

    // 2 - Abrir
    public static void Abrir()
    {
        Console.Clear();
        Console.WriteLine("Qual o caminho do arquivo?");
        string path = Console.ReadLine();

        using (var file = new StreamReader(path))
        {
            string text = file.ReadToEnd();
            Console.WriteLine(text);
        }
        Console.WriteLine(" ");
        Console.ReadLine();
        Console.WriteLine("Encerrando leitura! ");
        Thread.Sleep(2000);
        Menu.Show();
    }
}