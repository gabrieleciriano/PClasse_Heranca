using System;

namespace PClasse_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criei apenas um objeto para cada classe já que o exercicio deixava essa
            //opção livre...

            Pessoa pessoa = new Pessoa();
            Aluno aluno = new Aluno();
            Funcionarios funcionario = new Funcionarios();


            pessoa.CadastrarPessoa();
            Console.WriteLine("\nDADOS PESSOAIS: ");
            Console.WriteLine(pessoa.ToString());        
            Console.ReadKey();
            Console.WriteLine("\n");

            aluno.CadastrarAluno();
            Console.WriteLine("\nDADOS DO ALUNO: ");
            Console.WriteLine(aluno.ToString());
            Console.ReadKey();
            Console.WriteLine("\n");

            funcionario.CadastrarFuncionario();
            Console.WriteLine("\nDADOS DO FUNCIONÁRIO: ");
            Console.WriteLine(funcionario.ToString());
            Console.ReadKey();
            Console.WriteLine("\n");










        }
    }
    }
