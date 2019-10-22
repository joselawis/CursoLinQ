using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinQ3_Customer
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


            // Aquellos que viven en Valencia
            IEnumerable<Customers> consultaValencia = from c in listaCustomers
                                   where "Valencia".Equals(c.ciudad)
                                   select c;

            foreach(Customers c in consultaValencia)
            {
                Console.WriteLine("Nombre : " + c.nombre + " " + c.apellido);
            }

            Console.Read();
        }
    }
}
