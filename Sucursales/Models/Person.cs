using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sucursales.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "* Requerido")]
        public string Name { get; set; }

        [Required(ErrorMessage = "* Requerido")]
        public string Surname { get; set; }

        [Required(ErrorMessage ="* Requerido")]
        public string Identification { get; set; }
        
        public string TypeDoc { get; set; }
    }
}