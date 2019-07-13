using Contactes.Web.Helpers;
using Contactes.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Contactes.Web.ViewModels
{
    public class PersonaViewModel
    {
       
        [Required]
        [StringLength(50, ErrorMessage = "Debe contener maximo {0} caracteres")]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Debe contener maximo {0} caracteres")]
        public string Apellido { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Debe contener maximo {0} caracteres")]
        public string Email { get; set; }

        [StringLength(13, ErrorMessage = "Debe contener maximo {0} caracteres")]
        public string Telefono { get; set; }

        [StringLength(250, ErrorMessage = "Debe contener maximo {0} caracteres")]
        public string Direccion { get; set; }

        [NumeroValido]
        public decimal MontoAdeudado { get; set; }


        public int TipoIdentificador { get; set; }

        public List<SelectListItem> TiposDeContactos { get; set; }

        
        // public List<Tipo> TiposDeContactos { get; set; }
    }
}
