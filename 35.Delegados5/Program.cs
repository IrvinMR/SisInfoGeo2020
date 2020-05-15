using System;

namespace _35.Delegados5{
// ejemplo de delegado como parametro

public delegate void MiDelegado(string msj);

    class Program{
        static void Main(string[] args){
            
            MiDelegado del;// se crea instancia de MiDelegado
            Console.Clear();

            del=ClaseA.MetodoA;
            Invocadelegado(del); //se invoca delegado
            
            del=ClaseB.MetodoB;
            Invocadelegado(del); //se invoca delegado

            del= (string msj) => Console.WriteLine($"Llamando expresion lambada: {msj}");
            Invocadelegado(del);

            Console.WriteLine();            
        }

        //este metodo recibe como parametro un delegado
        static void Invocadelegado(MiDelegado del){
            del("Hola mundo"); //se invoca el delegado
        }
    }

    class ClaseA{
        public static void MetodoA(string msj){
            Console.WriteLine($"LLamando MetodoA de ClaseA : {msj}");
        }
    
    }
    class ClaseB{
        public static void MetodoB(string msj){
            Console.WriteLine($"LLamando MetodoB de ClaseB : {msj}");
        }
    }

}
