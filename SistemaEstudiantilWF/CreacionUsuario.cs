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
    public partial class CreacionUsuario : Form
    {
        public CreacionUsuario()
        {
            InitializeComponent();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";  
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_IdUsuario.Text = "";
            txt_contraseña.Text = "";
            cmb_rol.Items.Clear();

        }

        private void btn_crearusuario_Click(object sender, EventArgs e)
        {
            
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            string idusuario = txt_IdUsuario.Text;
            string contraseña = txt_contraseña.Text;
            string rol = cmb_rol.SelectedItem.ToString();
           



            string query = "INSERT INTO Usuario (Nombre, Apellidos, IdUsuario, Contrasena, Rol)" +
                "VALUES (@Nombre, @Apellidos, @IdUsuario, @Contrasena, @Rol)";
            SqlCommand cmd = new SqlCommand(query, Conexion.getinstance().getConexion());  

            cmd.Parameters.AddWithValue("@Nombre", txt_nombre.Text);
            cmd.Parameters.AddWithValue("@Apellidos", txt_apellido.Text);
            cmd.Parameters.AddWithValue("@IdUsuario",  txt_IdUsuario.Text);
            cmd.Parameters.AddWithValue("@Contrasena", txt_contraseña.Text);
            cmd.Parameters.AddWithValue("@Rol", cmb_rol.Text);
           

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuario creado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void CreacionUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eliminar = "DELETE FROM Usuario where Nombre= @Nombre ";

            SqlCommand cmd = new SqlCommand(eliminar, Conexion.getinstance().getConexion());
            cmd.Parameters.AddWithValue("@Nombre", txt_nombre.Text);


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
    }
}
