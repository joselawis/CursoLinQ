using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinQ14_lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> listaEmpleado = new List<Empleado>
            {
                new Empleado {nombre="Peter Parker", sexo="Masculino", sueldo=600},
                new Empleado {nombre="Tony Stark", sexo="Masculino", sueldo=60000},
                new Empleado {nombre="Natasha Romanov", sexo="Femenino", sueldo=5600},
                new Empleado {nombre="MJ Watson", sexo="Femenino", sueldo=700},
                new Empleado {nombre="Steve Rogers", sexo="Masculino", sueldo=1800}
            };
            /* cuanto ganara en el año cada empleado, sabiendo que en la propiedad
             sueldo se encuentra lo que gana mensualmente. Solo de las personas que son hombres
             y que ganan mas de 700 dolares. ordenar descendientemente por el campo sueldo
            */
            var consulta = listaEmpleado.Where(p => p.sueldo > 700 && "Masculino".Equals(p.sexo))
                                        .OrderByDescending(p => p.sueldo)
                                        .Select(p => { return p.nombre + " ganara anualmente " + p.sueldo * 12; });

            foreach(var item in consulta)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
