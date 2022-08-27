namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Estudiantes;
            double[] Notas = null;
            int Cant_Nombres;
            int Cant_notas;
            double promedio_notas = 0;
            double suma = 0;

            Console.Write("Cuántos estudiantes hay en clase?: ");
            Cant_Nombres = int.Parse(Console.ReadLine());
            Estudiantes = new string[Cant_Nombres];
            Notas = new double[Cant_Nombres];

            for (int i = 0; i < Cant_Nombres; i++)
            {
                Console.Write("Nombre estudiante " + (i + 1) + ": ");
                Estudiantes[i] = Console.ReadLine();

                Console.Write("Cuántas notas tiene " + Estudiantes[i] + " ?:");
                Cant_notas = int.Parse(Console.ReadLine());
                double nota = 0;
                suma = 0;

                for (int a = 0; a < Cant_notas; a++)
                {
                    Console.Write("Nota " + (a + 1) + ": ");
                    nota = Convert.ToDouble(Console.ReadLine());
                    suma += nota;
                    
                }
                promedio_notas = suma / Cant_notas;
                Notas[i] = promedio_notas;
            }

            Console.WriteLine("Lista de Estudiantes:");

            for (int i = 0; i < Cant_Nombres; i++)
            {
                Console.WriteLine("La nota Promedio del Estudiante " + Estudiantes[i] + " Es: " + Notas[i] );
                
            }

            Console.Read();
        }
    }
}