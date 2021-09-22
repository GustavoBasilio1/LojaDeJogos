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
    public class JogosController : Controller
    {
        // GET: Jogo
        public ActionResult Jogos()
        {
            Jogos jogos = new Jogos();
            return View(jogos);
        }
        AcoesJogo ac = new AcoesJogo();
        [HttpPost]

        public ActionResult CadJogos(Jogos jogos)
        {
            ac.CadastrarJogo(jogos);
            return View(jogos);
        }

        public ActionResult ListarJogos()
        {
            var ExibirJogos = new AcoesJogo();
            var TodosJogos = ExibirJogos.ListarJogos();
            return View(TodosJogos);
        }

    }
}