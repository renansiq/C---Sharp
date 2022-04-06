// See https://aka.ms/new-console-template for more information
Console.Clear();

var meuArray = new int[5] { 1, 2, 3, 4, 5 };

Console.WriteLine(meuArray[0]);
Console.WriteLine(meuArray[1]);
Console.WriteLine(meuArray[2]);
Console.WriteLine(meuArray[3]);
Console.WriteLine(meuArray[4]);

meuArray[0] = 12;

Console.WriteLine(meuArray[0]);

var meuArray2 = new Teste[3];

meuArray2[0].Id = 1;
meuArray2[0].nome = "Renan";
meuArray2[0].idade = 31;

Console.WriteLine(meuArray2[0].Id);
Console.WriteLine(meuArray2[0].nome);
Console.WriteLine(meuArray2[0].idade);

meuArray2[1].Id = 2;
meuArray2[1].nome = "Augusto";
meuArray2[1].idade = 20;

Console.WriteLine(meuArray2[1].Id);
Console.WriteLine(meuArray2[1].nome);
Console.WriteLine(meuArray2[1].idade);

meuArray2[2].Id = 3;
meuArray2[2].nome = "Siqueira";
meuArray2[2].idade = 10;

Console.WriteLine(meuArray2[2].Id);
Console.WriteLine(meuArray2[2].nome);
Console.WriteLine(meuArray2[2].idade);

var meuArray3 = new int[5] {1, 2, 3, 4, 5};

for (int index = 0; index < meuArray3.Length; index++)
{
    Console.WriteLine(meuArray3[index]);
}

foreach (var item in meuArray3)
{
    Console.WriteLine(item);
}

var funcionarios = new Funcionario[5];

funcionarios[0] = new Funcionario(){Id = 1, name = "Renan" };

foreach (var funcionario in funcionarios)
{
    Console.WriteLine(funcionario.Id);
    Console.WriteLine(funcionario.name);
}

var primeiro = new int[4];
var segundo = primeiro;

primeiro[0] = segundo[0];
primeiro.CopyTo(segundo, 0);

primeiro[0] = 50;
Console.WriteLine(segundo[0]);

public struct Funcionario
{
    public int Id { get; set; }
    public string name { get; set; }
}

struct Teste
{
    public int Id { get; set; }
    public string nome { get; set; }
    public int idade { get; set; }
}