using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Laboratorio_Negocio
    {
        public static List<Entidades.laboratorio> obtenerListaLaboratorio()
        {
            return new DatosMedicamentos.Laboratorio().obtenerListaLaboratorio();
        }
    }
}
