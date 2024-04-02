using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Tienda_Yefell
{
    /// <summary>
    /// Lógica de interacción para LoginAdmin.xaml
    /// </summary>
    public partial class LoginAdmin : Window
    {
        private const string connectionString = "Data Source=(localdb)\\yefelson;Initial Catalog=Venta;Integrated Security=True;User ID=sa;Password=12345";
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string correo = Correo.Text;
            string contraseña = Contraseña.Text;

            if (!string.IsNullOrWhiteSpace(correo) && !string.IsNullOrWhiteSpace(contraseña))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "SELECT COUNT(*) FROM Administrador WHERE Correo = @Correo AND Contraseña = @Contraseña";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.Parameters.AddWithValue("@Contraseña", contraseña);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Inicio de sesión exitoso.");
                            // Aquí puedes abrir la ventana principal o realizar otras operaciones después del inicio de sesión exitoso
                        }
                        else
                        {
                            MessageBox.Show("Correo o contraseña incorrectos.");
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

        private void Registrar_Click(object sender, RoutedEventArgs e)
        {
            RegistroAdmin ReadminWindow = new RegistroAdmin();
            ReadminWindow.Show();
        }
    }
}
