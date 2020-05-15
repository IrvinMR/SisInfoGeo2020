using System;
using System.Threading;

namespace _29.Threading3
{
    class Impresora{
        public void imprime(object o){
            //bloquea la parte del codigo o lo ejecuta de manera
            //independiente hasta que otro thread termine
            lock(this){
                for(int i=1; i<=10; i++){
                    Thread.Sleep(100);
                    Console.WriteLine($"{o} - {i}");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Impresora i = new Impresora();
            Thread t1 = new Thread(i.imprime);
            Thread t2 = new Thread(i.imprime);

            t1.Start(t1.ManagedThreadId);
            t2.Start(t2.ManagedThreadId);

            i.imprime(Thread.CurrentThread.ManagedThreadId);
        }
    }
}
