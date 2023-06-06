using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstudiantilWF
{
    public partial class Asignaturas : Form
    {
        public Asignaturas()
        {
            InitializeComponent();
        }
        public class Asignatura
        {
            public int IdAsignatura { get; set; }
            public string Nombre { get; set; }

            public Asignatura(int idAsignatura, string nombre)
            {
                IdAsignatura = idAsignatura;
                Nombre = nombre;
            }

        }
        private void cmb_asignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Asignaturas_Load(object sender, EventArgs e)
        {
            List<Asignatura> listaAsignaturas = new List<Asignatura>();

            string consulta = "SELECT IdAsignatura, Nombre FROM Asignatura";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.getinstance().getConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int idAsignatura = reader.GetInt32(0);
                string nombreAsignatura = reader.GetString(1);

                // Agregar la asignatura al ComboBox o ListBox
                cmb_asignaturas.Items.Add(new KeyValuePair<int, string>(idAsignatura, nombreAsignatura));
            }

            reader.Close();

        }


        private void btn_asignar_Click(object sender, EventArgs e)
        {
            string matriculaEstudiante = txt_matriculaestudiante.Text;

            // Verificar si la matrícula existe en la tabla Estudiante
            string verificarMatriculaQuery = "SELECT Id FROM Estudiante WHERE Matricula = @Matricula";
            SqlCommand cmdVerificarMatricula = new SqlCommand(verificarMatriculaQuery, Conexion.getinstance().getConexion());
            cmdVerificarMatricula.Parameters.AddWithValue("@Matricula", matriculaEstudiante);
            object result = cmdVerificarMatricula.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int idEstudiante))
            {
                // Obtener las asignaturas desde la base de datos
                List<Asignatura> asignaturas = new List<Asignatura>();

                string obtenerAsignaturasQuery = "SELECT IdAsignatura, Nombre FROM Asignatura";
                SqlCommand cmdObtenerAsignaturas = new SqlCommand(obtenerAsignaturasQuery, Conexion.getinstance().getConexion());
                SqlDataReader reader = cmdObtenerAsignaturas.ExecuteReader();

                while (reader.Read())
                {
                    int idAsignatura = reader.GetInt32(0);
                    string nombreAsignatura = reader.GetString(1);
                    Asignatura asignatura = new Asignatura(idAsignatura, nombreAsignatura);
                    asignaturas.Add(asignatura);
                }

                reader.Close();

                if (asignaturas.Count > 0)
                {
                    // Insertar las asignaturas en la tabla AsignaturaEstudiante
                    foreach (Asignatura asignatura in asignaturas)
                    {
                        string insertar = "INSERT INTO AsignaturaEstudiante (IdEstudiante, IdAsignatura, Calificacion) VALUES (@IdEstudiante, @IdAsignatura, 0)";
                        SqlCommand cmd = new SqlCommand(insertar, Conexion.getinstance().getConexion());
                        cmd.Parameters.AddWithValue("@IdEstudiante", idEstudiante);
                        cmd.Parameters.AddWithValue("@IdAsignatura", asignatura.IdAsignatura);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Asignaturas asignadas correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontraron asignaturas.");
                }
            }
            else
            {
                MessageBox.Show("La matrícula proporcionada no existe en la tabla Estudiante.");
            }



        }
    }
}
