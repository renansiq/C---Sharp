using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Testes_OO_Renan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício com Classes");

            Curso ads = new Curso(1, "Análise e Desenvolvimento de Sistemas", (periodo.noite).ToString());
            ads.cursoProfessor.Rp = 100;
            ads.cursoProfessor.NomeProfessor = "Paulo Silva";

            //Console.WriteLine("Id: " + ads.idCurso + "\nCurso: " + ads.nomeCurso + "\nPeríodo: " + ads.periodo);
            //Console.WriteLine("Id: {0} \nCurso: {1} \nPeriodo: {2}", ads.idCurso, ads.nomeCurso, ads.periodo);
            Console.WriteLine($"Id: {ads.IdCurso} \nCurso: {ads.NomeCurso} \nPeríodo: {ads.Periodo} \nProfessor: {ads.cursoProfessor.NomeProfessor}");

            Aluno renan = new Aluno(200, "Renan Augusto Siqueira", 31);
            renan.enderecoAluno = new Endereco("Rua Doutor Gabriel Prestes", "Casa", "570", "Mogi Moderno", "Mogi das Cruzes", "08717670");

            Console.WriteLine($"{Environment.NewLine}Aluno:");
            Console.WriteLine($"RA: {renan.Ra} \nNome: {renan.NomeAluno} \nIdade: {renan.Idade} \nLogradouro: {renan.enderecoAluno.Logradouro} \nComplemento: {renan.enderecoAluno.Complemento} \nNúmero: {renan.enderecoAluno.Numero} \nBairo: {renan.enderecoAluno.Bairro} \nCidade: {renan.enderecoAluno.Cidade} \nCEP: {renan.enderecoAluno.Cep}");

            ads.cursoProfessor.enderecoProfessor = new Endereco("Rua Exemplo", "Apto", "100", "Centro", "Mogi das Cruzes", "000123456");

            Console.WriteLine($"{Environment.NewLine}Professor:");
            Console.WriteLine($"Logradouro: {ads.cursoProfessor.enderecoProfessor.Logradouro} \nComplemento: {ads.cursoProfessor.enderecoProfessor.Complemento} \nNúmero: {ads.cursoProfessor.enderecoProfessor.Numero} \nBairoo: {ads.cursoProfessor.enderecoProfessor.Bairro} \nCidade: {ads.cursoProfessor.enderecoProfessor.Cidade} \nCEP: {ads.cursoProfessor.enderecoProfessor.Cep}");
            
            Aluno marcelo = new Aluno(201, "Marcelo", 28);
            Console.WriteLine("Nome: {0}, Cidade: {1}", marcelo.NomeAluno, marcelo.enderecoAluno.Cidade);

            marcelo.MostrarAluno();        

            Console.ReadLine();      
        }
    }
}
