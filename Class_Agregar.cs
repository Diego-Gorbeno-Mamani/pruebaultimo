using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Grupo_Anahua_Arias_Coloma
{
    class Class_Agregar
    {
        private string nombre;
        private string direccion;
        private string telefono;
        private string ruc;
        private string electrodomestico;
        private int precio;
  
        public Class_Agregar()
        {

        }
        public Class_Agregar(string nombre, string direccion, string telefono, string ruc, string electrodomestico, int precio)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Ruc = ruc;
            this.Electrodomestico = electrodomestico;
            this.Precio = precio;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public string Electrodomestico { get => electrodomestico; set => electrodomestico = value; }
        public int Precio { get => precio; set => precio = value; }
  
    }
    

}
