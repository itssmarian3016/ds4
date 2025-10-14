using System;
using System.Windows.Forms;

namespace Lab11_1
{
    // Programa principal para abrir el formulario del laboratorio.
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Abrir el formulario principal del lab 11 (ejercicio 1)
            Application.Run(new Form1());
        }
    }
}
