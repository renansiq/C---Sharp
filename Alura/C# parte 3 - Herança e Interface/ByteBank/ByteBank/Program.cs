using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Sistemas;

namespace ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            SistemaInterno sistemaInterno = new SistemaInterno();  

            Funcionario carlos = new Designer("546.879.157-20");
            carlos.Nome = "Carlos";
            Console.WriteLine("Nome: " + carlos.Nome);
            Console.WriteLine("Bonificação: " + carlos.GetBonificacao());
            Console.WriteLine("Salario: " + carlos.Salario);
            carlos.AumentarSalario();
            Console.WriteLine("Salário com aumento: " + carlos.Salario + Environment.NewLine);
            gerenciador.Registrar(carlos);

            Funcionario renan = new Auxiliar("397.361.178-55");
            renan.Nome = "Renan";
            Console.WriteLine("Nome: " + renan.Nome);
            Console.WriteLine("Bonificação: " + renan.GetBonificacao());
            Console.WriteLine("Salario: " + renan.Salario);
            renan.AumentarSalario();
            Console.WriteLine("Salário com aumento: " + renan.Salario + Environment.NewLine);
            gerenciador.Registrar(renan);

            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";
            Console.WriteLine("Nome: " + roberta.Nome);
            Console.WriteLine("Bonificação: " + roberta.GetBonificacao());
            Console.WriteLine("Salario: " + roberta.Salario);
            roberta.AumentarSalario();
            Console.WriteLine("Salário com aumento: " + roberta.Salario + Environment.NewLine);
            gerenciador.Registrar(roberta);

            GerenteDeConta pedro = new GerenteDeConta("123456789-11");
            pedro.Nome = "pedro";
            pedro.Senha = "abc";            
            Console.WriteLine("Nome: " + pedro.Nome + '\n' + "Bonificação: " + pedro.GetBonificacao());
            Console.WriteLine("Salario: " + pedro.Salario);
            pedro.AumentarSalario();
            Console.WriteLine("Salário com aumento: " + pedro.Salario + Environment.NewLine);
            gerenciador.Registrar(pedro);

            
            // sistemaInterno.Logar(renan, "152"); - exemplo Renan herda diretamente de Funcionário, ou seja não tem método de autenticação
            sistemaInterno.Logar(pedro, "def");
            sistemaInterno.Logar(roberta, "123");

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
            //Console.WriteLine(Funcionario.TotaldeFuncionarios);
        }
    }
}
