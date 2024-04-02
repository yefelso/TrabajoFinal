﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tienda_Yefell
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RegistrarCliente RegistroWindow = new RegistrarCliente();
            RegistroWindow.Show();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            LoginUsuario LoginWindow = new LoginUsuario();
            LoginWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LoginAdmin LoadminWindow = new LoginAdmin();
            LoadminWindow.Show();
        }
    }
}