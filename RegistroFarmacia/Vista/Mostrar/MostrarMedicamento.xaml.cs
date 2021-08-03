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

namespace RegistroFarmacia.Vista.Mostrar
{
    /// <summary>
    /// Lógica de interacción para MostrarMedicamento.xaml
    /// </summary>
    public partial class MostrarMedicamento : Window
    {
        public MostrarMedicamento()
        {
            InitializeComponent();
            this.dgMostrarMedicamento.ItemsSource = Negocio.Medicamento_Negocio.obtenerListaMedicamentos();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            Vista.Eliminar.eliminarMedicamento ventanaEliminar = new Vista.Eliminar.eliminarMedicamento();
            ventanaEliminar.ShowDialog();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            this.dgMostrarMedicamento.ItemsSource = Negocio.Medicamento_Negocio.obtenerListaMedicamentos();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void dgMostrarMedicamento_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
