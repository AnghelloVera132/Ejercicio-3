using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de notas: ");
            int numero = int.Parse(Console.ReadLine());
            float suma = 0f;
            for (int i = 0; i < numero; i++)
            {
                Console.Write($"Ingrese la nota{i}: ");
                float notas = float.Parse(Console.ReadLine());
                suma += notas;
            }
            float resoult;
            resoult = suma / numero;
            Console.Write($"El promedio es: {resoult}");
            Console.ReadKey();
        }
    }
}
