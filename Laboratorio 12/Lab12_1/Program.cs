using System;
using System.Windows.Forms;

namespace Lab12_1
{
    // Program.cs para abrir el formulario principal de cada ejercicio del Lab12.
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Ejecuta el formulario correspondiente al ejercicio
            Application.Run(new FormMain());
        }
    }
}
