// See https://aka.ms/new-console-template for more information
var array = new int[3] { 1, 2, 3 };

//for forçado para ir além do indíce do vetor para causar uma Exception

/*
Try - Catch -> ele executa o bloco de código do Try, se ocorrer algum erro, ele entra no catch e trata a Excessão.
Podemos ter mais de 1 catch para tratar exceptions expecíficas e a última pode ser a genérica.
*/
try
{
    /*  for (int index = 0; index < 5; index++)
     {
         // System.IndexOutOfRangeException
         Console.WriteLine(array[index]);
     } */

    //Cadastrar("");
    MinhaException();
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Não encontrei o índice na lista");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);          // armazena a mensagem da exception "O texto não pode ser nulo ou vazio"
    Console.WriteLine("Falha ao cadastrar texto");
    throw;
}
catch (MinhaException ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);          // armazena a mensagem da exception "O texto não pode ser nulo ou vazio"
    Console.WriteLine(ex.QuandoAconteceu);
    Console.WriteLine("Exceção customizada!");
    throw;
}
catch (Exception ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);          // armazena a mensagem da exception "O texto não pode ser nulo ou vazio"
    Console.WriteLine("Ops, algo deu errado");
    throw;
}
finally
{
    Console.WriteLine("Chegou ao fim");
}

static void Cadastrar(string texto)
{
    if (string.IsNullOrEmpty(texto))
        //throw new Exception ("O texto não pode ser nulo ou vazio");
        throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
}

static void MinhaException()
{
    throw new MinhaException(DateTime.Now);
}

public class MinhaException : Exception
{
    public MinhaException(DateTime date)
    {
        QuandoAconteceu = date;
    }

    public DateTime QuandoAconteceu { get; set; }
};




