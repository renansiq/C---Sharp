// See https://aka.ms/new-console-template for more information
Menu();
static void Menu()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Calculadora\n");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicacão");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("-------------------");
        Console.Write("Escolha uma opção do Menu: ");
        Calculadora Opcao = (Calculadora)int.Parse(Console.ReadLine());

        switch (Opcao)
        {
            case Calculadora.Soma: Soma(); break;
            case Calculadora.Subtração: Subtracao(); break;
            case Calculadora.Divisão: Divisao(); break;
            case Calculadora.Multiplicação: Multiplicacao(); break;
            case Calculadora.Sair: System.Environment.Exit(0); break;
            default: Console.WriteLine("Opção inválida!"); Console.ReadKey(); break;
        }
    } // looping infinito
}

static void Soma()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    float resultadoSoma = v1 + v2;
    Console.WriteLine("");

    //formas de exibir uma string
    // Console.WriteLine("O resultado da soma é " + resultado);
    Console.WriteLine($"O resultado da soma é {resultadoSoma}");            // interpolação
                                                                            // Console.WriteLine("O resultado da soma é {0}", resultado);
                                                                            // Console.WriteLine($"O resultado da soma é {v1 + v2}");           // interpolação
                                                                            // Console.WriteLine("O resultado da soma é " + (v1 + v2));
    Console.ReadKey();
}

static void Subtracao()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor:");
    float v3 = float.Parse(Console.ReadLine());
    float v4 = float.Parse(Console.ReadLine());
    float resultadoSub = v3 - v4;

    Console.WriteLine();
    Console.WriteLine($"O resultado da subtração é {resultadoSub} ");
    Console.ReadKey();
}

static void Divisao()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor");
    float v5 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo valor:");
    float v6 = float.Parse(Console.ReadLine());
    float resultadoDiv = 0.0f;

    Console.WriteLine("");

    if (v6 == 0)
    {
        Console.WriteLine("Não é possível fazer divisão por 0");
        Console.ReadKey();
        return;
    }
    else
        resultadoDiv = v5 / v6;
    Console.WriteLine($"O resultado da divisão é {resultadoDiv}");
    Console.ReadKey();
}

static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float v7 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    float v8 = float.Parse(Console.ReadLine());

    float resultadoMult = v7 * v8;

    Console.WriteLine("");
    Console.WriteLine($"O resultado da multiplicação é {resultadoMult}");
    Console.ReadKey();
}

enum Calculadora
{
    Soma = 1,
    Subtração = 2,
    Divisão = 3,
    Multiplicação = 4,
    Sair = 5
}