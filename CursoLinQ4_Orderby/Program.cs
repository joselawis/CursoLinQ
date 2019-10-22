using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinQ4_Orderby
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[] { 10, 7, 8, 3, 5, 4, 9, 5, 2, 4, 0, 1 };

            IEnumerable<int> consultaNotas = from nota in notas
                                orderby nota ascending
                                select nota;

            foreach(int n in consultaNotas)
            {
                Console.WriteLine(n);
            }

            Console.Read();
        }
    }
}
