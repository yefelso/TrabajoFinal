using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Tienda_Yefell
{
    /// <summary>
    /// Lógica de interacción para RegistroAdmin.xaml
    /// </summary>
    public partial class RegistroAdmin : Window
    {
        private const string connectionString = "Data Source=(localdb)\\yefelson;Initial Catalog=Venta;Integrated Security=True;User ID=sa;Password=12345";
        public RegistroAdmin()
        {
            InitializeComponent();
        }

        private void Registrar_Click(object sender, RoutedEventArgs e)
        {
            string nombre = Nombre.Text;
            string correo = Correo.Text;
            string contraseña = Contraseña.Text;

            if (!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(correo) && !string.IsNullOrWhiteSpace(contraseña))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "INSERT INTO Administrador (Nombre, Correo, Contraseña) VALUES (@Nombre, @Correo, @Contraseña)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.Parameters.AddWithValue("@Contraseña", contraseña);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Administrador registrado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar el administrador.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");

            }
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            LoginAdmin LoadminWindow = new LoginAdmin();
            LoadminWindow.Show();
        }
    }
}
