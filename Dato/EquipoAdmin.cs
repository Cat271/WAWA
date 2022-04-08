using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAWA.Models;
using System.Data.Entity;

namespace WAWA.Dato
{
    public class EquipoAdmin
    {
        /// <summary>
        /// Consultar todos los equipos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<equipo> Consultar()
        {
            using (DWI_U4Entities contexto = new DWI_U4Entities())
            {
                return contexto.equipo.AsNoTracking().ToList();
            }
        }

        /// <summary>
        /// Guardar un equipo en la BD
        /// </summary>
        /// <param name="modelo">datos del equipo</param>
        public void Guardar(equipo modelo)
        {
            using (DWI_U4Entities contexto = new DWI_U4Entities())
            {
                contexto.equipo.Add(modelo);
                contexto.SaveChanges();
            }
        }

        /// <summary>
        /// Consultar
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public equipo Consultar(int id)
        {
            using (DWI_U4Entities contexto = new DWI_U4Entities())
            {
                return contexto.equipo.FirstOrDefault(v => v.idEquipo == id);
            }
        }

        /// <summary>
        /// Modifica los datos de un equipo
        /// </summary>
        /// <param name="modelo">datos de un equipo</param>
        public void Modificar(equipo modelo)
        {
            using (DWI_U4Entities contexto = new DWI_U4Entities())
            {
                contexto.Entry(modelo).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Eliminar(equipo modelo)
        {
            using (DWI_U4Entities contexto = new DWI_U4Entities())
            {
                contexto.Entry(modelo).State = EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}