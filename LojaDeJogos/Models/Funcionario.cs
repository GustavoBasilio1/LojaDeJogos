using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaDeJogos.Models
{
    public class Funcionario
    {
        [Display(Name = "Código do funcionário")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string FuncionarioID { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string CPF { get; set; }

        [Display(Name = "RG")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string RG { get; set; }

        [Display(Name = "Data de nascimento")]
        [Required(ErrorMessage = "Data de nascimento obrigatória")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode
= true)]
        public DateTime DataNasc
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

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Endereco { get; set; }

        [RegularExpression("(^\\+)?[0-9()-]*")]
        public string Celular { get; set; }   

        [Display(Name = "Email")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Email { get; set; }

        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Cargo { get; set; }

        
    }

}