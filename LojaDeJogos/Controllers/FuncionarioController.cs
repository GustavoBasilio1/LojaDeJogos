using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaDeJogos.Models;
using System.Collections.ObjectModel;

namespace LojaDeJogos.Controllers
{
    public class FuncionarioController : Controller
    {
        public ActionResult CadastroDoFuncionario()
        {
            return View();
        }
        [HttpPost]



        public ActionResult CadastroDoFuncionario(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                return View("ResultadoFuncionario", funcionario);
            }
            return View(funcionario);
        }



        public ActionResult ResultadoFuncionario(Funcionario funcionario)
        {
            return View(funcionario);
        }
    }
}