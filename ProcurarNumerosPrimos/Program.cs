using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurarNumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, cont = 0;
            Console.WriteLine("Programa número primo.");
            Console.Write("Informe o número!");
                n = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i > 0; i--)
            {
                if (n % i == 0)
                {
                    cont++;
                }
            }
            if (cont == 2)
            {
                Console.WriteLine("O número " + n + " é um número primo!");
            }else
            {
                Console.WriteLine("O número " + n + " não é um número primo!");
            }
            Console.ReadKey();
        }
    }   
}
