//Menu();

Sample leitura = new Sample();

leitura.writeLine();

static void PreStart(int time){
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("Go...");
    Thread.Sleep(2500);

    Start (time);
}

static void Menu(){
    Console.Clear();
    Console.WriteLine("S - Segundo => 10s = 10 segunos");
    Console.WriteLine("M - Minuto => 1. = 1 minuto");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Quanto tempo deseja contar?");
    
    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));
    int multiplier = 1; 

    if (type == 'm')
        multiplier = 60;

    if(time == 0)
        System.Environment.Exit(0);

    PreStart(time * multiplier);     
}

static void Start( int time)        // quanto este contador vai contar
{         
    int currentTime = 0;   // minuto atual

    while (currentTime != time)         
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);         // aguarda um segundo a cada laço de repetição - milesegundos (1000) = 1 segundo
    }

    Console.Clear();
    Console.WriteLine("Stopwatch finalizado");
    Thread.Sleep(2500);
    Menu();
}