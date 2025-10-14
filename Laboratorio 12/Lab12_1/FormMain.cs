using System;
using System.Windows.Forms;

namespace Lab12_1
{
    // Formulario para calcular distancia = velocidad * tiempo
    public partial class FormMain : Form
    {
        private Label lblVel, lblTime, lblResult;
        private TextBox txtVel, txtTime;
        private Button btnCalc;

        public FormMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblVel = new Label() { Text = "Velocidad (m/s):", Location = new System.Drawing.Point(20,20) };
            txtVel = new TextBox() { Location = new System.Drawing.Point(140,18), Width = 100 };
            lblTime = new Label() { Text = "Tiempo (s):", Location = new System.Drawing.Point(20,60) };
            txtTime = new TextBox() { Location = new System.Drawing.Point(140,58), Width = 100 };
            btnCalc = new Button() { Text = "Calcular distancia", Location = new System.Drawing.Point(20,100) };
            lblResult = new Label() { Text = "Distancia:", Location = new System.Drawing.Point(20,140), AutoSize = true };
            btnCalc.Click += BtnCalc_Click;

            this.ClientSize = new System.Drawing.Size(340,200);
            this.Controls.AddRange(new Control[] { lblVel, txtVel, lblTime, txtTime, btnCalc, lblResult });
            this.Text = "Lab12_1 - Distancia";
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            // Comentario estudiante: Validamos la entrada con TryParse para evitar errores
            if (double.TryParse(txtVel.Text, out double vel) && double.TryParse(txtTime.Text, out double tiempo))
            {
                double d = Calculadora.CalcularDistancia(vel, tiempo);
                lblResult.Text = $"Distancia recorrida: {d:N4} unidades";
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos para velocidad y tiempo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
