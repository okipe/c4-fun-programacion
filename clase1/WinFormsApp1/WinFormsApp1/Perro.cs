using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    internal class Perro
    {
        public string nombre;
        public string color;
        public int edad;

        public string comer(string comida)
        {
            return $"{this.nombre} es de color {this.color} y come {comida}"; 
        }
    }
}
