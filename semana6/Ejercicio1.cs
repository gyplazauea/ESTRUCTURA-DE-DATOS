using System;

namespace Semana6
{
    class Nodo1
    {
        public int Dato;
        public Nodo1 Siguiente;

        public Nodo1(int valor)
        {
            Dato = valor;
            Siguiente = null;
        }
    }

    class Lista1
    {
        private Nodo1 cabeza;

        public void Agregar(int valor)
        {
            Nodo1 nuevo = new Nodo1(valor);
            if (cabeza == null)
                cabeza = nuevo;
            else
            {
                Nodo1 actual = cabeza;
                while (actual.Siguiente != null)
                    actual = actual.Siguiente;
                actual.Siguiente = nuevo;
            }
        }

        public int Contar()
        {
            int total = 0;
            Nodo1 actual = cabeza;
            while (actual != null)
            {
                total++;
                actual = actual.Siguiente;
            }
            return total;
        }

        public void Mostrar()
        {
            Nodo1 actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }
    }

    public class Ejercicio1
    {
        public static void Ejecutar()
        {
            Lista1 lista = new Lista1();
            lista.Agregar(10);
            lista.Agregar(20);
            lista.Agregar(30);
            lista.Agregar(40);

            Console.WriteLine("Lista:");
            lista.Mostrar();

            Console.WriteLine($"Cantidad de elementos: {lista.Contar()}");
            Console.ReadKey();
        }
    }
}
