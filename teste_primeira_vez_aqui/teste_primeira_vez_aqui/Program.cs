using System;

namespace teste_primeira_vez_aqui
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Digite o seu nome ácento: ");
            var nometeste = Console.ReadLine();
            Console.WriteLine($"Nome digitado abaixo:\n{nometeste}");


            DateTime now = DateTime.Now; //variável "now" mostrará a data e horas atuais
            int dayOfYear = now.DayOfYear; //variável mostra quantos anos passaram
            Console.WriteLine($"teste = {now}"); //mostra a data dd/mm/aa e horas hh:mm:ss
            Console.WriteLine($"ano = {dayOfYear}");
            int day = now.DayOfYear;
            //int day = DateTime.Now.DayOfYear;
            Console.WriteLine($"teste novo {day}");


        }
    }
}
