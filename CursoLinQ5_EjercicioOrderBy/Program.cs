using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinQ5_EjercicioOrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>
            {
                new Empleado {nombre="Pepito", apellido="Perez", sueldo=1200},
                new Empleado {nombre="Juanito", apellido="Jimenez", sueldo=1800},
                new Empleado {nombre="Adela", apellido="Anduril", sueldo=2200},
                new Empleado {nombre="Peter", apellido="Parker", sueldo=600}
            };

            // Ganan mas de 1500 ordenados por apellido

            IEnumerable<Empleado> consulta = from empleado in empleados
                           where empleado.sueldo > 1500
                           orderby empleado.apellido ascending
                           select empleado;

            foreach(Empleado e in consulta)
            {
                Console.WriteLine(e.apellido + ", " + e.nombre + " Sueldo: " + e.sueldo);
            }

            Console.Read();
        }
    }
}
