using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosMedicamentos
{
    public class Laboratorio
    {
        public List<Entidades.laboratorio> obtenerListaLaboratorio()
        {
            using(Entidades.FarmaciaEntities entidades = new Entidades.FarmaciaEntities())
            {
                return entidades.laboratorio.ToList();
            }
        }
    }
}
