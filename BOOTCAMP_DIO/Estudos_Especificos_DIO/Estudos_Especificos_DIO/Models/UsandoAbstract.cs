using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos_Especificos_DIO.Models
{
    public abstract class UsandoAbstract //classe abstrata não pode ser instanciada, apenas herdada
    {
        protected decimal saldo; //protegido contra alterações extenar a menos que seja classe filha

        //método abstrato
        public abstract void Creditar(decimal valor); //não tem corpo igual interface do java

        public void ExibirSaldo()
        {
            Console.WriteLine("Saldo a seguir: "+saldo);

        }
    }

    public class Corrente : UsandoAbstract
    {
        public override void Creditar(decimal valor) //obrigatório por causa da classe abstrata
        {
            saldo += valor;
        }
    }






    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
        }
    }

    public class Aluno : Pessoa
    {
        public double Nota { get; set; }
        public Aluno(string nome, int i) : base(nome, i)
        {
            
        }
    }



    //não precisa colocar : Object, pois é padrão
    public class Computador : Object //object é a classe mãe no .net
    {
        public override string ToString()
        {
            return "Método toString sobrescrito";
        }
    }



    public interface MyInterface
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2);

    }


}
