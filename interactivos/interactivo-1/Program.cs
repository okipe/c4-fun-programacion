using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases_Esquema

{
    class Constructor
    {
        int varable_1;
        string variable_2;

        public Constructor(int varable_1, string variable_2)
        {
            this.varable_1 = varable_1;
            this.variable_2 = variable_2;
        }
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
