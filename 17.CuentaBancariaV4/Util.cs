using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace _14.CuentaBancaria{
    class Util{

        public static void Grabar(string archivo, Banco banco){
            FileStream f = new FileStream(archivo,FileMode.OpenOrCreate,FileAccess.Write);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(f,banco);
            f.Close();
        }
        
        public static Banco Cargar(string archivo, Banco banco){
            FileStream f = new FileStream(archivo,FileMode.Open,FileAccess.Read);
            BinaryFormatter b = new BinaryFormatter();
            banco= (Banco)b.Deserialize(f);
            f.Close();
            return banco;
        }
    }
}