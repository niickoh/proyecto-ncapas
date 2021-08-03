using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosMedicamentos
{
    public class Medicamento
    {
        public List<Entidades.medicamento> obtenerListaMedicamentos()
        {
            using(Entidades.FarmaciaEntities entidades = new Entidades.FarmaciaEntities())
            {
                
                var med = (from m in entidades.medicamento.ToList()
                                   join l in entidades.laboratorio.ToList()
                                   on m.laboratorio equals l.Id
                                   select new Entidades.medicamento()
                                   {
                                       serie = m.serie,
                                       nombre = m.nombre,
                                       componentes = m.componentes,
                                       principioActivo = m.principioActivo,
                                       dosis = m.dosis,
                                       fechaElaboracion = m.fechaElaboracion,
                                       fechaVencimiento = m.fechaVencimiento,
                                       laboratorio = m.laboratorio,
                                       laboratorio1 = l
                                   }).ToList();
                return med;
            }
        }

        public bool AgregarDatos(Entidades.medicamento medicamento)
        {
            using (Entidades.FarmaciaEntities entidades = new Entidades.FarmaciaEntities())
            {
                entidades.medicamento.Add(medicamento);

                int variableAgregar = entidades.SaveChanges();
                return variableAgregar > 0 ? true : false;
            }
        }

        public bool ModificarDatos(Entidades.medicamento medicamento)
        {
            using(Entidades.FarmaciaEntities entidades = new Entidades.FarmaciaEntities())
            {
                var mod = (from m in entidades.medicamento
                          where m.serie == m.serie
                          select m).First();
                mod.nombre = medicamento.nombre;
                mod.principioActivo = medicamento.principioActivo;
                mod.dosis = medicamento.dosis;
                mod.fechaElaboracion = medicamento.fechaElaboracion;
                mod.fechaVencimiento = medicamento.fechaVencimiento;
                mod.componentes = medicamento.componentes;
                mod.laboratorio = medicamento.laboratorio;
                return entidades.SaveChanges()>0;
            }
        }

        public bool EliminarDatos(Entidades.medicamento medicamento)
        
            using(Entidades.FarmaciaEntities entidades = new Entidades.FarmaciaEntities())
            {
                var eliminar = (from m in entidades.medicamento
                                where m.serie == medicamento.serie
                                select m).FirstOrDefault();

                entidades.medicamento.Remove(eliminar); 
                return entidades.SaveChanges()>0;

               

            }
        }
        
    }
}
