using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasse_Heranca
{
    internal class Aluno : Pessoa
    {
        String RegistroAluno;
        DateTime DataMatricula;

        public void setRegistroAluno()
        {
            Console.Write("Informe seu RA: ");
            this.RegistroAluno = Console.ReadLine();
        }
        public void getRegistroAluno()
        {
            Console.Write("RA: " + this.RegistroAluno);
        }
        public void setDataMatricula()
        {
            Console.Write("Informe a data de sua matrícula escolar (ddd/mmm/aaa):  ");
            this.DataMatricula = DateTime.Parse(Console.ReadLine());
        }
        public void getDataMatricula()
        {
            Console.Write("Data de Matrícula: " + this.DataMatricula.ToLongDateString());
        }

        public override string ToString()
        {

            return base.ToString() + "\nRA do aluno: " + RegistroAluno + "\nData de Matrícula: " + DataMatricula;

        }
        public void CadastrarAluno()
        {
            setNome();
            setDataNasc();
            setCpf();
            setRegistroAluno();
            setDataMatricula();

        }
    }

}
