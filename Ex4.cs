using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Ex4
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Insira o primeiro valor");
            a = Convert.ToDouble(Console.ReadLine());  
            
            Console.WriteLine("Insira o segundo valor");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o terceiro valor");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Média: " + (a+b+c)/3);

            Console.ReadKey();
        }
    }
}
