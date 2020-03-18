using System;
using System.Collections.Generic;
using System.Linq;

namespace _23.Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> grupo = new List<Estudiante>();

            grupo.Add(
                new Estudiante {Id=1234, Nombre="Jose",
                Ciudad="Zacatecas",Calle="1ro de Mayo",
                Cals=new List<int> {90,80,70,60}
                }
            );

            grupo.Add(
                new Estudiante {Id=2345, Nombre="Maria",
                Ciudad="Fresnillo",Calle="Benito Juarez",
                Cals=new List<int> {90,50,60,60}
                }
            );

            grupo.Add(
                new Estudiante {Id=3456, Nombre="Miguel",
                Ciudad="Jerez",Calle="Garcia Salinas",
                Cals=new List<int> {50,50,50,40}
                }
            );


            grupo.Add(
                new Estudiante {Id=4567, Nombre="Lourdes",
                Ciudad="Zacatecas",Calle="El vergel",
                Cals=new List<int> {100,100,100,90}
                }
            );

            //imprimir todos los datos
            Console.WriteLine("\n Todo de Todo");
            grupo.ForEach(est=>Console.WriteLine(est.ToString()));

            //ordenar por nombre
            var q1 = (from est in grupo orderby est.Nombre select est).ToList();
            Console.WriteLine("\todo ordenado por nombre : \n");
            q1.ForEach(est=>Console.WriteLine(est.ToString()));

            //solo los de zacatecas
            var q2 = (from est in grupo where est.Ciudad=="Zacatecas" select est).ToList();
            Console.WriteLine("\nSolo los de Zacatecas : \n");
            q2.ForEach(est=>Console.WriteLine(est.ToString()));

            //nombre de estudiantes con promedio>80
            var q3 = (
                from est in grupo
                where est.Cals.Average()>70
                select new{nombre=est.Nombre, promedio=est.Cals.Average() }).ToList();
            Console.WriteLine("\nnombre y promedio mayor a 70 : \n");
            q3.ForEach(est=>Console.WriteLine($"Nombre:{est.nombre}, Promedio:{est.promedio}"));

            //agrupar por ciudad
            var q4 = from est in grupo group est by est.Ciudad;
            Console.WriteLine("\nEstudiantes agrupados por ciudad : \n");
            foreach (var ciudad in q4){
                Console.WriteLine(ciudad.Key);
                foreach (var est in ciudad)
                    Console.WriteLine(est.ToString());
            }
            

        }
    }
}
