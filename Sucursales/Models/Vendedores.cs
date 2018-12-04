using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sucursales.Models
{
    public class Vendedores
    {
        public int Codigo { get; set; }

        public string Identificacion { get; set; }

        public string TipoIdentificacion { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Sucursal { get; set; }
    }
}