using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boos.Unicórnio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boss Unicórnio");
            Console.ReadLine();
            Console.Clear();

            string nm = "";

            Console.Write("Digite seu nome completo: ");
            nm = Console.ReadLine();


            Console.WriteLine("Todo o nome: {0}", nm);
            Console.WriteLine("Primeiro Caractere: {0}", nm[0]);
            Console.WriteLine("Último Caractere: {0}", nm[nm.Length - 1]);
            Console.WriteLine("Do Primeiro até o Terceiro: {0}", nm.Substring(0, 3));
            Console.WriteLine("Quarto Caractere: {0}", nm[3]);
            Console.WriteLine("Todos menos o Primeiro: {0}", nm.Substring(1));
            Console.WriteLine("Os Dois Últimos: {0}", nm.Substring(nm.Length - 2));

            Console.ReadLine();
            Console.Clear();
        }
    }
}
