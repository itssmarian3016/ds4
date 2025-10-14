using System;
using System.Windows.Forms;

namespace Lab12_3
{
    // Formulario para calcular semiperímetro y área (Herón) de un triángulo
    public partial class FormMain : Form
    {
        private Label la,lb,lc,lSemi,lArea;
        private TextBox ta,tb,tc;
        private Button btnCalc;

        public FormMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            la = new Label() { Text = "Lado a:", Location = new System.Drawing.Point(20,20) };
            ta = new TextBox() { Location = new System.Drawing.Point(100,18) };
            lb = new Label() { Text = "Lado b:", Location = new System.Drawing.Point(20,60) };
            tb = new TextBox() { Location = new System.Drawing.Point(100,58) };
            lc = new Label() { Text = "Lado c:", Location = new System.Drawing.Point(20,100) };
            tc = new TextBox() { Location = new System.Drawing.Point(100,98) };
            btnCalc = new Button() { Text = "Calcular semiperímetro y área", Location = new System.Drawing.Point(20,140) };
            lSemi = new Label() { Text = "Semiperímetro:", Location = new System.Drawing.Point(20,180), AutoSize = true };
            lArea = new Label() { Text = "Área:", Location = new System.Drawing.Point(20,210), AutoSize = true };
            btnCalc.Click += BtnCalc_Click;

            this.ClientSize = new System.Drawing.Size(380,260);
            this.Controls.AddRange(new Control[] { la,ta,lb,tb,lc,tc,btnCalc,lSemi,lArea });
            this.Text = "Lab12_3 - Triángulo";
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if (double.TryParse(ta.Text, out double a) && double.TryParse(tb.Text, out double b) && double.TryParse(tc.Text, out double c))
            {
                if (!Calculadora.EsTrianguloValido(a,b,c))
                {
                    MessageBox.Show("Los lados no forman un triángulo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                double s = Calculadora.Semiperimetro(a,b,c);
                double area = Calculadora.AreaTriangulo(a,b,c);
                lSemi.Text = $"Semiperímetro: {s:N4}";
                lArea.Text = $"Área (Herón): {area:N4}";
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos para los lados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
