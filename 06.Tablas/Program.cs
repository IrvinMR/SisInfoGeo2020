using System;

namespace _06.Tablas
{
class Program
    {
        static void Main(string[] args)
        {
            int tab, ini, fin, res=0;
            Console.WriteLine("Este programa muestra las tablas de multiplicar");

            tab=int.Parse(args[0]);
            ini=int.Parse(args[1]);
            fin=int.Parse(args[2]);

            Console.WriteLine($"El la tabla de multiplicar del {tab} es:");
            for (int i = ini; i <= fin; i++){
                res=tab*i;
                Console.WriteLine($"{tab} x {i} = {res}");
            }

        }
    }
}
