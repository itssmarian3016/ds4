using System;
using System.Windows.Forms;

namespace Lab12_2
{
    // Formulario para calcular el promedio de 3 notas
    public partial class FormMain : Form
    {
        private Label l1,l2,l3,lResult;
        private TextBox t1,t2,t3;
        private Button btnCalc;

        public FormMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            l1 = new Label() { Text = "Nota 1:", Location = new System.Drawing.Point(20,20) };
            t1 = new TextBox() { Location = new System.Drawing.Point(100,18), Width = 80 };
            l2 = new Label() { Text = "Nota 2:", Location = new System.Drawing.Point(20,60) };
            t2 = new TextBox() { Location = new System.Drawing.Point(100,58), Width = 80 };
            l3 = new Label() { Text = "Nota 3:", Location = new System.Drawing.Point(20,100) };
            t3 = new TextBox() { Location = new System.Drawing.Point(100,98), Width = 80 };
            btnCalc = new Button() { Text = "Calcular promedio", Location = new System.Drawing.Point(20,140) };
            lResult = new Label() { Text = "Promedio:", Location = new System.Drawing.Point(20,180), AutoSize = true };
            btnCalc.Click += BtnCalc_Click;

            this.ClientSize = new System.Drawing.Size(320,230);
            this.Controls.AddRange(new Control[] { l1,t1,l2,t2,l3,t3,btnCalc,lResult });
            this.Text = "Lab12_2 - Promedio";
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if (double.TryParse(t1.Text, out double n1) && double.TryParse(t2.Text, out double n2) && double.TryParse(t3.Text, out double n3))
            {
                double prom = Calculadora.Promedio(n1,n2,n3);
                lResult.Text = $"Promedio: {prom:N2}";
            }
            else
            {
                MessageBox.Show("Ingrese notas numéricas válidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
