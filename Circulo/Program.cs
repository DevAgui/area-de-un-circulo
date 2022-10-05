using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Circulo
{
    internal class Program
    {
        static void Main(string[] args){

            Console.WriteLine("Éste programa te dice el área de un círculo");
            
            Console.WriteLine("Introduce el primer número");
            double radio = int.Parse(Console.ReadLine());

            const double PI = 3.14;

            double resultado = PI * Math.Pow(radio, 2);

            Console.WriteLine("El área del círculo de radio {0} es de: {1}", radio, resultado);


        }
    }
}
