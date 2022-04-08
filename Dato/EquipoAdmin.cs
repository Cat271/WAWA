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
        /// <param name="modelo"></param>
        public void Guardar(equipo modelo)
        {
            using (DWI_U4Entities contexto = new DWI_U4Entities())
            {
                contexto.equipo.Add(modelo);
                contexto.SaveChanges();
            }
        }
    }
}