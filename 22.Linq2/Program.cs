using System;
using System.Linq;

namespace _22.Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = new string[] {
                "pera","manzana","mango","naranja","papaya",
                "melon","sandia","platano","cereza","durazno",
                "piña","pepino","kiwi"
            };

            var qry1 =
                from fruta in frutas
                where fruta.StartsWith("m")
                select fruta;
            
            foreach (string f in qry1)
                Console.WriteLine(f);
            Console.WriteLine($"Total:{qry1.Count()}");

            var qry2 = (from fruta in frutas where fruta.Contains("am") select fruta).ToList();
            qry2.ForEach(f=>Console.WriteLine(f));
            Console.WriteLine($"Total:{qry2.Count()}");

        }
    }
}
