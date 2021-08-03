using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Medicamento_Negocio
    {
        //obtiene la variable obtenerListaMedicamentos desde el namespace DatosMedicamentos
        public static List<Entidades.medicamento> obtenerListaMedicamentos()
        {
            return new DatosMedicamentos.Medicamento().obtenerListaMedicamentos();
        }

        public bool Agregar(Entidades.medicamento medicamento)
        {
            
            return new DatosMedicamentos.Medicamento().AgregarDatos(medicamento);
            
        }

        public bool ModificarMedicamento(Entidades.medicamento modificarMedicamento)
        {
            return new DatosMedicamentos.Medicamento().ModificarDatos(modificarMedicamento);
        }

        public bool validarSerie(int serie)
        {
            Entidades.medicamento medicamento = new Entidades.medicamento();

            if (serie != medicamento.serie)
                return true; 
            else 
                return false;
        }

        public bool EliminarMedicamento(Entidades.medicamento eliminarMedicamento)
        {
            return new DatosMedicamentos.Medicamento().EliminarDatos(eliminarMedicamento);
        }
        
    }
}
