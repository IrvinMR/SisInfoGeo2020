using System.Collections.Generic;

namespace PrimerExamen{
    public class Red{
        private string empresa;
        private string propietario;
        private string domicilio;

        private List<Nodo> nodo;

        public Red(string empresa, string propietario, string domicilio){
            this.empresa=empresa;
            this.propietario=propietario;
            this.domicilio=domicilio;
            nodo = new List<Nodo>();
        }
        public Red(){
            nodo = new List<Nodo>();
        }

        public string Empresa{
            get {return empresa;}
            set{empresa = value;}
        }
        public string Propietario{
            get {return propietario;}
            set{propietario = value;}
        }

        public string Domicilio{
            get {return domicilio;}
            set{domicilio = value;}
        }

        public List<Nodo> Nodo {
             get {return nodo;}
        }

        public void AgregarNodo(Nodo nod){
            nodo.Add(nod);
        }

        public int totvul(){
            int suma=0;
            foreach (Nodo n in nodo){
                suma+=n.Vulnerab.Count;
            }
            return suma;
        }

        
        
    }
}