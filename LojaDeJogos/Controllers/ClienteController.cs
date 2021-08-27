using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaDeJogos.Models;
using System.Collections.ObjectModel;

namespace LojaDeJogos.Controllers
{
    public class ClienteController : Controller
    {
        public ActionResult CadastroDoCliente()
        {
            return View();
        }
        [HttpPost]



        public ActionResult CadastroDoCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                return View("ResultadoCliente", cliente);
            }
            return View(cliente);
        }



        public ActionResult ResultadoCliente(Cliente cliente)
        {
            return View(cliente);
        }
    }
}
