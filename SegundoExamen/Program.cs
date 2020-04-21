using System;
using System.Collections.Generic;
using System.Linq;
using System.IO; // Libreria para StreamREader y StreamWriter
using CsvHelper; // Libreria para trabajar con archivos cvs
using System.Globalization;

namespace SegundoExamen{
    class Program{
        static void Main(string[] args){
            int op;
            List<Empleado> registros = new List<Empleado>();
            
            if(args.Length==0) Menu();
            op=int.Parse(args[0]);
            
            registros=Leer("datos.csv");
            
            registros.Add(new Empleado {rfc="CARC771123", Nombre="CARLOS CASTANEDA RODRIGUEZ", Area="JUBILADOS", Salario=5456.66});
            registros.Add(new Empleado {rfc="SOBR711202", Nombre="ROCIO SOTO BOTELLO", Area="JUBILADOS", Salario=6423.66});
            registros.Add(new Empleado {rfc="SUGA791124", Nombre="ARACELI SUSTAITA GOMEZ", Area="PROMOCION", Salario=2380});
            registros.Add(new Empleado {rfc="DEAM690813", Nombre="MARGARITA DELGADILLO ARCE", Area="PROMOCION", Salario=1858});
            registros.Add(new Empleado {rfc="PETT670521", Nombre="PEREZ TORRES MARIA TRINIDAD", Area="PROMOCION", Salario=1851});
            registros.Add(new Empleado {rfc="ROLE771004", Nombre="ERIKA FRANCISCA ROBLES LOPEZ", Area="JUBILADOS", Salario=4691.44});
            registros.Add(new Empleado {rfc="LERK911214", Nombre="KARELY GUADALUPE LEAL RAMOS", Area="DEPORTE", Salario=1223.66});
            registros.Add(new Empleado {rfc="BEAY911116", Nombre="YESICA BERUMEN ACOSTA", Area="CULTURA", Salario=6423.66});
            
            switch (op){
                case 1: {
                    Console.WriteLine("\n Listado de nomina orden original:\n\n");
                    registros.ForEach(reg=>Console.WriteLine(reg.ToString()));
                    Console.WriteLine($"Total:{registros.Count()}");
                    Grabar(registros,"nomina.csv");
                    
                } break;
                case 2: {
                    Console.WriteLine("\n Listado de nómina ordenado por nombre:\n\n");
                    var cons1 = (from reg in registros orderby reg.Nombre select reg).ToList();
                    registros.ForEach(reg=>Console.WriteLine(reg.ToString()));
                    Console.WriteLine($"Total:{cons1.Count()}");
                    Grabar(registros,"nomina.csv");
                    
                } break;
                case 3: {
                    Console.WriteLine("\n Listado de nomina orden salario:\n\n");
                    var cons2 = (from reg in registros orderby reg.Salario select reg).ToList();
                    registros.ForEach(reg=>Console.WriteLine(reg.ToString()));
                    Console.WriteLine($"Total:{cons2.Count()}");
                    Grabar(registros,"nomina.csv");
                    
                } break;
                case 4: {
                    Console.WriteLine("\n Listado de nomina con salario > 3500:\n\n");
                    var cons3 = (from reg in registros where reg.Salario>3500 select reg).ToList();
                    registros.ForEach(reg=>Console.WriteLine(reg.ToString()));
                    Console.WriteLine($"Total:{cons3.Count()}");
                    Grabar(registros,"nomina.csv");
                    
                } break;
                case 5: {
                    Console.WriteLine("\n Listado de nomina con 77 en el Rfc:\n\n");
                    var cons4 =registros.FindAll(reg=>reg.rfc.Contains("77"));
                    cons4.ForEach(p=>Console.WriteLine(p.ToString()));
                    Console.WriteLine($"Total:{cons4.Count()}");
                    Grabar(registros,"nomina.csv");

                } break;
                case 6: {
                    Console.WriteLine("\n Listado de nomina con los JUBILADOS:\n\n");
                    var cons5 = (from reg in registros where reg.Area=="JUBILADOS" select reg).ToList();
                    cons5.ForEach(reg=>Console.WriteLine(reg.ToString()));
                    Console.WriteLine($"Total:{cons5.Count()}");
                    Grabar(registros,"nomina.csv");

                } break;
                case 7: {
                    Console.WriteLine("\n Listado de nomina agrupado por área:\n\n");
                    var cons6 = from reg in registros group reg by reg.Area;
                    foreach (var Area in cons6){
                        Console.WriteLine(Area.Key);
                        foreach (var reg in Area)
                            Console.WriteLine(reg.ToString());
                    }
                    
                    Console.WriteLine($"Total:{cons6.Count()}");
                    Grabar(registros,"nomina.csv");

                } break;

                default: { 
                    Menu();
                } break;
            }

        }
    

// leer
        public static List<Empleado> Leer(string file) {
            using (var  reader = new StreamReader(file))
            using (var csv = new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                csv.Configuration.HasHeaderRecord=false;
                csv.Read();
                var records=csv.GetRecords<Empleado>().ToList();
                return records;
            }
        }

//guardar
        public static void Grabar(List<Empleado> records, string file) {
             using (var writer = new StreamWriter(file))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }           
        } 

//menu
        static void Menu(){
            Console.Clear();
            Console.WriteLine("\nListado de nómina en el orden original----------[1]");
            Console.WriteLine("Listado de nómina ordenado por nombre-----------[2]");
            Console.WriteLine("Listado de nómina ordenado por salario----------[3]");
            Console.WriteLine("Listado de nómina con salario > 3500------------[4]");
            Console.WriteLine("Listado de nómina con 77 en el Rfc--------------[5]");
            Console.WriteLine("Listado de nómina con los JUBILADOS-------------[6]");
            Console.WriteLine("Listado de nómina agrupado por área-------------[7]");
        }

    }
}
