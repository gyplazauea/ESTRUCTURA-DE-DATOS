using System;
using System.Collections.Generic;

namespace Programs
{
    public class BalanceoParentesis
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ingrese la expresión a verificar:");
            string entrada = Console.ReadLine();

            if (EstaBalanceada(entrada))
                Console.WriteLine("Fórmula balanceada.");
            else
                Console.WriteLine("Fórmula no balanceada.");
        }

        private static bool EstaBalanceada(string expresion)
        {
            Stack<char> pila = new Stack<char>();
            foreach (char c in expresion)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    pila.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (pila.Count == 0) return false;
                    char cima = pila.Pop();
                    if ((c == ')' && cima != '(') ||
                        (c == '}' && cima != '{') ||
                        (c == ']' && cima != '['))
                        return false;
                }
            }
            return pila.Count == 0;
        }
    }
}
