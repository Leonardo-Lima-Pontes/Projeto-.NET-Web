using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeonardoLimaPontes.Models
{
    public class TipoAplicacao
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }

    }
}
