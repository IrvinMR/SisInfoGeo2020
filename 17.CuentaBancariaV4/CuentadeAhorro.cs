using System;

namespace _14.CuentaBancaria{
    [Serializable()]
    class CuentadeAhorro : CuentaBancaria{ //heredamos de cuenta bancaria
    private double tasaInteres;

    public CuentadeAhorro(double saldo, double tasaInteres)
        : base(saldo) { //llamada explicita al constructor clase base
            this.tasaInteres=tasaInteres;
        }

        public void CalcularInteres(){
            saldo+=(saldo*tasaInteres);
        }
    }
}