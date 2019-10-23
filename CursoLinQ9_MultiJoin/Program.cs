using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinQ9_MultiJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sexo> listaSexo = new List<Sexo>
            {
                new Sexo {idSexo=1, nombreSexo="Masculino"},
                new Sexo {idSexo=2, nombreSexo="Femenino"}
            };

            List<ModalidadContrato> listaModalidad = new List<ModalidadContrato>
            {
                new ModalidadContrato{idModalidadContrato=1, nombreModalidad="CAS"},
                new ModalidadContrato{idModalidadContrato=2, nombreModalidad="TEMPORAL"}
            };

            List<Empleado> listaEmpleado = new List<Empleado>
            {
                new Empleado {nombre="Andrea", idSexo=2, idModalidadContrato=2},
                new Empleado {nombre="Jorge", idSexo=1, idModalidadContrato=1}
            };

            var consulta = from e in listaEmpleado
                           join s in listaSexo
                           on e.idSexo equals s.idSexo
                           join m in listaModalidad
                           on e.idModalidadContrato equals m.idModalidadContrato
                           select new { e.nombre, s.nombreSexo, m.nombreModalidad };

            foreach(var item in consulta)
            {
                Console.WriteLine(item.nombre + " "
                    + item.nombreSexo + " "
                    + item.nombreModalidad);
            }

            Console.Read();
        }
    }
}
