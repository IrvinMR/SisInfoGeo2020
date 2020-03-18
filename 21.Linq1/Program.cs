using System;
using System.Linq;
using System.Collections.Generic;

namespace _21.Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            //fuente de datos
            int [] numeros = new int []{
                1,2,3,4,5,6,7,8,9,10,
                -1,-2,-3,-4,0,100,1000,500,200,5000,
                11,12,14,15,26,76,49,20,19,34,
                95,84,73,63,19,28,50,56,78,12
            };

            //consulta
            var consulta =
                from num in numeros
                where num%2==0
                select num;

            //ejecutar consulta
            foreach (var num in consulta)
                Console.Write($"{num} ");
            
                Console.WriteLine("\n\n------- ");
            //consulta 2, impares no negativos, ni ceros, en un arreglo(regresa un int[])
            var consulta2 = (from num in numeros where num%2!=0 && num>0 select num).ToArray();
            for(int i=0; i<consulta2.Count(); i++)
                Console.Write($"{consulta2[i]} ");

            //numeros entre 10 y 200 en un arreglo (regresa un int[])

            var consulta3 =
                (from num in numeros
                where num>=10 && num<=200
                select num).ToArray();

            Console.WriteLine("\nNumeros entre 10 y 200 ");
            for(int i=0; i<consulta3.Count(); i++)
                Console.Write($"{consulta3[i]} ");

            //consulta 3, negativos, en una lista (regresa List<int>)   
            var consulta4 =
                (from num in numeros
                where num<0
                select num).ToList();

            Console.WriteLine("\nNumeros negativos ");
            consulta4.ForEach(num=>Console.Write(num));

        }
    }
}
