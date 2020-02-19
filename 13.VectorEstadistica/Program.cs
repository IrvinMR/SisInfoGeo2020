using System;

namespace _13.VectorEstadistica{
    class Program
    {
        static void Main(string[] args)
        {
            double[] A;
            int n=0;
            Console.WriteLine("Cuantos elementos? "); n = int.Parse(Console.ReadLine());
            A= new double[n];

            Console.WriteLine("Dame el elemento del arreglo \n");
            leer(A);

            Console.WriteLine("Estadisticas");
            Console.WriteLine($"Mayor {mayor(A)}");
            Console.WriteLine($"Menor {menor(A)}");
            Console.WriteLine($"Promedio {promedio(A)}");
            Console.WriteLine($"Varianza {varianza(A,promedio(A))}");
            Console.WriteLine($"Desv Estandar {Math.Sqrt(varianza(A,promedio(A)))}");
        }

        static double varianza(double[] v, double media) {
            double s=0;
            for(int i=0; i<v.Length; i++)
                s+= Math.Pow(v[i]-media,2);
            return s/v.Length-1;
        }

        static double promedio (double[] v){
            double s=0;
            for(int i=0; i<v.Length; i++)
                s+=v[i];
            return s/v.Length;
            }

        static double menor (double[] v){
            double m=v[0];
            for(int i = 1; i<v.Length ; i++)
                if(v[i]<m) m=v[i];
            return m;
            }

        static double mayor (double[] v){
            double m=v[0];
            for(int i = 1; i<v.Length ; i++)
                if (v[i]> m) m=v[i];
            return m;
            }

        static void leer(double[] v){
            for(int i=0;i<v.Length;i++){
                Console.Write($"Elemento {i+1} =" ); 
                v[i]=double.Parse(Console.ReadLine());
            }
        }
    }
}