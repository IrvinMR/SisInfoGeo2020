using System.Collections.Generic;

namespace PrimerExamen{
    public class Nodo{
        private string ip;
        private string tipo;
        private double puertos;
        private double saltos;
        private string so;

        private List<Vulnerabilidad> vulnerab;

        public Nodo (){
            vulnerab = new List<Vulnerabilidad>();
        }
        public Nodo (string ip,string tipo, double puertos, double saltos,string so){
            this.ip= ip;
            this.tipo=tipo;
            this.puertos=puertos;
            this.saltos=saltos;
            this.so=so;
            vulnerab = new List<Vulnerabilidad>();
        }

        public string Ip{
            get {return ip;}
            set{ip = value;}
        }
        public string Tipo{
            get {return tipo;}
            set{tipo = value;}
        }
        public double Puertos{
            get {return puertos;}
            set{puertos = value;}
        }
        public double Saltos{
            get {return saltos;}
            set{saltos = value;}
        }
        public string So{
            get {return so;}
            set{so = value;}
        }

        public List<Vulnerabilidad> Vulnerab{
            get {return vulnerab;}
        }

        public void AgregarVulnerab(Vulnerabilidad vul){
            vulnerab.Add(vul);
        }

    }
}