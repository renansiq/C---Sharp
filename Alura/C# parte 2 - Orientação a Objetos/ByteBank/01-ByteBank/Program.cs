using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDagabriela = new ContaCorrente();
            contaDagabriela.titular = "Gabriela";
            contaDagabriela.agencia = 863;
            contaDagabriela.numero = 863452;
            contaDagabriela.saldo = 100;
            
            Console.WriteLine("Titular: " + contaDagabriela.titular);
            Console.WriteLine("Agência: " + contaDagabriela.agencia);
            Console.WriteLine("Número da Conta: " + contaDagabriela.numero);
            Console.WriteLine("Saldo: " + contaDagabriela.saldo);            

            contaDagabriela.saldo += 200;

            Console.WriteLine("Saldo: " + contaDagabriela.saldo);

            Console.ReadLine();
        }
    }
}
