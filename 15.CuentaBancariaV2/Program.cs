﻿using System;

namespace _14.CuentaBancaria
{
    class Program
    {
        static void PruebaCuentaBancaria(){
            CuentaBancaria chelines= new CuentaBancaria(1000);
            Console.WriteLine($"Saldo al crear {chelines.Saldo}");
            chelines.Saldo=500;
            Console.WriteLine($"Saldo despues del domingo {chelines.Saldo}");
            if(chelines.Retira(600))
                Console.WriteLine($"Saldo despues de la peda {chelines.Saldo}");
            else{
                Console.WriteLine("No puedes andar organzando fiestas");
            }
        }

        static void PruebaCuentaClientes(){
            //creamos 2 objetos tipo cliente
            Cliente cliente1 = new Cliente("Juan Perez");
            Cliente cliente2 = new Cliente("Maria Lopez");
            Cliente cliente3 = new Cliente("Mario Lopez");

            //creamos un objeto tipo cuenta
            //creamos un objeto tipo cliente y le asignaos cuenta
            CuentaBancaria cuenta1 = new CuentaBancaria(100);
            cliente1.Cuenta=cuenta1;
            cliente1.Cuenta.Deposita(500);

            //asignamos directamente cuenta al cliente
            cliente2.Cuenta= new CuentaBancaria(200);
            cliente3.Cuenta=cliente2.Cuenta;
            cliente2.Cuenta.Retira(50);
            cliente3.Cuenta.Deposita(100);

            Console.WriteLine($"Cliente {cliente1.Nombre} tiene un saldo de {cliente1.Cuenta.Saldo}");
            Console.WriteLine($"Cliente {cliente2.Nombre} tiene un saldo de {cliente2.Cuenta.Saldo}");
            Console.WriteLine($"Cliente {cliente3.Nombre} tiene un saldo de {cliente2.Cuenta.Saldo}");
        }

        static void Main(){
            Banco mibanco=new Banco("mis chelines","carlos ricon");

            mibanco.AgrerarCliente(new Cliente("Genaro Borrego"));
            mibanco.AgrerarCliente(new Cliente("Arturo Romo"));
            mibanco.AgrerarCliente(new Cliente("Ricardo Monreal"));
            mibanco.AgrerarCliente(new Cliente("Amalia Garcia"));
            mibanco.AgrerarCliente(new Cliente("Miguel Alonso"));
            mibanco.AgrerarCliente(new Cliente("Alejandro Tello"));

            mibanco.Clientes[0].Cuenta=new CuentaBancaria(15000);
            mibanco.Clientes[1].Cuenta=new CuentaBancaria(25000);
            mibanco.Clientes[2].Cuenta=new CuentaBancaria(35000);
            mibanco.Clientes[3].Cuenta=new CuentaBancaria(55000);
            mibanco.Clientes[4].Cuenta=new CuentaBancaria(85000);
            mibanco.Clientes[5].Cuenta=new CuentaBancaria(105000);

            mibanco.Clientes[2].Cuenta.Retira(15000);
            mibanco.Clientes[5].Cuenta.Retira(25000);
            mibanco.Clientes[3].Cuenta.Deposita(25000);

            foreach (Cliente cte in mibanco.Clientes){
                Console.WriteLine($"Cliente: {cte.Nombre}, saldo: {cte.Cuenta.Saldo}");    
            }
        }
    }
}