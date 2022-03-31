// See https://aka.ms/new-console-template for more information
using System.Text;

var id = Guid.NewGuid();
id.ToString();

id = new Guid("ce1c9350-d9cd-407a-af74-7163d3857f61");
Console.WriteLine(id.ToString().Substring(0, 8));

id = new Guid();
Console.WriteLine(id);

var price = 10.2;
var texto = "O preço do produto é " + price + " apenas na promoção";
Console.WriteLine(texto);

var texto2 = string.Format("O preço do produto é {0} apenas na promoção {1}", price, true);
Console.WriteLine(texto2);

var texto3 = $@"O preço do produto é {price} 
            apenas na promoção";
Console.WriteLine(texto3);

//var texto4 = "Testando";
string texto4 = "Este texto é um teste";

Console.WriteLine("\nCompareTO");
Console.WriteLine(texto4.CompareTo("Testando"));
Console.WriteLine(texto4.CompareTo("testando"));

Console.WriteLine("\nContains");
Console.WriteLine(texto4.Contains("Teste"));

// StringComparison
Console.WriteLine(texto4.Contains("teste", StringComparison.OrdinalIgnoreCase));

// string.StartsWith
Console.WriteLine("\nstring.StartsWith");
Console.WriteLine(texto4.StartsWith("Este"));
Console.WriteLine(texto4.StartsWith(" este"));
Console.WriteLine(texto4.StartsWith(" texto"));

// string.EndsWith
Console.WriteLine("\nstring.EndsWith");
Console.WriteLine(texto4.EndsWith("teste"));
Console.WriteLine(texto4.EndsWith("Teste"));
Console.WriteLine(texto4.EndsWith("xpro"));

// string.Equals
Console.WriteLine("\nstring.Equals");
Console.WriteLine(texto4.Equals("Este texto é um teste"));
Console.WriteLine(texto4.Equals("este texto é um teste"));
Console.WriteLine(texto4.Equals("Este texto é um teste", StringComparison.OrdinalIgnoreCase));

Console.WriteLine();

var numero = 33;
if (numero.Equals(50))
    Console.WriteLine("É igual");
else
    Console.WriteLine("É diferente");

Console.WriteLine(texto4.IndexOf("é"));     // mostra a posição do "vetor", neste caso vetor de caracteres
Console.WriteLine(texto4.LastIndexOf("s"));     // última posição encontrada, caso tenha mais de um index igual

// toLower & toUpper
Console.WriteLine(texto4.ToLower());
Console.WriteLine(texto4.ToUpper());

// Insert & Remove
Console.WriteLine(texto4.Insert(5, "Aqui"));
Console.WriteLine(texto4.Remove(5, 6));

//lenght quantos caracteres uma string tem
Console.WriteLine(texto4.Length);

//replace
Console.WriteLine(texto4.Replace("Este", "isto"));

// Split
Console.WriteLine(texto4);

string[] mensagem = texto4.Split(" ");

foreach (var palavra in mensagem)
{
    Console.WriteLine("Substring: {0}", palavra);
}

// string s = "You win some. You lose some.";
// string[] subs = s.Split(' ');
// foreach (var sub in subs)
// {
//     Console.WriteLine($"Substring: {sub}");
// }

var resultado = texto4.Substring(5, 5);
Console.WriteLine(resultado);

var resultado2 = texto4.Substring(5, texto4.LastIndexOf("o"));
Console.WriteLine(resultado2);

Console.WriteLine(texto4.Trim());       // limpar espaçoes do começo e do final

var texto5 = new StringBuilder();           // 
texto5.Append("Este texto é um teste");
texto5.Append("é um teste");
texto5.Append("Este texto");
texto5.Append("Este e um teste");

texto5.ToString();
Console.WriteLine(texto5);