using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstudiantilWF
{
    internal class Crud
    {
        private SqlConnection conexion;
        public Crud(string CadenaConexion) 
        {
            conexion.Open();
        }
        internal List<Estudiante> ReporteEstudiantesFemeninos() 
        {
            try 
            {
                string consulta = $"Select * from Estudiante where Sexo = F ";
                using (SqlCommand command = new SqlCommand(consulta, conexion)) 
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dat = new DataTable();
                    adapter.Fill(dat);

                    var estudiantes = dat.AsEnumerable()
                        .Select(fila => new Estudiante
                        {
                            Id = fila.Field<int>("Id"),
                            Matricula = fila.Field<char>("Matricula")!,
                            Nombre = fila.Field<char>("Nombre")!,
                            Apellidos = fila.Field<char>("Apellido")!,
                            Edad = fila.Field<int>("Edad")!,
                            Sexo = fila.Field<char>("Sexo")!,
                            FechaNacimiento = fila.Field<DateTime>("FechaNacimiento")!,
                            CantidadMateria = fila.Field<int>("CantidadMateria")!,
                            UsuarioId = fila.Field<char>("UsuarioId")!,
                        }).ToList();
                    return estudiantes;
                }
            }
            catch (SqlException err) 
            {
                MessageBox.Show(err.Message);
            }
            return null;
     
        }
        ~Crud(){
            conexion.Close();
        }


       
        internal List<Estudiante> ReporteEstudiantesMasculinos()
        {
            try
            {
                string consulta = $"Select * from Estudiante where Sexo = V ";
                using (SqlCommand command = new SqlCommand(consulta, conexion))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dat = new DataTable();
                    adapter.Fill(dat);

                    var estudiantes = dat.AsEnumerable()
                        .Select(fila => new Estudiante
                        {
                            Id = fila.Field<int>("Id"),
                            Matricula = fila.Field<char>("Matricula")!,
                            Nombre = fila.Field<char>("Nombre")!,
                            Apellidos = fila.Field<char>("Apellido")!,
                            Edad = fila.Field<int>("Edad")!,
                            Sexo = fila.Field<char>("Sexo")!,
                            FechaNacimiento = fila.Field<DateTime>("FechaNacimiento")!,
                            CantidadMateria = fila.Field<int>("CantidadMateria")!,
                            UsuarioId = fila.Field<char>("UsuarioId")!,
                        }).ToList();
                    return estudiantes;
                }
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
            return null;

        }
        ~Crud()
        {
            conexion.Close();
        }
    }
}
