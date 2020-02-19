using System;

namespace ej1{
    class empleado{
        //miembros de la clase
        private string nombre;
        private int edad;

        //propiedades de la clase (utiles para enviar y recibir valores)
        public string Nombre{
            get{return nombre;}
            set{nombre= value;}
        }

        public int Edad{
            get{return edad;}
            set{edad= value;}
        }

        public empleado(){}

        public empleado(string nombre, int edad){
            this.nombre=nombre;
            this.edad=edad;
        }

        public string Vacaciones(DateTime ini, int dias){
            DateTime fin;
            fin=ini.AddDays(dias);
            return fin.ToString("dd/MM/yy");
        }

        //sobrecargamos el metodo tostring heredado de clase base
        public override string ToString(){
                return $"Nombre: {Nombre}, Edad: {Edad}";
        }
    }
}