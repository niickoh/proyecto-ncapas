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

namespace RegistroFarmacia.Vista.Eliminar
{
    /// <summary>
    /// Lógica de interacción para eliminarMedicamento.xaml
    /// </summary>
    public partial class eliminarMedicamento : Window
    {
        public eliminarMedicamento()
        {
            InitializeComponent();
            cmbSerieEliminar.ItemsSource = Negocio.Medicamento_Negocio.obtenerListaMedicamentos();
            cmbSerieEliminar.DisplayMemberPath = "serie";
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            
            Negocio.Medicamento_Negocio medicamento_eliminar = new Negocio.Medicamento_Negocio();
            Entidades.medicamento eliminMedicamento = new Entidades.medicamento();
            eliminMedicamento.serie = int.Parse(cmbSerieEliminar.Text);
            
            MessageBoxResult resultadoEliminar = MessageBox.Show("¿Está seguro de eliminar medicamento?", "¡Cuidado!", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (resultadoEliminar.Equals(MessageBoxResult.Yes))
                if(medicamento_eliminar.EliminarMedicamento(eliminMedicamento))
                    MessageBox.Show("¡Medicamento eliminado con exito!", "¡Hecho!", MessageBoxButton.OK, MessageBoxImage.Information);
                if(resultadoEliminar.Equals(MessageBoxResult.No))
                    MessageBox.Show("Medicamento no eliminado" , "¡Adventencia!", MessageBoxButton.OK, MessageBoxImage.Error);
            Close();

            
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
