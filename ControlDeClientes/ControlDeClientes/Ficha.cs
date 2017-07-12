using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeClientes
{
    class Ficha
    {
        public Ficha(string nombre, string telefono1, string telefono2, string telefono3, string direccion, string anotaciones, string observaciones, string fechas, string deuda)
        {
            this.nombre = nombre;
            this.telefono1 = telefono1;
            this.telefono2 = telefono2;
            this.telefono3 = telefono3;
            this.direccion = direccion;
            this.anotaciones = anotaciones;
            this.observaciones = observaciones;
            this.fechas = fechas;
            this.deuda = deuda;
        }

        public String nombre { get; set; }
        public String telefono1 { get; set; }
        public String telefono2 { get; set; }
        public String telefono3 { get; set; }
        public String direccion { get; set; }
        public String anotaciones { get; set; }
        public String observaciones { get; set; }
        public String fechas { get; set; }
        public String deuda { get; set; }
    }
}
