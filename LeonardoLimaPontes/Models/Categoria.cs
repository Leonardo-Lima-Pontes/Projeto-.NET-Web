using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeonardoLimaPontes.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [DisplayName("Ordem Visual")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Você precisa informar o valor da ordem visual dentro do formulario (maior que zero)")]
        public int OrdemVisual { get; set; }
    }
}
