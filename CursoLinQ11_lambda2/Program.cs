using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinQ11_lambda2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> listaAlumnos = new List<Alumno>
            {
                new Alumno{idAlumno=1, cursoFavorito="Matematicas"},
                new Alumno{idAlumno=2, cursoFavorito="Tecnologia"},
                new Alumno{idAlumno=3, cursoFavorito="Historia"},
                new Alumno{idAlumno=4, cursoFavorito="Filosofia"},
                new Alumno{idAlumno=5, cursoFavorito="Fisica"}
            };

            // Su curso favorito es Matematicas
            var consulta = listaAlumnos.Select(a => { return "Su curso favorito es " + a.cursoFavorito; });

            foreach(var item in consulta)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
