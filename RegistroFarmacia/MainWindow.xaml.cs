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


namespace RegistroFarmacia
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lblMostrar_Click(object sender, RoutedEventArgs e)
        {
            Vista.Mostrar.MostrarMedicamento ventanaMostrar = new Vista.Mostrar.MostrarMedicamento();
            ventanaMostrar.ShowDialog();
        }

        private void btnRegistro_Click(object sender, RoutedEventArgs e)
        {
            RegistroFarmacia.Vista.Medicamento.AgregarMedicamento ventanaAgregar = new RegistroFarmacia.Vista.Medicamento.AgregarMedicamento();
            ventanaAgregar.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultadoSalir = MessageBox.Show("¿Está seguro de salir del programa?", "¡Advertencia!", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (resultadoSalir.Equals(MessageBoxResult.Yes))
                this.Close();
            
        }

        private void ColorZone_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            if(WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
                Size.Empty.Width.Equals(WindowState);
                Size.Empty.Height.Equals(WindowState);
            }
            else if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
                Size.Empty.Width.Equals(WindowState);
                Size.Empty.Height.Equals(WindowState);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if(WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Minimized;
            }
            else if(WindowState == WindowState.Minimized)
            {
                WindowState = WindowState.Normal;
            }
        }
    }
}
