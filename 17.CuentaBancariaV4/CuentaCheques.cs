using System;

namespace _14.CuentaBancaria{
    [Serializable()]
    class CuentaCheques : CuentaBancaria{
        private double ProteccionSobreGiro;

        public CuentaCheques(double saldo, double ProteccionSobreGiro)
            : base(saldo){
                this.ProteccionSobreGiro=ProteccionSobreGiro;
            }

        public override bool Retira(double cant){
            
            if(saldo < cant){
                double proteccionrequerida = cant - saldo;
                if(ProteccionSobreGiro< proteccionrequerida)
                    return false;
                else{
                    saldo=0.0;
                    ProteccionSobreGiro-=proteccionrequerida;
                }
            }else{
                saldo-=cant;
                return true;
            }
            return true;
        }
    }
}