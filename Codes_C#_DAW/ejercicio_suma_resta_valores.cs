
// Ejercicio que genera dos variables y suma 1 valor a una variable y resta un valor a la otra variable

using System;

namespace MiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 3, numero2 = 5;
            Cambios(ref numero1, ref numero2);
            Console.WriteLine("{0} - {1}", numero1, numero2);
        }

        public static void Cambios(ref int num1, ref int num2)
        {
            num1++;
            --num2;
        }
    }
}

