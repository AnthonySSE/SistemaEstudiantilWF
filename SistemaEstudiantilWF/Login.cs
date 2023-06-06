using Microsoft.Data.SqlClient;
using ModernGUI_V3;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstudiantilWF
{
    internal class Login
    {
        private SqlConnection conexion;

        public Login(string cadenaConexion)
        {
            conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
        }
        
        internal void Acceder (string IdUsuario, string Contrasena)
        {

            try
            {
                string consulta = $"select * from Usuario where idusuario = '{IdUsuario}' and Contrasena = '{Contrasena}'";
                SqlDataAdapter sda = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                sda.Fill (dt);

                if (dt.Rows.Count > 0)
                {
                   /* IdUsuario = IdUsuario;
                    Contrasena = Contrasena;*/

                    MessageBox.Show("Logueo exitoso");

                   
                }

                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos. Intentelo de nuevo.");
                    
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Usuario o contraseña incorrectos. Intentelo de nuevo");
            }
        }
        ~Login()
        {
            conexion.Close();
        }
    }
}
