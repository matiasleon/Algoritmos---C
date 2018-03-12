using System;

namespace AlgoritmosYEstructurasDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var numeros = input.Split(' ');
            var a = int.Parse(numeros[0]);
            var b = int.Parse(numeros[1]);
            Console.WriteLine(a + b);
        }
    }
}
