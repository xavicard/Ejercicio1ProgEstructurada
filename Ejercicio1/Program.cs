using System;
using System.Diagnostics.CodeAnalysis;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            String n1,n2;
            int num1, num2, suma;
            Console.WriteLine("Ingrese el Numero 1");
            n1 = Console.ReadLine();
            Console.WriteLine("Ingrese el Numero 2");
            n2 = Console.ReadLine();
            num1 = int.Parse(n1);
            num2 = int.Parse(n2);
            suma = num1 + num2;
            Console.WriteLine("La suma es "+suma);
        }
    }
}
