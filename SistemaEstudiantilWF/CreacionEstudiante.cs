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
    public partial class CreacionEstudiante : Form
    {

        public CreacionEstudiante()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string matricula = txt_matricula.Text;
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            int edad = Convert.ToInt32(txt_edad.Text);
            char sexo = Convert.ToChar(cmb_sexo.SelectedItem);
            DateTime fechaNacimiento = dtp_fechanacimiento.Value;
            string curso = txt_curso.Text;
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
            cmd.Parameters.AddWithValue("@Curso", txt_curso.Text);
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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_matricula.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_edad.Text = "";
            cmb_sexo.Text = "";
            dtp_fechanacimiento.Value = DateTime.Today;
            txt_curso.Text = "";
            txt_usuarioid.Text = "";
            txt_cantidadmaterias.Text = "";
        }

        private void cmb_sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string actualizar = "UPDATE Estudiante SET Nombre=@Nombre, Apellidos=@Apellidos, Edad=@Edad, Sexo=@Sexo, FechaNacimiento=FechaNacimiento, Curso=@Curso, CantidadMateria=@CantidadMateria, UsuarioId=@UsuarioId where UsuarioId = @UsuarioId ";

            SqlCommand cmd = new SqlCommand(actualizar, Conexion.getinstance().getConexion());
            cmd.Parameters.AddWithValue("@Nombre", txt_nombre.Text);
            cmd.Parameters.AddWithValue("@Apellidos", txt_apellido.Text);
            cmd.Parameters.AddWithValue("@Edad", txt_edad.Text);
            cmd.Parameters.AddWithValue("@Sexo", cmb_sexo.Text);
            cmd.Parameters.AddWithValue("@FechaNacimiento", dtp_fechanacimiento.Value);
            cmd.Parameters.AddWithValue("@Curso", txt_curso.Text);
            cmd.Parameters.AddWithValue("@CantidadMateria", txt_cantidadmaterias.Text);
            cmd.Parameters.AddWithValue("@UsuarioId", txt_usuarioid.Text);


            try
            {
                cmd.ExecuteNonQuery();
                string consulta = "SELECT * FROM Estudiante";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, Conexion.getinstance().getConexion());
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Estudiante");
                dataGridView1.DataSource = dataSet.Tables["Estudiante"];

                MessageBox.Show("Estudiante actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string eliminar = "DELETE FROM Estudiante where Matricula = @Matricula ";

            SqlCommand cmd = new SqlCommand(eliminar, Conexion.getinstance().getConexion());
            cmd.Parameters.AddWithValue("@Matricula", txt_matricula.Text);


            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Estudiante eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            string columna = cmb_buscar.Text;
            string valor = txt_buscar.Text;

            string buscar = "SELECT * FROM Estudiante WHERE " + columna + " LIKE @Valor";
            SqlCommand command = new SqlCommand(buscar, Conexion.getinstance().getConexion());
            command.Parameters.AddWithValue("@Valor", "%" + valor + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Estudiante");
            dataGridView1.DataSource = dataSet.Tables["Estudiante"];


        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM Estudiante";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, Conexion.getinstance().getConexion());
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Estudiante");
            dataGridView1.DataSource = dataSet.Tables["Estudiante"];
        }
    }
}
