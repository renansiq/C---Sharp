﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaverisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto  3 Criando variáveis ponto flutuante");

            double salario;
            salario = 1220.70;

            Console.WriteLine(salario);

            //double idade;
            //idade = 15.0 / 2;

            //Console.WriteLine(idade);

            //idade = 5 / 3;
            //Console.WriteLine(idade);
            //...

            double idade;
            idade = 15.0 / 2;

            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);

            Console.WriteLine("A execução acabou. Tecle entender para sair...");
            Console.ReadLine();
        }
    }    
}


