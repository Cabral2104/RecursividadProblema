using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursividadProblema
{
    internal class Program
    {
        static void GenerarPermutaciones(string cadena, string prefijo = "")
        {
            int n = cadena.Length;

            if (n == 0)
            {
                Console.WriteLine(prefijo); // Imprimir permutación completa
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    string nuevaCadena = cadena.Substring(0, i) + cadena.Substring(i + 1);
                    GenerarPermutaciones(nuevaCadena, prefijo + cadena[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            string entrada = "abc";
            Console.WriteLine("Permutaciones de " + entrada + ":");
            GenerarPermutaciones(entrada);
            Console.ReadKey();
        }
    }
}
