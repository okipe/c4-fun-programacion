using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Esquema
{
    class Impresora
    {
        // Atributos
        int codigoImpresora;
        string marcaImpresora;
        string modeloImpresora;
        string serieImpresora;

        // Constructor
        public Impresora()
        {
            this.codigoImpresora = 1;
            this.marcaImpresora = "Canon";
            this.modeloImpresora = "G3100";
            this.serieImpresora = "AGF45TY";
        }

        // Constructor 2
        public string encender()
        {
            return $"Encendiendo la impresora {codigoImpresora} {marcaImpresora} {modeloImpresora}  {serieImpresora}";
        }

        public string imprimir()
        {
            return "Imprimiendo";
        }

        public string apagar()
        {
            return $"Apagando la impresora  {codigoImpresora} {marcaImpresora} {modeloImpresora} {serieImpresora}";
        }
    }
}

