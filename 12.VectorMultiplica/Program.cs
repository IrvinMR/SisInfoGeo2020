using System;

namespace _12.VectorMultiplica
{
 class Program
    {
        static void Main(string[] args) {
            int[] A = new int[15];
            int[] B = new int[15];
            int[] C = new int[15];
            int j=14;

            Random rnd = new Random();
            for (int i = 0 ; i < A.Length ; i++){
                A[i]=rnd.Next(1,10);
                B[i]=rnd.Next(1,10);
            }
                
            for (int i = 0 ; i < A.Length ; i++){
                //for (int j = 15; i < B.Length; j--){
                    C[i]=A[i]*B[j];
                    j--;
                //}
            }

            Console.WriteLine("Vector A: ");
            imprime(A);

            Console.WriteLine("\nVector B: ");
            imprime(B);
            
            Console.WriteLine("\nVector C: ");
            imprime(C);
        }
        
        static void imprime(int[] v){
            for (int i = 0; i < v.Length; i++)
                Console.Write($"{v[i]} ");
        }
    }
}
