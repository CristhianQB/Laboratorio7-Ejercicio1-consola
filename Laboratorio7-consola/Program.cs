using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de n: ");
            int n = int.Parse(Console.ReadLine());

            
            float suma2 = 0;
            for ( float i = 1 ; i <= n; i++)
            {
                float suma1 = (16 - i) / (3 * i); 
                Console.WriteLine("resutado : " + suma1);
                suma2 = suma2 + suma1;
            }

            Console.WriteLine(suma2);
            Console.ReadKey();
        }
    }
}
