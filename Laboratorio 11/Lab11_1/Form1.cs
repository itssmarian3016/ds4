using System;
using System.Windows.Forms;

// Comentarios al estilo estudiante:
// Autor: Estudiante (comentarios sencillos y explicativos)
// Descripción: Formulario simple que muestra "Hello World!" al presionar un botón.
// Este código está escrito para entregar como laboratorio, con comentarios que explican
// lo que hace cada parte básica.
namespace Lab11_1
{
    public partial class Form1 : Form
    {
        private Button btnClick;
        private Label lblMessage;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnClick = new Button();
            this.lblMessage = new Label();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(25, 20);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(120, 35);
            this.btnClick.Text = "Presióname";
            this.btnClick.Click += new EventHandler(this.BtnClick_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(25, 70);
            this.lblMessage.AutoSize = true;
            this.lblMessage.Text = "Aquí aparecerá el mensaje";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(320, 140);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lblMessage);
            this.Text = "Lab11_1 - Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            // Al presionar el botón se cambia el texto de la etiqueta
            lblMessage.Text = "Hello World!";
        }
    }
}
