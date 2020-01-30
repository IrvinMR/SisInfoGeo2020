using System;

namespace _03.AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float area, b, a;
            Console.WriteLine("Programam que calcula el area de un triangulo");

            Console.WriteLine("Dame la base");
	    b=float.Parse(Console.ReadLine());

	    Console.WriteLine("Dame la altura");
	    a=float.Parse(Console.ReadLine());

	    area= (b*a)/2;
	
	    Console.WriteLine($"El area es {area}");
	    Console.ReadLine();

        }
    }
}
