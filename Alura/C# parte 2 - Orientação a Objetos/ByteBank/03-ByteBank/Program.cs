using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela Costa";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            /* cada objeto tem seu endereço, são diferentes (false)*/
            Console.WriteLine("Igualdade de tipo de referência " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            /*valores são iguais = true*/
            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));

            /*a partor da daqui a variável contaDagabriela também aponta para o objeto da contaDaGabrielaCosta*/
            contaDaGabriela = contaDaGabrielaCosta;

            /* por conta da instrução anterior agora é true*/
            Console.WriteLine("Igualdade de tipo de referência " + (contaDaGabriela == contaDaGabrielaCosta));

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);   /* imprime 300*/
            Console.WriteLine(contaDaGabrielaCosta.saldo); /* também imprime 300 porque amabas variáveis apontam pro mesmo objeto */

            if (contaDaGabriela.saldo >= 100)
            {
                contaDaGabriela.saldo -= 100;
            }

            Console.ReadLine();

        }
    }
}
