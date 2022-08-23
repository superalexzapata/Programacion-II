using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_estudiantes // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string[] Estudiantes;
            int[] Notas = null;
            int Cant_Nombres;
            int Cant_notas;
            double promedio_notas = 0;
            int suma =0;

            Console.Write("Cuántos estudiantes hay en clase?: ");
            Cant_Nombres = int.Parse(Console.ReadLine());
            Estudiantes = new string[Cant_Nombres];
            
            for (int i = 0; i < Cant_Nombres; i++)
            {
                Console.Write("Nombre estudiante " + (i + 1) + ": ");
                Estudiantes[i] = Console.ReadLine();

                Console.Write("Cuántas notas tiene " + Estudiantes[i] + " ?:");
                Cant_notas = int.Parse(Console.ReadLine());
                Notas = new int[Cant_notas];
                
                for (int a = 0; a < Cant_notas; a++)
                {
                    Console.Write("Nota " + (a + 1) + ": ");
                    Notas[a] = Convert.ToInt32(Console.ReadLine());
                    suma += Notas[a]; 
                    promedio_notas = suma / Cant_notas;
                }

            }

            Console.WriteLine("Lista de Estudiantes:");

            for (int i = 0; i < Cant_Nombres; i++)
            {
                Console.WriteLine("{0}. {1}",i+1 + Estudiantes[i]);
                /*for (int j = 0; j < promedio_notas; j++)
                {
                    Console.WriteLine("{0}. {1}", i + 1 + Notas[j]);
                }
                Console.WriteLine("");*/
            }
            
            Console.Read();
        }
    }
}
