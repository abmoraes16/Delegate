using System;

namespace ExemploDelegate1
{
    class Program
    {
        delegate void Cortador(string queijo);
        static void Main(string[] args)
        {
            /* Data("Olá");
            Console.WriteLine(DataCompleta("Amanda")); */
            

            //usando delegate
            Cortador vera = new Cortador(Data);
            vera("Olá, eu sou um delegate");        

            Cortador filha = new Cortador(DataCompleta);
            filha("Amanda");
        }

        static void Data(string texto){
            Console.WriteLine(texto+" Hoje é "+DateTime.Now.ToShortDateString());
        }

        static void DataCompleta(string nome){
            Console.WriteLine("Olá "+nome+". Hoje é "+DateTime.Now.ToLongDateString());
        }
    }
}
