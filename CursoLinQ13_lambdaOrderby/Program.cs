using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinQ13_lambdaOrderby
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> listaEmpleado = new List<Empleado>
            {
                new Empleado {idEmpleado=1, nombre="Pedro", idModalidad=1},
                new Empleado {idEmpleado=2, nombre="Jorge", idModalidad=2},
                new Empleado {idEmpleado=3, nombre="Erazmo", idModalidad=1},
                new Empleado {idEmpleado=4, nombre="Julio", idModalidad=3}
            };

            var consulta = listaEmpleado.OrderBy(p => p.nombre)
                                        .Select(p => { return p.nombre + " tiene el id de modalidad " + p.idModalidad; });

            foreach(var item in consulta)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
