using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinQ2_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 10, 11, 12, 13 };


            var consultaPares = from numero in numeros
                           where numero % 2 == 0
                           select numero;

            Console.WriteLine("Cantidad pares: " + consultaPares.Count());
            Console.WriteLine("Numero mas alto: " + consultaPares.Max());
            Console.WriteLine("Numero promedio: " + consultaPares.Average());
            Console.WriteLine("Numero mas bajo: " + consultaPares.Min());
            Console.WriteLine("Primer elemento: " + consultaPares.First());
            Console.WriteLine("Numeros pares");
            foreach(int n in consultaPares)
            {
                Console.WriteLine(n);
            }

            Console.Read();

        }
    }
}
