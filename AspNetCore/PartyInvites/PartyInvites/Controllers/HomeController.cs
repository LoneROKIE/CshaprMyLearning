using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Diagnostics;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        // el viewResult es un objeto que representa una vista que se va a mostrar al usuario
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) // el parametro guestResponse es un objeto que representa los datos que el usuario envia
        {
            // TODO: Store guest response from param
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
            }
            else
            {
                return View();
            }

            return View("Thanks", guestResponse);
        }


        public  ViewResult ListResponses()
        {
            // TODO: Store guest response from param
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }

    }
}
