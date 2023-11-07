using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Formulario_de_empleado
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Empleado> empleados = new List<Empleado>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void direccion_GotFocus(object sender, RoutedEventArgs e)
        {
            if (direccion.Focus() && direccion.Text == "Dirección")
            {
                direccion.Text = "";
            }
        }

        private void direccion_LostFocus(object sender, RoutedEventArgs e)
        {
            if (direccion.Text == "")
            {
                direccion.Text = "Dirección";
            }
        }

        private void ciudad_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ciudad.Focus() && ciudad.Text == "Ciudad")
            {
                ciudad.Text = "";
            }
        }

        private void ciudad_LostFocus(object sender, RoutedEventArgs e)
        {
            if (ciudad.Text == "")
            {
                ciudad.Text = "Ciudad";
            }
        }

        private void provincia_GotFocus(object sender, RoutedEventArgs e)
        {
            if (provincia.Focus() && provincia.Text == "Provincia")
            {
                provincia.Text = "";
            }
        }

        private void provincia_LostFocus(object sender, RoutedEventArgs e)
        {
            if (provincia.Text == "")
            {
                provincia.Text = "Provincia";
            }
        }

        private void cp_GotFocus(object sender, RoutedEventArgs e)
        {
            if (cp.Focus() && cp.Text == "Código Postal")
            {
                cp.Text = "";
            }
        }

        private void cp_LostFocus(object sender, RoutedEventArgs e)
        {
            if (cp.Text == "")
            {
                cp.Text = "Código Postal";
            }
        }

        private void pais_GotFocus(object sender, RoutedEventArgs e)
        {
            if (pais.Focus() && pais.Text == "País")
            {
                pais.Text = "";
            }
        }

        private void pais_LostFocus(object sender, RoutedEventArgs e)
        {
            if (pais.Text == "")
            {
                pais.Text = "País";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files| *.jpg; *.jpeg; *.png;";
            ofd.ShowDialog();
            BitmapImage bitmap = new BitmapImage(new Uri(ofd.FileName));
            imagenPreview.Source = bitmap;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (nombre.Text == "" || apellidos.Text == "" || mail.Text == "" || telefono.Text == "")
            {
                MessageBox.Show("Debes introducir los datos obligatorios");
            }
            else
            {
                Empleado empleado = new Empleado() { Nombre = nombre.Text, Apellidos = apellidos.Text, Email = mail.Text, Telefono = telefono.Text };
                empleados.Add(empleado);
                dgEmpleados.ItemsSource = null;
                dgEmpleados.ItemsSource = empleados;
            }


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }
    }
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
