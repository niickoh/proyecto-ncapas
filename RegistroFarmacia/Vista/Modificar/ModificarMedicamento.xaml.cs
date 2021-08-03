using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Diagnostics;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RegistroFarmacia.Vista.Modificar
{
    /// <summary>
    /// Lógica de interacción para ModificarMedicamento.xaml
    /// </summary>
    public partial class ModificarMedicamento : Window
    {
        public ModificarMedicamento()
        {
            InitializeComponent();
            cmbSerieModificar.ItemsSource = Negocio.Medicamento_Negocio.obtenerListaMedicamentos();
            cmbSerieModificar.DisplayMemberPath = "serie";
            cmbLaboratorioModificar.ItemsSource = Negocio.Laboratorio_Negocio.obtenerListaLaboratorio();
            cmbLaboratorioModificar.DisplayMemberPath = "nombre";
            cmbLaboratorioModificar.SelectedValuePath = "Id";
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            Negocio.Medicamento_Negocio medicamento_modificar = new Negocio.Medicamento_Negocio();
            string nombre = this.txtNombreModificar.Text;
            string principioActivo = this.txtActivoModificar.Text;
            string dosis = this.txtDosisModificar.Text;
            int laboratorio = int.Parse(this.cmbLaboratorioModificar.SelectedValue.ToString());
            DateTime fechaElaboracion = this.dpElaboracionModificar.SelectedDate.Value;
            DateTime fechaVencimiento = this.dpVencimientoModficar.SelectedDate.Value;
            string componentes = this.txtComponentesModificar.Text;

            Entidades.medicamento modificarMedicamento = new Entidades.medicamento();
            modificarMedicamento.nombre = nombre;
            modificarMedicamento.principioActivo = principioActivo;
            modificarMedicamento.dosis = dosis;
            modificarMedicamento.laboratorio = laboratorio;
            modificarMedicamento.fechaElaboracion = fechaElaboracion;
            modificarMedicamento.fechaVencimiento = fechaVencimiento;
            modificarMedicamento.componentes = componentes;

            
            MessageBoxResult resultadoModificar = MessageBox.Show("¿Está seguro de modificar el medicamento?", "¡Cuidado!", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (resultadoModificar.Equals(MessageBoxResult.Yes))
                if(medicamento_modificar.ModificarMedicamento(modificarMedicamento))
                    MessageBox.Show("¡Medicamento modificado correctamente!", "¡Hecho!", MessageBoxButton.OK, MessageBoxImage.Information);
            if(resultadoModificar.Equals(MessageBoxResult.No))
                MessageBox.Show("¡Medicamento no modificado!", "¡Advertencia!", MessageBoxButton.OK, MessageBoxImage.Error);
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
