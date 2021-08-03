using Entidades;
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
using System.Xml.XPath;

namespace RegistroFarmacia.Vista.Medicamento
{
    /// <summary>
    /// Lógica de interacción para AgregarMedicamento.xaml
    /// </summary>
    public partial class AgregarMedicamento : Window
    {
        public AgregarMedicamento()
        {
            InitializeComponent();

            cmbLaboratorio.ItemsSource = Negocio.Laboratorio_Negocio.obtenerListaLaboratorio();
            cmbLaboratorio.DisplayMemberPath = "nombre";
            cmbLaboratorio.SelectedValuePath = "Id";

        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Negocio.Medicamento_Negocio medicamento_Negocio = new Negocio.Medicamento_Negocio();
            int serie = int.Parse(this.txtSerie.Text);
            string nombre = this.txtNombre.Text;
            string principioActivo = this.txtActivo.Text;
            string dosis = this.txtDosis.Text;
            string componentes = this.txtComponentes.Text;
            DateTime fechaElaboracion = this.dpElaboracion.SelectedDate.Value;
            DateTime fechaVencimiento = this.dpVencimiento.SelectedDate.Value;
            int laboratorio = int.Parse(this.cmbLaboratorio.SelectedValue.ToString());

            Entidades.medicamento medicamento = new Entidades.medicamento();
            medicamento.serie = serie;
            medicamento.nombre = nombre;
            medicamento.componentes = componentes;
            medicamento.principioActivo = principioActivo;
            medicamento.dosis = dosis;
            medicamento.fechaElaboracion = fechaElaboracion;
            medicamento.fechaVencimiento = fechaVencimiento;
            medicamento.laboratorio = laboratorio;
            


            
            MessageBoxResult resultado = MessageBox.Show("¿Está seguro de agregar el medicamento?", "Agregar Medicamento", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (resultado.Equals(MessageBoxResult.Yes))
                if (medicamento_Negocio.Agregar(medicamento))
                    MessageBox.Show("Medicamento agregado", "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);
            if (resultado.Equals(MessageBoxResult.No))
                MessageBox.Show("Medicamento no agregado", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
                    Close();
            
                    
            
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            Vista.Modificar.ModificarMedicamento ventanaModicar = new Vista.Modificar.ModificarMedicamento();
            ventanaModicar.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void moverAgregar(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
