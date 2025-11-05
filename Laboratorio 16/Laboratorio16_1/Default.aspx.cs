using System;
namespace Laboratorio161
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void btnMensaje_Click(object sender, EventArgs e)
        {
            string mensaje = "¡Bienvenido al Laboratorio 16-1 de ASP.NET WebForms!";
            Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "alert", $"alert('{mensaje}');", true);
        }
    }
}
