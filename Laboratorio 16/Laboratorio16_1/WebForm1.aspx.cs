using System;
namespace Laboratorio161
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
