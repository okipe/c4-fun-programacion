using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases_Esquema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInstancia_Click(object sender, EventArgs e)
        {
            // Creamos un objeto `imp`, a través del cual accederemos desde el formulario a la clase impresora.
            Impresora imp = new Impresora();
            MessageBox.Show(imp.encender());
            MessageBox.Show(imp.imprimir());
            MessageBox.Show(imp.apagar());
        }
    }
}
