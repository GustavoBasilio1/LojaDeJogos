using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaDeJogos.Models;
using System.ComponentModel.DataAnnotations;


namespace LojaDeJogos.Models
{
    public class Cliente
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O CPF é obrigatório")]
        [Display(Name = "CPF")]
        [RegularExpression(@"([0-9]{3}.[0-9]{3}.[0-9]{3}-[0-9]{2})|([0-9]{11})", ErrorMessage = "Insira um formato de CPF válido. Ex: 000.000.000-00")]
        public string CPF { get; set; }


        [Required(ErrorMessage = "A data de nascimento é obrigatória")]
        [Display(Name = "Data de nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DtNascimento
        {
            get
            {
                return this.dataNascimento.HasValue
                ? this.dataNascimento.Value
                : DateTime.Now;
            }
            set
            {
                this.dataNascimento = value;
            }
        }
        private DateTime? dataNascimento = null;



        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [Display(Name = "E-mail")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; }


        [Required(ErrorMessage = "O número de celular é obrigatório")]
        [Display(Name = "Número de celular")]
        [RegularExpression(@"^\(?\d{2}\)?[\s-]?[\s9]?\d{4}-?\d{4}$",
        ErrorMessage = "Insira um formato de número válido. Ex (00) 00000-0000")]
        //@: Evita o erro 1009 - sequência de escape inválida
        public string Celular { get; set; }



        [Required(ErrorMessage = "O endereço é obrigatório")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
    }
}