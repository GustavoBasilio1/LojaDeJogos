using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaDeJogos.Models
{
    public class Jogos
    {
        [Display(Name = "Código do jogo")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string JogoID { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "Versão")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Versao { get; set; }

        [Display(Name = "Desenvolvedor do jogo")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Desenvolvedor { get; set; }

        [Display(Name = "Gênero do jogo")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Genero { get; set; }

        [Display(Name = "Faixa etária")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string FaixaEtaria { get; set; }

        [Display(Name = "Plataforma do jogo")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Plataforma { get; set; }

        [Display(Name = "Ano de lançamento")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? AnoLanc { get; set; }

        [Display(Name = "Sinopse do jogo")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Sinopse { get; set; }

        
    }
}