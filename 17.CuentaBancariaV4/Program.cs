using System;
using System.IO;

namespace _14.CuentaBancaria
{
    [Serializable()]
    class Program
    {
        static void Inicializa(Banco banco){
            banco.AgrerarCliente(new Cliente("Juan del Diablo"));
            banco.AgrerarCliente(new Cliente("Juan Villa"));
            banco.AgrerarCliente(new Cliente("Luis Fernando"));
            banco.AgrerarCliente(new Cliente("Carlos Erick"));
            banco.AgrerarCliente(new Cliente("Rafael Lopez"));
            banco.AgrerarCliente(new Cliente("Bruno Diaz"));

            banco.Clientes[0].AgregarCuenta(new CuentadeAhorro (1000,0.5));
            banco.Clientes[0].AgregarCuenta(new CuentaCheques (1000,200));
            banco.Clientes[1].AgregarCuenta(new CuentadeAhorro (2000,0.3));
            banco.Clientes[2].AgregarCuenta(new CuentadeAhorro (2000,0.3));
            banco.Clientes[2].AgregarCuenta(new CuentadeAhorro (5000,0.2));
            banco.Clientes[3].AgregarCuenta(new CuentadeAhorro (6000,0.2));
            banco.Clientes[3].AgregarCuenta(new CuentadeAhorro (5000,0.3));
            banco.Clientes[3].AgregarCuenta(new CuentaCheques (1200,300));
            banco.Clientes[5].AgregarCuenta(new CuentaCheques (120000,1300));
            banco.Clientes[5].AgregarCuenta(new CuentadeAhorro (5000,0.6));
            banco.Clientes[4].AgregarCuenta(banco.Clientes[5].Cuentas[0]);

            banco.Clientes[5].Cuentas[0].Retira(90000);
        }

        static void Reporte(Banco banco){
            //Console.Clear();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine($"\t\t\t{banco.Nombre}");
            Console.WriteLine("\t\t\tReporte mensual de saldos");
            Console.WriteLine("-------------------------------------------------------------");
            foreach (Cliente cte in banco.Clientes){
                Console.WriteLine($"{cte.Nombre}");
                foreach (CuentaBancaria cta in cte.Cuentas){
                    if(cta is CuentadeAhorro)
                        (cta as CuentadeAhorro).CalcularInteres();
                    Console.WriteLine(cta is CuentaCheques?"cheques":"Ahorro");
                    Console.WriteLine(cta.Saldo);
                }
            Console.WriteLine($"Total Cuentas: {cte.Cuentas.Count}\n");
            }
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine($"Total Clientes: {banco.Clientes.Count}\n");
        }

        static void Main(){
            string archivo="datos";
            Banco mibanco=null;

            if(!File.Exists(archivo)){
            mibanco=new Banco("Millonario","Irvin Medina");
            Inicializa(mibanco);
            Util.Grabar(archivo,mibanco);
            Console.WriteLine("--------Datos grabados-------");
            } else {
                mibanco = new Banco();
                mibanco= Util.Cargar(archivo,mibanco);
            }

            Reporte(mibanco);
        }
    }
}