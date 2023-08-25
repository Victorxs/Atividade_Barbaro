using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Águia
{
    internal class Program
    {
        static void Main(string[] args)

            // Exercício 1

        {
            int nm_tb = 0;


            Console.Write("Digite o Número que deseja fazer a tabuada: ");
            nm_tb = int.Parse(Console.ReadLine());


            Console.WriteLine("Tabuada do {0}", nm_tb);
            Console.WriteLine("1 x {0} = {1}", nm_tb, nm_tb * 1);
            Console.WriteLine("2 x {0} = {1}", nm_tb, nm_tb * 2);
            Console.WriteLine("3 x {0} = {1}", nm_tb, nm_tb * 3);
            Console.WriteLine("4 x {0} = {1}", nm_tb, nm_tb * 4);
            Console.WriteLine("5 x {0} = {1}", nm_tb, nm_tb * 5);
            Console.WriteLine("6 x {0} = {1}", nm_tb, nm_tb * 6);
            Console.WriteLine("7 x {0} = {1}", nm_tb, nm_tb * 7);
            Console.WriteLine("8 x {0} = {1}", nm_tb, nm_tb * 8);
            Console.WriteLine("9 x {0} = {1}", nm_tb, nm_tb * 9);
            Console.WriteLine("10 x {0} = {1}", nm_tb, nm_tb * 10);
            Console.ReadLine();
            Console.Clear();


            //Exercício 2

            double ld_0 = 0;

            Console.WriteLine("Insira sua quantidade de laudas:");
            ld_0 = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Sua quantidade de laudas original é {0}", ld_0);
            Console.WriteLine("O preço total é {0:c}", ld_0 * 50);
            Console.WriteLine("A quantidade de parcelas iguais de 3 partes será {0:c}", (ld_0 * 50) / 3);

            Console.ReadLine();
            Console.Clear();



            //Exercício 3

            string nm = "";
            string msg = "Bem Vindo!!";

            Console.Write("Digite seu nome: ");
            nm = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Olá {0}\n{1}", nm, msg );
            Console.WriteLine("Tecle ENTER para finalizar");
            Console.ReadLine();
            Console.Clear();



        }
    }
}
