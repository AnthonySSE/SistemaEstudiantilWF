using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ModernGUI_V3;
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

        private void btnAcceder_Click(object sender, EventArgs e)
        {
           

            string username = txtIdUsuario.Text;
            string password = txtContrasena.Text;

            // Verificar las credenciales en la base de datos
            string verificarCredencialesQuery = "SELECT COUNT(*) FROM Usuario WHERE IdUsuario = @Username AND Contrasena = @Password";
            SqlCommand cmdVerificarCredenciales = new SqlCommand(verificarCredencialesQuery, Conexion.getinstance().getConexion());
            cmdVerificarCredenciales.Parameters.AddWithValue("@Username", username);
            cmdVerificarCredenciales.Parameters.AddWithValue("@Password", password);
            int count = Convert.ToInt32(cmdVerificarCredenciales.ExecuteScalar());

            if (count > 0)
            {
                // Las credenciales son válidas, mostrar el formulario principal o realizar otras operaciones necesarias
                MessageBox.Show("Inicio de sesión exitoso","Inicio de sesión", MessageBoxButtons.OK,MessageBoxIcon.Information);
                // abrir el formulario principal
                FormPrincipal frm = new FormPrincipal();
                this.Hide();
                frm.Show();
            }
            else
            {
                // Las credenciales son inválidas, mostrar un mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

     
    }
}