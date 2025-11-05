using System;
namespace Laboratorio154
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void btnSumar_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtNum1.Text);
            double n2 = double.Parse(txtNum2.Text);
            double resultado = n1 + n2;
            lblResultado.Text = $"Resultado: {resultado}";
        }
    }
}
