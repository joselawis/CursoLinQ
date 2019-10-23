using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinQ7_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ModalidadContrato> listaModalidad = new List<ModalidadContrato>
            {
                new ModalidadContrato {idModalidad=1, nombreModalidad="CAS"},
                new ModalidadContrato {idModalidad=2, nombreModalidad="Temporal"}
            };

            List<Empleado> listaEmpleado = new List<Empleado>
            {
                new Empleado {idEmpleado=1, nombre="Pedro", idModalidad=1},
                new Empleado {idEmpleado=2, nombre="Jorge", idModalidad=2},
                new Empleado {idEmpleado=3, nombre="Erazmo", idModalidad=1},
                new Empleado {idEmpleado=4, nombre="Julio", idModalidad=3}
            };

            // Empleado: nombreCompleto es nombeModalidad

            var consulta = from modalidad in listaModalidad
                                           join empleado in listaEmpleado
                                           on modalidad.idModalidad equals empleado.idModalidad
                                           select new { nombreEmpleado = empleado.nombre, modalidad.nombreModalidad };

            foreach(var item in consulta)
            {
                Console.WriteLine(item.nombreEmpleado + " es " + item.nombreModalidad);
            }

            Console.Read();
        }
    }
}
