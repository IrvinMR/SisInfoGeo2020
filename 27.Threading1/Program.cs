using System;
using System.Threading;

namespace _27.Threading1
{
    class Program
    {
        static void Main(string[] args)
        {
            //nombramos al thread principal
            Thread.CurrentThread.Name="Principal";

            //creamos 2 threads
            Thread t1 = new Thread(Imprime);
            Thread t2 = new Thread(Imprime);

            //nombramos a los threads que creamos
            t1.Name="Thread1";
            t2.Name="Thread2";

            //invocamos los threads
            t1.Start();
            t2.Start();

            //invocamos imprime desde thread principal
            Imprime();
            Console.WriteLine("Saludos desde Main, se ah terminado todo");
        }

        static void Imprime(){
            for(int i=0; i<10; i++){
                Console.WriteLine($"Imprime . {i} desde {Thread.CurrentThread.Name}");
                Thread.Sleep(100);
            }
        }

    }
}
