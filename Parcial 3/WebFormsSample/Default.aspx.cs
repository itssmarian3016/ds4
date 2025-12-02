using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    string cs = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack) { BindGrid(); }
    }

    private void BindGrid()
    {
        using(SqlConnection con = new SqlConnection(cs))
        {
            string query = @"SELECT c.CasoID, c.Titulo, e.NombreEstado, a.Nombre AS Abogado, cl.Nombre AS Cliente, c.FechaVencimiento
                             FROM MG_Casos c
                             LEFT JOIN MG_Estados e ON c.EstadoID = e.EstadoID
                             LEFT JOIN MG_Abogados a ON c.AbogadoID = a.AbogadoID
                             LEFT JOIN MG_Clientes cl ON c.ClienteID = cl.ClienteID";
            using(SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
    }
}