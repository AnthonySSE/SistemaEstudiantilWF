using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Data;

namespace SistemaEstudiantilWF
{
    public partial class Form1 : Form
    {
        public Form1(IHost host)
        {
            this.host = host;
            Ejecutar();
            InitializeComponent();
        }

        string cadenaConexion = null!;
        private readonly IHost host;


        private void Ejecutar()
        {
            try
            {
                var Configuracion = host.Services.GetService<IConfiguration>();
                cadenaConexion = Configuracion?.GetValue<string>("cadenaConexion")!;

            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login(cadenaConexion);
            login.Acceder(txtIdUsuario.Text, txtContrasena.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}