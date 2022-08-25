using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasse_Heranca
{
    internal class Pessoa
    {
        String Nome;
        DateTime DataNasc;
        String Cpf;

        public void setNome()
        {
            Console.Write("Informe o nome: ");
            this.Nome = Console.ReadLine();

        }
        public void getNome()
        {
            Console.Write("Nome: " + this.Nome);
        }
        public void setDataNasc()
        {
            Console.Write("Informe sua data de nascimento (ddd/mmm/aaa): ");
            this.DataNasc = DateTime.Parse(Console.ReadLine());
        }

        public void getDataNasc()
        {
            Console.Write("Data de Nascimento: " + this.DataNasc.ToLongDateString());
        }

        public void setCpf()
        {
            Console.Write("Informe seu CPF (000.000.000. - 00): ");
            this.Cpf = Console.ReadLine();
        }

        public void getCpf()
        {
            Console.Write("CPF: " + this.Cpf);
        }
        public override string ToString()
        {
            return "\nNome: " + Nome + "\nData de Nascimento: " + DataNasc + "\nCPF: " + Cpf;
        }
        public void CadastrarPessoa()
        {
            setNome();
            setDataNasc();
            setCpf();
        }
    }
}
