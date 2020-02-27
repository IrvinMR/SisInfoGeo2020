using System;

namespace PrimerExamen{
    class Program{
        static void Inicializa(Red red){
            red.AgregarNodo(new Nodo("192.168.0.10","Servidor",5,10,"Linux"));
            red.AgregarNodo(new Nodo("192.168.0.12","Equipo activo",2,12,"IOS"));
            red.AgregarNodo(new Nodo("192.168.0.15","computadora",8,5,"Windows"));
            red.AgregarNodo(new Nodo("192.168.0.20","Servidor",10,22,"Linux"));

            red.Nodo[0].AgregarVulnerab( new Vulnerabilidad("CVE-2015-1635","microsoft","HTTP.sys permite a atacantes remotos ejecutar código arbitrario","remota","04/14/2015"));
            red.Nodo[0].AgregarVulnerab( new Vulnerabilidad("CVE-2017-0004","microsoft","El servicio LSASS permite causar una denegación de servicio","local","01/10/2001"));
            red.Nodo[1].AgregarVulnerab( new Vulnerabilidad("CVE-2017-3847","cisco","Cisco Firepower Management Center XSS","remota","02/21/2017"));
            red.Nodo[2].AgregarVulnerab( new Vulnerabilidad("CVE-2009-2504","microsoft","Múltiples desbordamientos de enteros en APIs Microsoft .NET 1.1","local","11/13/2009"));
            red.Nodo[2].AgregarVulnerab( new Vulnerabilidad("CVE-2016-7271","microsoft","Elevación de privilegios Kernel Segura en Windows 10 Gold","local","12/20/2016"));
            red.Nodo[2].AgregarVulnerab( new Vulnerabilidad("CVE-2017-2996","adobe","Adobe Flash Player 24.0.0.194 corrupción de memoria explotable","remota","15/05/2017"));
        }

        static void Reporte(Red red){
            Console.WriteLine("--------Datos Generales de la Red----------");
            Console.WriteLine($"Empresa      : {red.Empresa}");
            Console.WriteLine($"Propietario  : {red.Propietario}");
            Console.WriteLine($"Domicilio    : {red.Domicilio}");

            Console.WriteLine($"\nTotal de nodos de la red : {red.Nodo.Count }");
            Console.WriteLine($"Total de vulnerabilidades  : {red.totvul()} \n");

            Console.WriteLine("--------Datos Generales de los Nodos--------");
            foreach (Nodo nod in red.Nodo){
                Console.WriteLine($"Ip : {nod.Ip}, Tipo : {nod.Tipo}, Puertos : {nod.Puertos}, Saltos : {nod.Saltos}, So : {nod.Saltos}, TotalVul : {nod.Vulnerab.Count}");
            }
            Console.WriteLine($"\nMayor numero de saltos : x");
            Console.WriteLine($"Menor numero de saltos : x\n");

            Console.WriteLine("\n--------Vulnerabilidades por Nodos--------");
            foreach (Nodo nod in red.Nodo){
                Console.WriteLine($"\nIp : {nod.Ip},Tipo : {nod.Tipo}\n");
                foreach (Vulnerabilidad vul in nod.Vulnerab ){
                if(vul == null){
                    Console.WriteLine(" No tiene vulnerabilidades ...");
                }else
                    Console.WriteLine("Vulnerabilidades\n");
                    Console.WriteLine($"Clave : {vul.Clave}, Vendedor : {vul.Vendedor}, Descripcion : {vul.Descripcion}, Tipo : {vul.Tipo}, Fecha : {vul.Fecha}, Antigüedad : x");
                }
            }            
        }

        

        static void Main(string[] args){
            // crear red
            Red red= new Red ("Mis amiguitos","Irvin Medina","Las flores 12");

            Inicializa(red);
            Reporte(red);
        }
    }
}
