using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaEstudiantilWF.Asignaturas;

namespace SistemaEstudiantilWF
{
    public partial class Calificaciones : Form
    {
        public class AsignaturaCalificacion
        {
            public int IdAsignatura { get; set; }
            public decimal Calificacion { get; set; }


        }
        public Calificaciones()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string matriculaEstudiante = txt_Matricula.Text;

            // Verificar si la matrícula existe en la tabla Estudiante
            string verificarMatriculaQuery = "SELECT Id FROM Estudiante WHERE Matricula = @Matricula";
            SqlCommand cmdVerificarMatricula = new SqlCommand(verificarMatriculaQuery, Conexion.getinstance().getConexion());
            cmdVerificarMatricula.Parameters.AddWithValue("@Matricula", matriculaEstudiante);
            object result = cmdVerificarMatricula.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int idEstudiante))
            {
                // Obtener las asignaturas del estudiante desde la base de datos
                List<Asignatura> asignaturas = ObtenerAsignaturasEstudiante(idEstudiante);

                if (asignaturas.Count > 0)
                {
                    // Mostrar las asignaturas en el DataGridView
                    dgvCalificaciones.DataSource = asignaturas;
                }
                else
                {
                    MessageBox.Show("El estudiante no tiene asignaturas.");
                }
            }
            else
            {
                MessageBox.Show("La matrícula proporcionada no existe en la tabla Estudiante.");
            }
        }
        private List<Asignatura> ObtenerAsignaturasEstudiante(int idEstudiante)
        {
            List<Asignatura> asignaturas = new List<Asignatura>();

            string obtenerAsignaturasQuery = "SELECT A.IdAsignatura, A.Nombre FROM Asignatura A " +
                                             "INNER JOIN AsignaturaEstudiante AE ON A.IdAsignatura = AE.IdAsignatura " +
                                             "WHERE AE.IdEstudiante = @IdEstudiante";

            SqlCommand cmdObtenerAsignaturas = new SqlCommand(obtenerAsignaturasQuery, Conexion.getinstance().getConexion());
            cmdObtenerAsignaturas.Parameters.AddWithValue("@IdEstudiante", idEstudiante);
            SqlDataReader reader = cmdObtenerAsignaturas.ExecuteReader();

            while (reader.Read())
            {
                int idAsignatura = reader.GetInt32(0);
                string nombreAsignatura = reader.GetString(1);
                Asignatura asignatura = new Asignatura(idAsignatura, nombreAsignatura);
                asignaturas.Add(asignatura);
            }

            reader.Close();

            return asignaturas;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string matriculaEstudiante = txt_Matricula.Text;

                // Verificar si la matrícula existe en la tabla Estudiante
                string verificarMatriculaQuery = "SELECT Id FROM Estudiante WHERE Matricula = @Matricula";
                SqlCommand cmdVerificarMatricula = new SqlCommand(verificarMatriculaQuery, Conexion.getinstance().getConexion());
                cmdVerificarMatricula.Parameters.AddWithValue("@Matricula", matriculaEstudiante);
                object result = cmdVerificarMatricula.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int idEstudiante))
                {
                    // Guardar las calificaciones en la tabla AsignaturaEstudiante
                    foreach (Control control in Controls)
                    {
                        if (control is TextBox textBox && !string.IsNullOrEmpty(textBox.Text))
                        {
                            string nombreAsignatura = textBox.Name.Replace("txt", "");

                            // Obtener el IdAsignatura correspondiente al nombre de la asignatura
                            string obtenerIdAsignaturaQuery = "SELECT IdAsignatura FROM Asignatura WHERE Nombre = @Nombre";
                            SqlCommand cmdObtenerIdAsignatura = new SqlCommand(obtenerIdAsignaturaQuery, Conexion.getinstance().getConexion());
                            cmdObtenerIdAsignatura.Parameters.AddWithValue("@Nombre", nombreAsignatura);
                            object idAsignaturaResult = cmdObtenerIdAsignatura.ExecuteScalar();

                            if (idAsignaturaResult != null && int.TryParse(idAsignaturaResult.ToString(), out int idAsignatura))
                            {
                                if (double.TryParse(textBox.Text, out double calificacion))
                                {
                                    // Insertar la calificación en la tabla AsignaturaEstudiante
                                    string insertarCalificacionQuery = "INSERT INTO AsignaturaEstudiante (IdEstudiante, IdAsignatura, Calificacion) VALUES (@IdEstudiante, @IdAsignatura, @Calificacion)";
                                    SqlCommand cmdInsertarCalificacion = new SqlCommand(insertarCalificacionQuery, Conexion.getinstance().getConexion());
                                    cmdInsertarCalificacion.Parameters.AddWithValue("@IdEstudiante", idEstudiante);
                                    cmdInsertarCalificacion.Parameters.AddWithValue("@IdAsignatura", idAsignatura);
                                    cmdInsertarCalificacion.Parameters.AddWithValue("@Calificacion", calificacion);
                                    cmdInsertarCalificacion.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    MessageBox.Show("Calificaciones guardadas correctamente.");
                }
                else
                {
                    MessageBox.Show("La matrícula proporcionada no existe en la tabla Estudiante.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar las calificaciones: " + ex.Message);
            }

        }

        private void txt_calificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calificaciones_Load(object sender, EventArgs e)
        {

        }
    }
}

