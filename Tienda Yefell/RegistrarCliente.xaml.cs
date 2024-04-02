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
    public partial class RegistrarCliente : Window
    {
        private const string connectionString = "Data Source=(localdb)\\yefelson;Initial Catalog=Venta;Integrated Security=True;User ID=sa;Password=12345";
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nombre = Name.Text;
            string usuario = Username.Text;
            string email = Email.Text;
            string password = Password.Text;
            string direccion = Direccion.Text;
            string dni = DNI.Text;

            string query = "INSERT INTO Clientes (Nombre, Nombre_Usuario, Email, Pasword, Direccion, DNI) " +
                           "VALUES (@Nombre, @Usuario, @Email, @Password, @Direccion, @DNI)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Direccion", direccion);
                command.Parameters.AddWithValue("@DNI", dni);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente registrado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar cliente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void Email_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LoginUsuario LoginWindow = new LoginUsuario();
            LoginWindow.Show();
        }
    }
    
}
