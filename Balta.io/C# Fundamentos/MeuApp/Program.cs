// See https://aka.ms/new-console-template for more information
/* ------------------------------------------------------------------------------------------------------------------------------------------------------
                        Tipos primitivos
------------------------------------------------------------------------------------------------------------------------------------------------------*/
// constantes
const String primeiroNome = "Renan Augusto Siqueira";

// tipos primitivos
byte meuByte = 127;

// números inteiros
int idade = 25;
var idade2 = 30;       // int
// uint idade2 = -30; não aceita valores negativos 

short numero = 35;
long numeroGrande = 566325;

// números reais
var salario = 25.00; // double
float salario2 = 30.00f;  // colocar f
double salarioSemestral = 45.00;
decimal salarioAnual = 25.000m;     // colocar m

//booleanos
bool usuarioJaCadastrado = false;
bool pagamentoRecebido = true;
var usuarioExpirado = false;        // tipo booleano

// char
char primeiroLetra = 'C';
var segundaLetra = 'D';         // definido como char

// String
string primeiraLetra = "C";
string texto = "meu texto";
var documento = "12345.99";

// objetct
object quantidade;      // não é necessário definir um valor na declaração
quantidade = 1;
quantidade = 2.5;
quantidade = "teste";

//trabalhando com nulos
//int idade3 = null;      // erro
int? idade3 = 0;
Console.WriteLine(idade3);
idade3 = null;
Console.WriteLine(idade3);
idade3 = 25;
Console.WriteLine(idade3);

// exibindo as váriáveis no console
/// <properties> valor adicional -> comando XML

Console.WriteLine(texto + "\n" + idade + "\n" + primeiroNome);
/* ------------------------------------------------------------------------------------------------------------------------------------------------------
                       Comeentários
------------------------------------------------------------------------------------------------------------------------------------------------------*/
// teste de comentários -> usando // 

// Ctrl + K + C -> Comentar
// Ctrl + K + U -> Descomentar
// teste de comentários
// teste de comentários
// teste de comentários
// teste de comentários
// teste de comentários
// teste de comentários

/*
comentário de longa duração
.
.
.
.
.
.
.
fim do bloco de comentário
*/
/* ------------------------------------------------------------------------------------------------------------------------------------------------------
                        Conversão - Implícita, explícita, Parse e Convert
------------------------------------------------------------------------------------------------------------------------------------------------------*/
int inteiro = 100;
float real = 25.5f;
// real = inteiro;   //  valor = 100.0f - conversão implícita
// inteiro = (int)real;    // converte 25.5f em 25 - conversão explícita
inteiro = int.Parse("255");   // converti o real 25.5f em string, depois usei o Parse pra converter o texto em int, e atribuí a inteiro
Console.WriteLine(inteiro);
// // ou
// string valorReal = real.ToString();     // criei a varíavel valorReal para receber o valor em texto
// inteiro = int.Parse(valorReal);
// Console.WriteLine(valorReal);  //   ocorreu um problma na conversão da string em int por parte do parse, o melhor é usar casting mesmo

inteiro = Convert.ToInt32(real);        // convertendo valor real em inteiro
// ele arredondou para 26, pois 25.5f arredonda pra cima. se fosse 25.4, arredondo pra baixo
// se precisar de exatidão nos números, não é interessante usar int
Console.WriteLine(inteiro);

Console.WriteLine(Convert.ToBoolean(1));
/* ------------------------------------------------------------------------------------------------------------------------------------------------------
                        Operação aritméticos, atribuição, comparação, lógicos
------------------------------------------------------------------------------------------------------------------------------------------------------*/
int multiplicacao = 22 / 5;       // divisão da 4.4
Console.WriteLine(multiplicacao);       // exibição da 4 (arredondamento)

double x = 2;
x = (2 + 2) * 2;
Console.WriteLine(x);

x += 3;
Console.WriteLine(x);

x *= 2;
Console.WriteLine(x);

x /= 4;
Console.WriteLine(x);

Console.WriteLine("{0} é diferente de 25? " + (x != 25), x);
Console.WriteLine("{0} é menor de 25? " + (x > 25), x);
Console.WriteLine("{0} é igual a 25? " + (x == 25), x);

// condição SE, Senão (IF)
int idade4 = 12;
int maioridade = 21;
int idadeMaxima = 65;

if (idade4 >= maioridade && idade4 < idadeMaxima)
{
    Console.WriteLine("Dentro do intervalo");
}
else if (idade4 > 65)
{
    Console.WriteLine("Velho");
}
else
{
    Console.WriteLine("Menor de idade");
}

Console.WriteLine("Finalizou o programa");

