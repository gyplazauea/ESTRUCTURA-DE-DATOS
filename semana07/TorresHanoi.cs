using System;
using System.Collections.Generic;

namespace Programs
{
    public class Torre
    {
        public Stack<int> Discos { get; set; }
        public string Nombre { get; set; }

        public Torre(string nombre)
        {
            Nombre = nombre;
            Discos = new Stack<int>();
        }

        public void MoverDiscoA(Torre destino)
        {
            int disco = Discos.Pop();
            destino.Discos.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {Nombre} a {destino.Nombre}");
        }
    }

    public class TorresHanoi
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese el número de discos: ");
            int n = int.Parse(Console.ReadLine());

            Torre torreA = new Torre("Torre A");
            Torre torreB = new Torre("Torre B");
            Torre torreC = new Torre("Torre C");

            for (int i = n; i >= 1; i--)
            {
                torreA.Discos.Push(i);
            }

            Console.WriteLine("Pasos para resolver las Torres de Hanoi:");
            Resolver(n, torreA, torreB, torreC);
        }

        private static void Resolver(int n, Torre origen, Torre auxiliar, Torre destino)
        {
            if (n == 1)
            {
                origen.MoverDiscoA(destino);
                return;
            }

            Resolver(n - 1, origen, destino, auxiliar);
            origen.MoverDiscoA(destino);
            Resolver(n - 1, auxiliar, origen, destino);
        }
    }
}
