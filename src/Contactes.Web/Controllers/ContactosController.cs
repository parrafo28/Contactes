using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contactes.Web.Models;
using Contactes.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Contactes.Web.Controllers
{
    public class ContactosController : Controller
    {
        private readonly DataContex _context;

        public ContactosController(DataContex context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            var tipos = _context.Tipos; 

            var vm = new PersonaViewModel
            {
                TiposDeContactos =  new SelectList(tipos, "Identificador", "Nombre"),
                TiposDeContactosx =  tipos 
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(PersonaViewModel vm)
        {
            if (!ModelState.IsValid)
            {vm.
                return View(vm);
            }

            var persona = new Persona
            {
                Nombre = vm.Nombre,
                Apellido = vm.Apellido,
                Direccion = vm.Direccion,
                Email = vm.Email,
                Telefono = vm.Telefono,
                TipoIdentificador = vm.TipoIdentificador
            };

            _context.Add(persona);

            _context.SaveChanges();


            return RedirectToAction("Index", "Home");
        }
    }
}