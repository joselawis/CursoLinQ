using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinQSeccion1_Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            ejercicio1();
            ejercicio2();
            ejercicio3();
            ejercicio4();
            ejercicio5();
            ejercicio6();
            ejercicio7();

            Console.Read();
        }

        private static void ejercicio1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Hacer una consulta LinQ e imprimir los numeros menores a 5
            IEnumerable<int> consulta = from num in numbers
                                        where num < 5
                                        select num;

            Console.WriteLine("EJERCICIO 1");
            Console.Write("Numeros menores de 5: ");
            foreach (int n in consulta)
            {
                Console.Write(n);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        private static void ejercicio2()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Hacer una consulta LinQ e imprimir los números pares.
            IEnumerable<int> consulta = from num in numbers
                                        where num % 2 == 0
                                        select num;

            Console.WriteLine("EJERCICIO 2");
            Console.Write("Numeros pares: ");
            foreach (int n in consulta)
            {
                Console.Write(n);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        private static void ejercicio3()
        {
            string[] fruits = { "cherry", "apple", "blueberry" };

            // Hacer una consulta linQ y ordenar de forma ascendente y de forma descendente.
            IEnumerable<string> consulta = from fruit in fruits
                                           orderby fruit descending
                                           select fruit;

            Console.WriteLine("EJERCICIO 3");
            Console.Write("Frutas: ");
            foreach (string i in consulta)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        private static void ejercicio4()
        {
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            // Obtener el mayor score usando una consulta LinQ
            IEnumerable<int> consulta = from score in scores
                                        select score;

            Console.WriteLine("EJERCICIO 4");
            Console.Write("Mayor score: " + consulta.Max());

            Console.WriteLine();
        }

        private static void ejercicio5()
        {
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            // Obtener el  numero de elementos que cumplen con ser mayor a 20 , usando una consulta LinQ
            IEnumerable<int> consulta = from score in scores
                                        where score > 20
                                        select score;

            Console.WriteLine("EJERCICIO 5");
            Console.Write("Scores mayores a 20: ");
            foreach (int n in consulta)
            {
                Console.Write(n);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        private static void ejercicio6()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Imprimir aquellos que sean menores que 5 y multiplos de 2 , usando una consulta LinQ.
            IEnumerable<int> consulta = from num in numbers
                                        where num % 2 == 0
                                        where num < 5
                                        select num;

            Console.WriteLine("EJERCICIO 6");
            Console.Write("Numeros pares menores de 5: ");
            foreach (int n in consulta)
            {
                Console.Write(n);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        private static void ejercicio7()
        {
            List<Student> students = new List<Student> {
                new Student {First="Svetlana", Last="Omelchenko", ID=111},
                new Student {First="Claire", Last="O'Donnell", ID=112},
                new Student {First="Sven", Last="Mortensen", ID=113},
                new Student {First="Cesar", Last="Garcia", ID=114},
                new Student {First="Debra", Last="Garcia", ID=115}
            };


            // Crear una consulta LinQ e imprimir con el 
            // siguiente formato : Mi nombre es .... y mi apellido es ....... , 
            // ordenar de forma ascendente por el campos last. 

            IEnumerable<String> consulta = from student in students
                                           orderby student.Last ascending
                                           select "Mi nombre es " + student.First +
                                                   " y mi apellido es " + student.Last;

            Console.WriteLine("EJERCICIO 7");
            Console.Write("Estudiantes: ");
            foreach (string n in consulta)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
        }
    }

    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
    }
}
