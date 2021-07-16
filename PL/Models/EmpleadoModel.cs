using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PL.Models
{
    public class EmpleadoModel
    {
        public int IdEmpleado { get; set; }

        public string Nombre { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public Models.Estado Estado { get; set; }

        public string Telefono { get; set; }

        public Models.Rol Rol { get; set; }

        public List<object> Empleados { get; set; }
    }
}