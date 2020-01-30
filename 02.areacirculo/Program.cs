using System;

namespace _02.AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
	    double radio,area;
            Console.WriteLine("Programa que calcula el area de un circulo");

            Console.WriteLine("Dame el radio");
            radio= float.Parse(Console.ReadLine());

            area = Math.PI * Math.Pow(radio,2);
            Console.Write($" El area es {area}");
	    Console.ReadLine();
        }
    }
}