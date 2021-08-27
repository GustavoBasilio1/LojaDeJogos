using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaDeJogos.Models;
using System.ComponentModel.DataAnnotations;


namespace LojaDeJogos.Models
{
    public class Jogos
    {
        [Required(ErrorMessage = "O código é obrigatório")]
        [Display(Name = "Código")]
        public int Codigo { get; set; }


        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }


        [Display(Name = "Versão")]
        public string Versao { get; set; }


        [Required(ErrorMessage = "O desenvolvedor é obrigatório")]
        public string Desenvolvedor { get; set; }


        [Required(ErrorMessage = "O gênero é obrigatório")]
        [Display(Name = "Gênero")]
        public string Genero { get; set; }


        [Required(ErrorMessage = "A faixa etária é obrigatória")]
        [Display(Name = "Faixa etária")]
        public string FaixaEtaria { get; set; }


        [Required(ErrorMessage = "A plataforma é obrigatória")]
        public string Plataforma { get; set; }


        [Required(ErrorMessage = "O ano de lançamento é obrigatório")]
        [Display(Name = "Ano de lançamento")]
        public string AnoLanc { get; set; }


        [Required(ErrorMessage = "A sinopse é obrigatório")]
        public string Sinopse { get; set; }
    }
}