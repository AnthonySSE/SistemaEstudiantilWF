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

namespace SistemaEstudiantilWF
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }


        private void btn_reporte1_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_reporte2_Click(object sender, EventArgs e)
        {
   
        }
        private void btn_reporte3_Click(object sender, EventArgs e)
        {
  
}

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string reporteEstudiantesMujeresQuery = "SELECT * FROM Estudiante WHERE Sexo = 'F'";
            SqlCommand cmdReporteEstudiantesMujeres = new SqlCommand(reporteEstudiantesMujeresQuery, Conexion.getinstance().getConexion());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdReporteEstudiantesMujeres);
            DataTable dataTableEstudiantesMujeres = new DataTable();
            dataAdapter.Fill(dataTableEstudiantesMujeres);

            // Mostrar los resultados en el DataGridView
            dataGridView1.DataSource = dataTableEstudiantesMujeres;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string reporteEstudiantesReprobadosQuery = "SELECT Estudiante.*, Asignatura.Nombre, AsignaturaEstudiante.Calificacion FROM Estudiante " +
      "INNER JOIN AsignaturaEstudiante ON Estudiante.Id = AsignaturaEstudiante.IdEstudiante " +
      "INNER JOIN Asignatura ON Asignatura.IdAsignatura = AsignaturaEstudiante.IdAsignatura " +
      "WHERE AsignaturaEstudiante.Calificacion < 60";
            SqlCommand cmdReporteEstudiantesReprobados = new SqlCommand(reporteEstudiantesReprobadosQuery, Conexion.getinstance().getConexion());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdReporteEstudiantesReprobados);
            DataTable dataTableEstudiantesReprobados = new DataTable();
            dataAdapter.Fill(dataTableEstudiantesReprobados);

            // Mostrar los resultados en el DataGridView
            dataGridView3.DataSource = dataTableEstudiantesReprobados;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string reporteEstudiantesAprobadosQuery = "SELECT Estudiante.*, Asignatura.Nombre, AsignaturaEstudiante.Calificacion FROM Estudiante " +
       "INNER JOIN AsignaturaEstudiante ON Estudiante.Id = AsignaturaEstudiante.IdEstudiante " +
       "INNER JOIN Asignatura ON Asignatura.IdAsignatura = AsignaturaEstudiante.IdAsignatura " +
       "WHERE AsignaturaEstudiante.Calificacion >= 60";
            SqlCommand cmdReporteEstudiantesAprobados = new SqlCommand(reporteEstudiantesAprobadosQuery, Conexion.getinstance().getConexion());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdReporteEstudiantesAprobados);
            DataTable dataTableEstudiantesAprobados = new DataTable();
            dataAdapter.Fill(dataTableEstudiantesAprobados);

            // Mostrar los resultados en el DataGridView
            dataGridView2.DataSource = dataTableEstudiantesAprobados;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string reporteEstudiantesMasculinoQuery = "SELECT * FROM Estudiante WHERE Sexo = 'M'";
            SqlCommand cmdReporteEstudiantesMasculino = new SqlCommand(reporteEstudiantesMasculinoQuery, Conexion.getinstance().getConexion());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdReporteEstudiantesMasculino);
            DataTable dataTableEstudiantesMasculino= new DataTable();
            dataAdapter.Fill(dataTableEstudiantesMasculino);

            // Mostrar los resultados en el DataGridView
            dataGridView4.DataSource = dataTableEstudiantesMasculino;
        }
    }
}
