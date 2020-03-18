using System;
using System.Collections.Generic;

namespace _19.ListasV1
{
    class Program
    {
        static void Main(string[] args)
        {
            //definir una lista con valores iniciales
            List<string> mats = new List<string>(){
                "Calculo I",
                "Redaccion Avanzada",
                "Introduccion a la Ingenieria"
            };

            //agregar elementos a la lista
            mats.Add("Matematicas Discretas");
            mats.Add("Compiladores e Interpretes");

            Imprime(mats);

            //agregar un rango de materias
            string[] mopt={
                "Sistemas de Info Geo (op)",
                "Seguridad de Redes (op)",
                "Topicos Selectos de Redes (op)"
            };

            mats.AddRange(mopt);
            Imprime(mats);

            //invertir los elementos de la lista
            mats.Reverse();
            Imprime(mats);

            //ordenar la lista
            mats.Sort();
            Imprime(mats);

            //buscar un elemento en la lista, en base a una condicion
            Console.WriteLine("Buscar una materia que tengala palabra Discretas");
            string mat = mats.Find(x=>x.Contains("Discretas"));
            Console.WriteLine(mat);

            //buscar todas las ocurrencias en la lista, en base a una condicion
            Console.WriteLine("Buscar una materia que contengan (op)");
            var ms = mats.FindAll(x=>x.Contains("(op)"));
            Imprime(ms);
        }

        static void Imprime(List<string> lista){
            Console.WriteLine("\n\n");
            foreach (string m in lista){
                Console.WriteLine(m);
            }
            Console.WriteLine(lista.Count);
        }
    }
}
