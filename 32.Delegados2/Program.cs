using System;

namespace _32.Delegados2
{
    //ejemplo de delegado multicast

    //declaracion de delegado
    public delegate void MiDelegado(string msj);

    class Program
    {
        static void Main(string[] args)
        {
            //se declaran 3 delegados
            MiDelegado d1;
            MiDelegado d2;
            MiDelegado d3;

            MiDelegado d; //se declara delegado multicast

            Console.Clear();

            //asocia d1 a Mensaje1 y d2 a Mensaje2
            d1= Delegados.Mensaje1;
            d2= Delegados.Mensaje2;

            d=d1 + d2; //combina delegado d1 y delegado d2
            d("El peje");
            Console.WriteLine();

            d3=(string msj) => Console.WriteLine($"{msj} - paga todo que no pare la fiesta");
            d+= d3; //agrega delegado d3
            d("El borolas");
            Console.WriteLine();

            d-=d2; //quita el delegado d2
            d("Peña");
            Console.WriteLine();

            d-=d1; //quita el delegado d1
            d("Tello");
            Console.WriteLine();



        }
    }
}
