using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LojaDeJogos.Models
{
    public class Cliente
    {

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string CPF { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Nome { get; set; }

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

        [RegularExpression("[a-zA-Z0-9_\\.\\+-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-\\.]+", ErrorMessage = "Digite um email válido")]
        public string Email { get; set; }

        [RegularExpression("(^\\+)?[0-9()-]*")]
        public string Celular { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Endereco { get; set; }

        

        
    }

}