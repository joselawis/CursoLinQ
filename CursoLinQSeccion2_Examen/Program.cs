using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinQSeccion2_Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            ejercicio1();
            ejercicio2();
            ejercicio3();

            Console.Read();
        }

        private static void ejercicio1()
        {
            // Imprimir el siguiente mensaje : 
            //El curso ... (nombre del curso ) es enseñado por ... (nombre del profesor)
            List<Curso> listaCurso = new List<Curso>
            {
                new Curso {idCurso=1, nombreCurso="1º Bachillerato"},
                new Curso {idCurso=2, nombreCurso="2º Bachillerato"}
            };

            List<Profesor> listaProfesores = new List<Profesor>
            {
                new Profesor {idProfesor=1, nombre="Juanito Pelaez", edad=37, idCurso=1},
                new Profesor {idProfesor=2, nombre="Pepa Pig", edad=40, idCurso=1},
                new Profesor {idProfesor=3, nombre="Alberto Chicote", edad=27, idCurso=1},
                new Profesor {idProfesor=4, nombre="Bego Morillas", edad=30, idCurso=1},
                new Profesor {idProfesor=5, nombre="Elver Galarga", edad=32, idCurso=2},
                new Profesor {idProfesor=6, nombre="Raul Alvarez", edad=47, idCurso=2},
                new Profesor {idProfesor=7, nombre="Turin Turambar", edad=57, idCurso=2},
                new Profesor {idProfesor=8, nombre="Bilbo Bolsón", edad=33, idCurso=2},
            };

            var consulta = from prof in listaProfesores
                           join curso in listaCurso
                           on prof.idCurso equals curso.idCurso
                           select "El curso " + curso.nombreCurso + " es enseñado por " + prof.nombre;

            Console.WriteLine("EJERCICIO 1");
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        private static void ejercicio2()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Hacer una consulta usando expresiones Lamdla e imprimir los números pares.

            var consulta = numbers.Where(p => p % 2 == 0);

            Console.WriteLine("EJERCICIO 2: numeros pares");
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        private static void ejercicio3()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //Hacer una consulta usando expresiones Lamdla e imprimir los numeros mayores a  5

            var consulta = numbers.Where(p => p > 5);

            Console.WriteLine("EJERCICIO 3: numeros mayores a 5");
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }

    

    public class Curso
    {
        public int idCurso { get; set; }
        public string nombreCurso { get; set; }
    }
    public class Profesor
    {
        public int idProfesor { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public int idCurso { get; set; }
    }
}
