using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Diagnostics.Metrics;

namespace SistemaEstudiantilWF
{
   class Conexion
    {
        private static Conexion instance = new Conexion();
        private SqlConnection conexion;
        private Conexion()
        {
            //conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=SistemaEstudiantil;Trusted_Connection=True;TrustServerCertificate=True;");
            conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=SistemaEstudiantil;Trusted_Connection=True;TrustServerCertificate=True;");
            conexion.Open();
        }
        public static Conexion getinstance()
        {

            return instance;
        }

        public SqlConnection getConexion() 
        {
        
            return conexion;
        }
    }
}
