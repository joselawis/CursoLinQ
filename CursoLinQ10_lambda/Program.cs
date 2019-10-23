using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinQ10_lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customers> listaCustomers = new List<Customers>
            {
                new Customers {nombre="Ricardo", apellido="Pelaes", ciudad="Madriz"},
                new Customers {nombre="Lucia", apellido="Trompeta del sol", ciudad="Valencia"},
                new Customers {nombre="Fran", apellido="Ibañez", ciudad="Bilbao"}
            };

            var consulta = listaCustomers.Select(p => p.nombre);

            foreach(var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
