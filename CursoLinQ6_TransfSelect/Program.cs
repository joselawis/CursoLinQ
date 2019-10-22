using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinQ6_TransfSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>
            {
                new Empleado {nombreCompleto="Tony Stark", sueldo=10200},
                new Empleado {nombreCompleto="Thor Odinsson", sueldo=1200},
                new Empleado {nombreCompleto="Bruce Banner", sueldo=2200},
                new Empleado {nombreCompleto="Peter Parker", sueldo=600}
            };

            // nombrepersona gana sueldo
            IEnumerable<String> consulta = from empleado in empleados
                                             select empleado.nombreCompleto + " gana " + empleado.sueldo;

            foreach(String i in consulta)
            {
                Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
