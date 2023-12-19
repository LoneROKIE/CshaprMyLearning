using Microsoft.AspNetCore.Mvc;
using CRUDCORE.Data;
using CRUDCORE.Models;


namespace CRUDCORE.Controllers
{
    public class MantenedorController : Controller
    {

        ContactoDatos _ContactoDatos = new ContactoDatos(); 
        // lista todos los contactos y muestra la vista con los datos ya cargados
        public IActionResult Listar()
        {
            //La vista mostrara una lista de contactos
            var oLista = _ContactoDatos.Listar();

            return View(oLista);
        }

        #region metodo para mostrar la vista y metodo para guardar un contacto (form de esa vista)
        public IActionResult Guardar()
        {
            // Devuelve la vista
            return View(); 
        }
         
        [HttpPost]
        public IActionResult Guardar(ContactoModelcs oContacto)
        {
            // Recibe un objeto para guardarlo en BD

            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _ContactoDatos.Guardar(oContacto);

            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else
            {
                return View();
            }
        }
        #endregion

        #region metodo para mostrar la vista y metodo para editar un contacto (form de esa vista)
        public IActionResult Editar(int IdContacto)
        {
            // Devuelve la vista
            var oContacto = _ContactoDatos.Obtener(IdContacto); // obtenemos el contacto
            return View(oContacto); // le pasamos el contacto a la vista
        }

        [HttpPost]
        public IActionResult Editar(ContactoModelcs oContacto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _ContactoDatos.Editar(oContacto);

            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else
            {
                return View();
            }
        }
        #endregion


        public IActionResult Eliminar(int IdContacto)
        {
            // Devuelve la vista
            var oContacto = _ContactoDatos.Obtener(IdContacto); // obtenemos el contacto
            return View(oContacto); // le pasamos el contacto a la vista
        }

        [HttpPost]
        public IActionResult Eliminar(ContactoModelcs oContacto)
        {

            var respuesta = _ContactoDatos.Eliminar(oContacto.IdContacto);

            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else
            {
                return View();
            }
        }


    }
}

