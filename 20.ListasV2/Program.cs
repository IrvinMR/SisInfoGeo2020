using System;
using System.Collections.Generic;

namespace _20.ListasV2{
    class Program{
        static void Main(string[] args){
            
            List<Pieza> mp = new List<Pieza>();

            mp.Add(new Pieza(1234,"Tuerca de rosca interior"));
            mp.Add(new Pieza(1111,"Tornillo cabeza grande"));
            mp.Add(new Pieza(1222,"bateria 12 V"));

            //agregar rango de elementos
            var proveedor = new List<Pieza>(){
                new Pieza(1233,"tornillo cabeza pequeña"),
                new Pieza(2333,"cables para corriente"),
                new Pieza(3344,"tridente del diablo")
            };
            mp.AddRange(proveedor);

            //usar el metodo foreach integrado en la lista para imprimir su contenido
            mp.ForEach(p=>Console.WriteLine(p.ToString()));

            //elimina el ultimo elemento de la lista
            mp.RemoveAt(mp.Count-1);

            //insertar un elemento en la posicion 2
            Console.WriteLine("Inserta un elemento en la posicion 2");
            mp.Insert(1, new Pieza(2341,"caja de 8 velocidades"));
            mp.ForEach(p=>Console.WriteLine(p.ToString()));

            // buscar todas las piezas que tengan la palabra tornillo
            Console.WriteLine("Piezas que contienen tornillo");
            var t=mp.FindAll(x=>x.Nombre.Contains("tornillo"));
            t.ForEach(p=>Console.WriteLine(p.ToString()));
        
            // buscar todas las piezas cuyo Id sea mayor a 2000
            Console.WriteLine("Piezas con id > 2000");
            var t1=mp.FindAll(x=>x.Id>2000);
            t1.ForEach(p=>Console.WriteLine(p.ToString()));
        }
    }
}
