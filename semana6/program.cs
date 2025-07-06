using System;

namespace Semana6
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Elige un ejercicio para ejecutar (1-2) o 0 para salir:");
                Console.WriteLine("1 - Ejercicio 1");
                Console.WriteLine("2 - Ejercicio 2");
                Console.WriteLine("0 - Salir");
                Console.Write("Opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Ejercicio1.Ejecutar();
                        break;
                    case "2":
                        Ejercicio2.Ejecutar();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
