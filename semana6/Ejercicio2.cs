using System;

namespace Semana6
{
    class Nodo2
    {
        public int Dato;
        public Nodo2 Siguiente;

        public Nodo2(int valor)
        {
            Dato = valor;
            Siguiente = null;
        }
    }

    class Lista2
    {
        private Nodo2 cabeza;

        public void Agregar(int valor)
        {
            Nodo2 nuevo = new Nodo2(valor);
            if (cabeza == null)
                cabeza = nuevo;
            else
            {
                Nodo2 actual = cabeza;
                while (actual.Siguiente != null)
                    actual = actual.Siguiente;
                actual.Siguiente = nuevo;
            }
        }

        public void Invertir()
        {
            Nodo2 anterior = null;
            Nodo2 actual = cabeza;
            Nodo2 siguiente = null;

            while (actual != null)
            {
                siguiente = actual.Siguiente;
                actual.Siguiente = anterior;
                anterior = actual;
                actual = siguiente;
            }

            cabeza = anterior;
        }

        public void Mostrar()
        {
            Nodo2 actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }
    }

    public class Ejercicio2
    {
        public static void Ejecutar()
        {
            Lista2 lista = new Lista2();
            lista.Agregar(1);
            lista.Agregar(2);
            lista.Agregar(3);
            lista.Agregar(4);

            Console.WriteLine("Lista original:");
            lista.Mostrar();

            lista.Invertir();

            Console.WriteLine("Lista invertida:");
            lista.Mostrar();

            Console.ReadKey();
        }
    }
}
