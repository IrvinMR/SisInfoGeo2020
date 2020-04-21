using System;
using System.Collections.Generic;

namespace SegundoExamen{
    class Empleado{
        public string rfc{get; set;}
        public string Nombre{get; set;}
        public string Area{get; set;}
        public double Salario{get; set;}
        public override string ToString() => $"rfc:{rfc}, Nombre:{Nombre}, Area:{Area}, Salario:{Salario}";
    }
}