// switch - Exemplo 1
string valor = "andre";
switch (valor)
{
    case "joao": Console.WriteLine("Não é o cara! {0}", valor); break;
    case "Marcelo": Console.WriteLine("Não é o cara!{0}", valor); break;
    case "andre": Console.WriteLine("É este {0}", valor); break;
    default: Console.WriteLine("Não encontrei"); break;
}

// switch - Exemplo 2
bool? valor2 = false;
switch (valor2)
{
    case true: Console.WriteLine("Verdadeiro"); break;
    case false: Console.WriteLine("falso"); break;
    default: Console.WriteLine("Nulo"); break;
}
/* ------------------------------------------------------------------------------------------------------------------------------------------------------
                                  Laços de Repetição
------------------------------------------------------------------------------------------------------------------------------------------------------*/
Console.WriteLine("\nFor incrementando");
for (int i = 5; i >= 0; i--)       // incrementando
{
    Console.WriteLine(i);
}

Console.WriteLine("\nFor decrementando");
for (int i = 0; i <= 5; i++)
{
    Console.WriteLine(i);
}

int valor3 = 0;
while (valor3 <= 5)
{
    Console.WriteLine(valor3);
    valor3++;
}

// Looping infinito de while (sempre vai ser verdade)
// int valor3 = 0;
// while (true)
// {
//     valor3++;
//     Console.WriteLine(valor3);    
// }

//------------- Do / While --------------------------
Console.WriteLine("\n");

valor3 = 0;
do
{
    Console.WriteLine(valor3);
    valor3++;
} while (valor3 <= 5);
/* ------------------------------------------------------------------------------------------------------------------------------------------------------
                                 Funções
	• Parâmetros opcionais podem ser usados desde que tenha um valor atribuído e sempre fiquem por última da declaração do método
    ex: bool teste, double valor
------------------------------------------------------------------------------------------------------------------------------------------------------*/
static void meuMetodo()
{
    Console.WriteLine("C# é legal");
}

static string RetornaNome(string nome, string sobrenome, int idade = 31, bool teste = false, double valor = 35.55)
{
    return nome + " " + sobrenome + " tem " + idade.ToString();
}
meuMetodo();

string nome = RetornaNome("Renan", "Siqueira");
Console.WriteLine(nome);

/* ------------------------------------------------------------------------------------------------------------------------------------------------------
                              Heap e Stack
------------------------------------------------------------------------------------------------------------------------------------------------------*/
int y = 25;
int z = y;        // z é uma cópia de y
Console.WriteLine(y);
Console.WriteLine(z);

y = 32;        // mudar valor de Y
Console.WriteLine(y);       // y alterado para 32
Console.WriteLine(z);       // z permanece 25

var arr = new string[2];
arr[0] = "Item 1";
var arr2 = arr;            // não cria uma cópia

Console.WriteLine("\n" + arr[0]);
Console.WriteLine(arr2[0] + "\n");

//Altera as duas listas
arr[0] = "Item Alterado";
Console.WriteLine(arr[0]);
Console.WriteLine(arr2[0]);

/* ------------------------------------------------------------------------------------------------------------------------------------------------------
                             Struct + Enums
------------------------------------------------------------------------------------------------------------------------------------------------------*/

Product mouse = new Product(1, "Mouse gamer", 299.97f, EProductType.Product);
var manutencaoEletrica = new Product(2, "Manutenção eletrécica residencial", 500.0f, EProductType.Service);


// mouse.Id = 55;

// **************exibição inserida direto no construtor da Struct Product
// Console.WriteLine(mouse.Id);
// Console.WriteLine(mouse.Name);
// Console.WriteLine(mouse.Price + "\n") ;
// Console.WriteLine(mouse.Type);
// Console.WriteLine((int)mouse.Type);

// Console.WriteLine(mouse.PriceInDolar(5.78)) ;

// Console.WriteLine(manutencaoEletrica.Id);
// Console.WriteLine(manutencaoEletrica.Name);
// Console.WriteLine(manutencaoEletrica.Price + "\n") ;
// Console.WriteLine(manutencaoEletrica.Type);
// Console.WriteLine((int)manutencaoEletrica.Type);

struct Product
{
    public int Id;
    public string Name;
    public double Price;
    public const double DOLAR = 4.74;
    public EProductType Type;
    public Product(int id, string name, double price, EProductType type)
    {
        Id = id;
        Name = name;
        Price = price;
        Type = type;

        Console.WriteLine(Id + " " + Name + " " + Price + " " + Type);
        Console.WriteLine("\nO Preço é dolar é: " + PriceInDolar(DOLAR));
    }
    public double PriceInDolar(double dolar)
    {
        return Price * dolar;
    }
}

enum EProductType
{
    Product = 1,
    Service = 2
}


