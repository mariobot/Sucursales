using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sucursales.Models
{
    public class Initialized
    {

        public static List<Sucursales> InitSucursales() {

            List<Sucursales> _sucursales = new List<Sucursales>(){
            new Sucursales(){ Codigo = 1, Descripcion = "Acacías"},
            new Sucursales(){ Codigo = 2, Descripcion = "Bogota"},
            new Sucursales(){ Codigo = 3, Descripcion = "Cali"},
            new Sucursales(){ Codigo = 4, Descripcion = "Medellin"},
            new Sucursales(){ Codigo = 5, Descripcion = "Santa Marta"}
        };

            return _sucursales;
        }

        public static List<Vendedores> InitVendedores() {

            List<Vendedores> _vendedores = new List<Vendedores>() {
                new Vendedores(){ Codigo =100, Identificacion="79000001", TipoIdentificacion="CC", Nombre="Camilo", Apellido="Casas", Sucursal=1 },
                new Vendedores(){ Codigo =101, Identificacion="79000002", TipoIdentificacion="CC", Nombre="Carla", Apellido="Casallas", Sucursal=1 },
                new Vendedores(){ Codigo =102, Identificacion="79000003", TipoIdentificacion="CC", Nombre="Ramiro", Apellido="Rojas", Sucursal=2 },
                new Vendedores(){ Codigo =103, Identificacion="79000004", TipoIdentificacion="CC", Nombre="Jorge", Apellido="Nitales", Sucursal=2 },
                new Vendedores(){ Codigo =104, Identificacion="79000005", TipoIdentificacion="CC", Nombre="Sahara", Apellido="Salinas", Sucursal=5 },
                new Vendedores(){ Codigo =105, Identificacion="79000006", TipoIdentificacion="CC", Nombre="Maria", Apellido="Talero", Sucursal=4 },
                new Vendedores(){ Codigo =106, Identificacion="79000007", TipoIdentificacion="CC", Nombre="José", Apellido="Suarez", Sucursal=4},
                new Vendedores(){ Codigo =107, Identificacion="79000008", TipoIdentificacion="CC", Nombre="Mariana", Apellido="Rojas", Sucursal=3},
                new Vendedores(){ Codigo =108, Identificacion="79000009", TipoIdentificacion="CC", Nombre="Laura", Apellido="Bolivar", Sucursal=2},
                new Vendedores(){ Codigo =109, Identificacion="79000010", TipoIdentificacion="CC", Nombre="Carolina", Apellido="Marín", Sucursal=2},
                new Vendedores(){ Codigo =110, Identificacion="79000011", TipoIdentificacion="CC", Nombre="Iván", Apellido="Trejos", Sucursal= 2}
            };

            return _vendedores;
        }
    }
}