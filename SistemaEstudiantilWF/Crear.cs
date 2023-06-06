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
    public partial class Crear : Form
    {
        public Crear()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string matricula = txt_matricula.Text;
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            int edad = Convert.ToInt32(txt_edad.Text);
            char sexo = Convert.ToChar(cmb_sexo.SelectedItem);
            DateTime fechaNacimiento = dtp_fechanacimiento.Value;
            string grado = txt_grado.Text;
            int cantidadMateria = Convert.ToInt32(txt_cantidadmaterias.Text);
            string usuarioid = txt_usuarioid.Text;




            string insertar = "INSERT INTO Estudiante (Matricula, Nombre, Apellidos, Edad, Sexo, FechaNacimiento, Curso, CantidadMateria, UsuarioId)" +
                "VALUES (@Matricula, @Nombre, @Apellidos, @Edad, @Sexo, @FechaNacimiento, @Curso, @CantidadMateria, @UsuarioId)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion.getinstance().getConexion());
            cmd.Parameters.AddWithValue("@Matricula", txt_matricula.Text);
            cmd.Parameters.AddWithValue("@Nombre", txt_nombre.Text);
            cmd.Parameters.AddWithValue("@Apellidos", txt_apellido.Text);
            cmd.Parameters.AddWithValue("@Edad", txt_edad.Text);
            cmd.Parameters.AddWithValue("@Sexo", cmb_sexo.Text);
            cmd.Parameters.AddWithValue("@FechaNacimiento", dtp_fechanacimiento.Value);
            cmd.Parameters.AddWithValue("@Curso", txt_grado.Text);
            cmd.Parameters.AddWithValue("@CantidadMateria", txt_cantidadmaterias.Text);
            cmd.Parameters.AddWithValue("@UsuarioId", txt_usuarioid.Text);

            try
            {
                cmd.ExecuteNonQuery();


                MessageBox.Show("Estudiante creado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt_matricula.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_edad.Text = "";
            cmb_sexo.Text = "";
            dtp_fechanacimiento.Value = DateTime.Today;
            txt_grado.Text = "";
            txt_usuarioid.Text = "";
            txt_cantidadmaterias.Text = "";
        }
    }
}
