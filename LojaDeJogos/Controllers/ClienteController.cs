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
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Cliente()
        {
            Cliente cliente = new Cliente();
            return View(cliente);
        }
        AcoesCli ac = new AcoesCli();
        [HttpPost]

        public ActionResult CadCliente(Cliente cli)
        {
            ac.CadastrarCliente(cli);
            return View(cli);
        }

        public ActionResult ListarCliente()
        {
            var ExibirCli = new AcoesCli();
            var TodosCli = ExibirCli.ListarCliente();
            return View(TodosCli);
        }

    }
}