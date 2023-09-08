using Mascotas;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInstancia1_Click(object sender, EventArgs e)
        {
            Perro Perrito = new Perro();
            Perrito.nombre = "Lazy";
            Perrito.color = "Blanco";
            Perrito.edad = 10;
            // Llamando a un método
            lblResultado.Text = Perrito.comer("carne");
        }

        private void btnInstancia2_Click(object sender, EventArgs e)
        {
            Perro Perrazo = new Perro();
            Perrazo.nombre = "Reyna";
            Perrazo.color = "Blanco";
            Perrazo.edad = 5;
            lblResultado.Text = Perrazo.comer("galleto");

        }
    }
}