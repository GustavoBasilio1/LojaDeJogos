using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaDeJogos.Models;
using System.Collections.ObjectModel;

namespace LojaDeJogos.Controllers
{
    public class JogosController : Controller
    {
        public ActionResult CadastroDosJogos()
        {
            return View();
        }
        [HttpPost]



        public ActionResult CadastroDosJogos(Jogos jogos)
        {
            if (ModelState.IsValid)
            {
                return View("ResultadoJogos", jogos);
            }
            return View(jogos);
        }



        public ActionResult ResultadoJogos(Jogos jogos)
        {
            return View(jogos);
        }
    }
}
