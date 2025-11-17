using System;
using System.Web.UI;

public partial class WebForm1 : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Si necesita cambiar el parámetro por código:
        // SqlDataSourceSP.SelectParameters["CategoryID"].DefaultValue = "2";
    }
}
