
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab13_1
{
    // Comentarios estilo estudiante:
    // Este laboratorio nos enseña a conectar Visual Studio con SQL Server
    // y a mostrar datos de la base de datos Northwind en un ListBox.
    public partial class Form1 : Form
    {
        string connectionString = @"Server=.\\SQLEXPRESS;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";

        private Button btnConectar;
        private Button btnListar;
        private ListBox lstProductos;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnConectar = new Button();
            this.btnListar = new Button();
            this.lstProductos = new ListBox();
            this.SuspendLayout();

            this.btnConectar.Text = "Probar conexión";
            this.btnConectar.Location = new System.Drawing.Point(20, 20);
            this.btnConectar.Click += BtnConectar_Click;

            this.btnListar.Text = "Listar Productos";
            this.btnListar.Location = new System.Drawing.Point(200, 20);
            this.btnListar.Click += BtnListar_Click;

            this.lstProductos.Location = new System.Drawing.Point(20, 70);
            this.lstProductos.Size = new System.Drawing.Size(330, 200);

            this.ClientSize = new System.Drawing.Size(380, 300);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lstProductos);
            this.Text = "Laboratorio 13 - Conexión SQL";
            this.ResumeLayout(false);
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(connectionString);
                conexion.Open();
                MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos.");
                conexion.Close();
                MessageBox.Show("Se cerró la conexión.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            lstProductos.Items.Clear();
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    string query = "SELECT ProductName FROM [dbo].[Products]";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lstProductos.Items.Add(reader["ProductName"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar productos: " + ex.Message);
            }
        }
    }
}
