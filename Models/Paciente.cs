using ProjetoIESB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesafioASP.Models
{

    public class Paciente
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]

        public string Nome { get; set; } //Não pode ter mais que 100 caracteres
        [Required(ErrorMessage = "CPF obrigatório")]
        [CustomValidationCPF(ErrorMessage = "CPF inválido")]
        public string CPF { get; set; } //Validar se o CPF é válido e se já existe CPF cadastrado na base para outro paciente
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyy}", ApplyFormatInEditMode = true)]
        public string Nascimento { get; set; }
        [Required]
        public string Sexo { get; set; }
 
        [Required(ErrorMessage = "O Telefone é obrigatório.")]
        [RegularExpression(@"^\d{4}[-]{1}\d{4}$", ErrorMessage = "Telefone inválido. Informe ####-####.")]
        public string Telefone { get; set; } //Não pode ser um telefone inválido
        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; } //Não pode ser um e-mail inválido
    }
}