using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Ex3
    {
        static void Main(string[] args)
        {
            int ano;
            int anoAtual = 2022;

            Console.WriteLine("Insira o ano de nascimento");
            ano = Convert.ToInt32(Console.ReadLine());  

            Console.WriteLine("Sua idade é: " + (anoAtual-ano));

            Console.ReadKey();
        }
    }
}
