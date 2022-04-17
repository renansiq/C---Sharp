using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);      
            Console.WriteLine(Environment.NewLine);
            ContaCorrente conta = new ContaCorrente(867, 86712540);
            Cliente cliente = new Cliente();
            cliente.Nome = "Genérico";
            cliente.CPF = "12345678900";
            cliente.Profissao = "programador";
            conta.Titular = cliente;
            
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine(Environment.NewLine);

            ContaCorrente contaDoRenan = new ContaCorrente(867, 86712541);
            Cliente clienteRenan = new Cliente();
            clienteRenan.Nome = "Renan Siqueira";
            clienteRenan.CPF = "39736117855";
            clienteRenan.Profissao = "Programador C#";
            contaDoRenan.Titular = clienteRenan;

            Console.WriteLine(contaDoRenan.Titular.Nome);
            Console.WriteLine(contaDoRenan.Agencia);
            Console.WriteLine(contaDoRenan.Numero);           
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);            

            Console.ReadLine();
        }
    }
}
