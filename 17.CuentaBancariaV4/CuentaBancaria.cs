using System;
namespace _14.CuentaBancaria{
    [Serializable()]
    class CuentaBancaria{
        protected double saldo; //permite que sea accedido por las clases que heredan

        public CuentaBancaria(double saldo){
            this.saldo=saldo;
        }

        public double Saldo{
            get{return saldo;}
            set{saldo=value;}
        }

        public void Deposita(double cant){ 
            saldo += cant;
        }

//metodo virtual que podra ser sobrecargado por la clase que lo heredan
        public virtual bool Retira(double cant){
            if(saldo>=cant){
                saldo-=cant;
                return true;
            } else return false;
        }
    }
}