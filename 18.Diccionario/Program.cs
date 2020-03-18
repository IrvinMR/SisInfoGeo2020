using System;
using System.Collections.Generic;

namespace _18.Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //definimos el diccionario y reservamos espacio de memoria en el
           //Dictionary<string,string> midic = new Dictionary <string, string>();
           SortedDictionary<string,string> midic = new SortedDictionary <string, string>();

            //agregar entradas al diccionario
            midic.Add("txt","archivo de texto");
            midic.Add("jpg","archivo de imagen");
            midic.Add("mp3","archivo de sonido");
            midic.Add("htm","archivo HTML");
            midic.Add("exe","archivo ejecutable de windows");
            midic.Add("lll","archivo desconocido");

            //acceder a u elemento en base a la llave
            Console.WriteLine(midic["htm"]);

            //verificar si una llave existe
            if(midic.ContainsKey("elf"))
                Console.WriteLine("La llave ya existe");
            else
                midic.Add("elf","Archivo ejecutable de Linux");

            //borrar una entreda si la llave existe
            if(midic.ContainsKey("lll"))
                midic.Remove("lll");

            //modificar un valor del diccionario en base a la llave
            midic["htm"]="Archivo de texto HTML";



            //recorre el diccionario e imprimir la llave y su valor
            foreach (KeyValuePair<string,string> val in midic)
                Console.WriteLine($"{val.Key} - {val.Value}");
            
            //imprimir solo las llaves del diccionario
            foreach (string llave in midic.Keys)
                Console.WriteLine(llave);
            
            //imprimir solo los valores del diccionario
            foreach (string valor in midic.Values)
                Console.WriteLine(valor);
        }
    }
}
