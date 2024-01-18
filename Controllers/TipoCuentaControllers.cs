using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using ManejoPresupuesto.Interfaces;
using ManejoPresupuesto.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManejoPresupuesto.Controllers
{
    public class TiposCuentasController : Controller
    {
        private readonly IRepositorioTiposCuentas repositorioTiposCuentas;

        // Utiliza el nombre correcto del constructor
        public TiposCuentasController(IRepositorioTiposCuentas repositorioTiposCuentas)
        {
            this.repositorioTiposCuentas = repositorioTiposCuentas;
        }

        // Resto del código...

        // Acción para mostrar el formulario de creación
        public IActionResult Crear()
        {
            return View();
        }

        // Acción para procesar el formulario de creación
        [HttpPost]
        public IActionResult Crear(TiposCuentas tiposCuentas)
        {
            if (ModelState.IsValid)
            {
                // Aquí tu lógica para guardar en la base de datos
                repositorioTiposCuentas.Crear(tiposCuentas);
                return RedirectToAction("Index");  // Redirige a la acción Index después de la creación exitosa
            }

            // Si el modelo no es válido, regresa a la vista con los errores
            return View(tiposCuentas);
        }

        // Otras acciones para editar, eliminar, ver detalles, etc.
    }
}
