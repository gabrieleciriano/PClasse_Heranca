using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasse_Heranca
{
    internal class Funcionarios : Pessoa
    {
        String PIS;
        float Salario;
        String Setor;

        public void setPIS()
        {
            Console.Write("Informe o número do seu PIS: ");
            this.PIS = Console.ReadLine();
        }
        public void setSalario()
        {
            Console.Write("Informe seu salário atual: ");
            this.Salario = float.Parse(Console.ReadLine());
        }
        public void setSetor()
        {
            Console.Write("Informe o nome do setor em que trabalha: ");
            this.Setor = Console.ReadLine();
        }
        public void getPIS()
        {
            Console.Write("PIS: " + this.PIS);
        }
        public void getSalario()
        {
            Console.Write("Salário: " + this.Salario);
        }
        public void getSetor()
        {
            Console.Write("Setor: " + this.Setor);
        }
        public override string ToString()
        {

            return base.ToString() + "\nNúmero do PIS:  " + PIS + "\nSalário Atual:  " + Salario + "\nSetor onde trabalha: " + Setor;

        }
        public void CadastrarFuncionario()
        {
            setNome();
            setDataNasc();
            setCpf();
            setPIS();
            setSalario();
            setSetor();

        }
    }
}
