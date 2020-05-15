using System;

namespace _33.Delegados3{
    //ejemplo de delegado multicast con parametros

//delegado puede tener tipo  y varios parametros
    public delegate int MiDelegado(int a, int b); //declaracion de delegado

    class Program{

        static void Main(string[] args){
            //apuntan a metodos diferentes que estan en classes diferentes
            MiDelegado d1 = A.MetodoA;
            MiDelegado d2 = B.MetodoB;

            //invoca delegados de forma separada
            Console.WriteLine($"La suma           es {d1(10,20)}");
            Console.WriteLine($"La multiplicacion es {d2(10,20)}");
            Console.WriteLine();

            //delegado multicast que une los 2 metodos
            MiDelegado d = d1 + d2;
            Console.WriteLine($"El resultado es {d(10,20)}"); //regresa el resultado del ultimo metodo invocado
            Console.WriteLine();

            Console.WriteLine();            
        }
    }

    public class A{
        public static int MetodoA (int a, int b){
            return a+b;
        }
    }

    public class B{
        public static int MetodoB (int a, int b){
            return a*b;
        }
    }

}
