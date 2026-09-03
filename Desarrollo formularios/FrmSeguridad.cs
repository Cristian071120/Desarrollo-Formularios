using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desarrollo_formularios
{
    public partial class FrmSeguridad : Form
    {
        public FrmSeguridad()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            string Usuario, Contraseña;

            Usuario = txtUsuario.Text;
            Contraseña = txtContrasena.Text;

            SqlConnection connection;
            string connectionString = "Data Source= B6-501-23;Initial Catalog=MiBaseDatos;Integrated Security=True;Encrypt=False;";
            string query = "SELECT * FROM Usuarios";

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand cmd = new SqlCommand("insert into Usuarios(Usuario, Contraseña) VALUES(@Usuario, @Contraseña)", connection);
                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", Contraseña);

                cmd.ExecuteNonQuery();

                // SqlDataAdapter es útil para llenar DataSets o DataTables
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable usuariosTable = new DataTable();
                    adapter.Fill(usuariosTable);

                    // Asignar el DataTable como origen de datos del DataGridView
                    dgvUsuarios.DataSource = usuariosTable;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al insertar datos: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Usuario, Contraseña;

            Usuario = txtUsuario.Text;
            Contraseña = txtContrasena.Text;

            string connectionString = "Data Source= B6-501-23;Initial Catalog=MiBaseDatos;Integrated Security=True;Encrypt=False;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Usuarios WHERE Usuario = @Usuario";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", Usuario);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos eliminados correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el registro para eliminar.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al eliminar datos: " + ex.Message);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string Usuario, Contraseña;

            Usuario = txtUsuario.Text;
            Contraseña = txtContrasena.Text;

            string connectionString = "Data Source= B6-501-23;Initial Catalog=MiBaseDatos;Integrated Security=True;Encrypt=False;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Usuarios SET Usuario = @Usuario, Contraseña = @Contraseña WHERE Usuario = @Usuario";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", Usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", Contraseña);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos actualizados correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el registro para actualizar.");
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al actualizar datos: " + ex.Message);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=B6-501-23;Initial Catalog=MiBaseDatos;Integrated Security=True;Encrypt=False;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Usuarios";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable resultadoTable = new DataTable();
                        adapter.Fill(resultadoTable);
                        dgvUsuarios.DataSource = resultadoTable;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al buscar datos: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


