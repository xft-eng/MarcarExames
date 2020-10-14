using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DesafioASP.Models
{
    public class TipoExame
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O tipo de Exame é obrigatório")]
        [Display(Name ="Tipo do Exame")]
        [StringLength(100)]
        public string TipodoExame { get; set; }//Não pode ter mais que 100 caracteres
        [Required]
        [StringLength(256)]
        public string Descricao { get; set; } //Não pode ter mais que 256 caracteres
}
}