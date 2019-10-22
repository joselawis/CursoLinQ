using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinQ1_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            // Origen de datos
            int[] scores = new int[] { 97, 92, 81, 60 };

            // Consulta
            IEnumerable<int> consulta = from score in scores
                                        where score > 80
                                        select score;
            
            // Definicion de la consulta
            foreach(int item in consulta)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
