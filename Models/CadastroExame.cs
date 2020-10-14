using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DesafioASP.Models
{
    public class CadastroExame
    {
            
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O Cadastro de Exame é obrigatório")]
        [Display(Name = "Cadastro do exame")]
        [StringLength(100)]
        public string NomeExame { get; set; }//Não pode ter mais que 100 caracteres
        [Required]
        [StringLength(1000)]
        [Display(Name = "Observação")]
        public string Observacao { get; set; } //Não pode ter mais que 1000 caracteres
        [Display(Name = "Id do Exame")]
        public string IdTipoExame { get; set; } 
    }
}