using System;
namespace _31.Delegados1
{
//ejemplo de delegado simple
    public delegate void MiDelegado(string msj);
    
    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado d; //se instancia un delegado

            Console.Clear();

            //delegado invoca al metodo Mensaje1 de la clase mensajes
            d= Mensajes.Mensaje1;
            d("Juan");

            //delegado invoca al metodo Mensaje2 de la clase mensajes
            d=Mensajes.Mensaje2;
            d("Jose");

            //delegado invoca a una expresion lambada
            d=(string msj) => Console.WriteLine($"{msj} - paga todo, que no pare la fiesta");
            d("Carlos");

            Console.WriteLine();
        }
    }

    public class Mensajes{
        public static void Mensaje1(string msj){
            Console.WriteLine($"{msj} - lleva el pastel");
        }
        public static void Mensaje2(string msj){
            Console.WriteLine($"{msj} - fue el culpable, se cancela la fiesta");
        }
    }
}
