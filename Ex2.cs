using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Ex2
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Insira um valor");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira outro valor");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Soma dos valores: " + (a+b));
            Console.WriteLine("Subtração dos valores: " + (a-b));
            Console.WriteLine("Multiplicação dos valores: " + (a * b));
            Console.WriteLine("Divisão dos valores: " + (a / b));

            Console.ReadKey();
        }
    }
}
