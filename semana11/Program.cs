using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Diccionario con palabras iniciales (inglés -> español)
        Dictionary<string, string> diccionario = new Dictionary<string, string>()
        {
            {"time", "tiempo"},
            {"person", "persona"},
            {"year", "año"},
            {"day", "día"},
            {"thing", "cosa"},
            {"man", "hombre"},
            {"world", "mundo"},
            {"life", "vida"},
            {"eye", "ojo"},
            {"work", "trabajo"}
        };

        int opcion = -1;

        while (opcion != 0)
        {
            Console.WriteLine("\n==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("\nIngrese una frase: ");
                string frase = Console.ReadLine();
                string[] palabras = frase.Split(' ');

                Console.Write("Traducción: ");
                foreach (string palabra in palabras)
                {
                    string minuscula = palabra.ToLower();
                    if (diccionario.ContainsKey(minuscula))
                        Console.Write(diccionario[minuscula] + " ");
                    else
                        Console.Write(palabra + " ");
                }
                Console.WriteLine();
            }
            else if (opcion == 2)
            {
                Console.Write("Palabra en inglés: ");
                string ingles = Console.ReadLine().ToLower();

                Console.Write("Traducción al español: ");
                string espanol = Console.ReadLine().ToLower();

                if (!diccionario.ContainsKey(ingles))
                {
                    diccionario.Add(ingles, espanol);
                    Console.WriteLine("Palabra agregada correctamente.");
                }
                else
                {
                    Console.WriteLine("Esa palabra ya existe en el diccionario.");
                }
            }
            else if (opcion == 0)
            {
                Console.WriteLine("Saliendo...");
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
    }
}
