using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaDeJogos.Models;
using LojaDeJogos.Repositorio;
using System.Collections.ObjectModel;

namespace LojaDeJogos.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Funcionario()
        {
            Funcionario funcionario = new Funcionario();
            return View(funcionario);
        }
        Acoes ac = new Acoes();
        [HttpPost]

        public ActionResult CadFuncionario(Funcionario fun)
        {
            ac.CadastrarFuncionario(fun);
            return View(fun);
        }

        public ActionResult ListarFuncionario()
        {
            var ExibirFunc = new Acoes();
            var TodosFunc = ExibirFunc.ListarFuncionario();
            return View(TodosFunc);
        }
    }
}