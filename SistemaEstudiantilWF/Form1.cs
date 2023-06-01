using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
        string CadenaConexion = null;
        private readonly IHost host;

        private void Ejecutar() 
        {
            try 
            {
                var Configuracion = host.Services.GetService<IConfiguration>();
                CadenaConexion = Configuracion?.GetValue<string>("cadenaConexion")!;
            }
            catch (Exception err) 
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}