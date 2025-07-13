using System;
using Programs;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Verificar fórmula balanceada");
        Console.WriteLine("2. Resolver Torres de Hanoi");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                BalanceoParentesis.Ejecutar();
                break;
            case "2":
                TorresHanoi.Ejecutar();
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}

