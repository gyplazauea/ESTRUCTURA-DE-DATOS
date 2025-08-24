using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // -----------------------------
        // 1. Generar ciudadanos ficticios
        // -----------------------------
        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        // -----------------------------
        // 2. Generar vacunados con Pfizer (75)
        // -----------------------------
        HashSet<string> pfizer = new HashSet<string>();
        for (int i = 1; i <= 75; i++)
        {
            pfizer.Add("Ciudadano " + i);
        }

        // -----------------------------
        // 3. Generar vacunados con AstraZeneca (75)
        // Algunos ciudadanos también recibieron Pfizer (ambas dosis)
        // -----------------------------
        HashSet<string> astraZeneca = new HashSet<string>();
        for (int i = 50; i <= 124; i++)  // del 50 al 75 ya recibieron Pfizer → ambas dosis
        {
            astraZeneca.Add("Ciudadano " + i);
        }

        // -----------------------------
        // 4. Ciudadanos que no se han vacunado
        // -----------------------------
        HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
        noVacunados.ExceptWith(pfizer);
        noVacunados.ExceptWith(astraZeneca);

        // -----------------------------
        // 5. Ciudadanos que han recibido ambas dosis
        // -----------------------------
        HashSet<string> ambasDosis = new HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astraZeneca);

        // -----------------------------
        // 6. Ciudadanos que solo han recibido Pfizer
        // -----------------------------
        HashSet<string> soloPfizer = new HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astraZeneca);

        // -----------------------------
        // 7. Ciudadanos que solo han recibido AstraZeneca
        // -----------------------------
        HashSet<string> soloAstra = new HashSet<string>(astraZeneca);
        soloAstra.ExceptWith(pfizer);

        // -----------------------------
        // 8. Mostrar resultados
        // -----------------------------
        Console.WriteLine("=== Ciudadanos que no se han vacunado ===");
        Console.WriteLine(string.Join(", ", noVacunados));
        Console.WriteLine("\n=== Ciudadanos que han recibido ambas dosis ===");
        Console.WriteLine(string.Join(", ", ambasDosis));
        Console.WriteLine("\n=== Ciudadanos que solo han recibido Pfizer ===");
        Console.WriteLine(string.Join(", ", soloPfizer));
        Console.WriteLine("\n=== Ciudadanos que solo han recibido AstraZeneca ===");
        Console.WriteLine(string.Join(", ", soloAstra));
    }
}
