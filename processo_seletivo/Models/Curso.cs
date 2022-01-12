using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace processo_seletivo.Models
{
    public class Curso
    {
        [Key]
        public int IdCurso { get; set; }
        [Required]
        [StringLength(255, MinimumLength = 3)]
        [Display(Name = "Nome do curso")]
        public string DescricaoCurso { get; set; }
        public bool Ativo { get; set; }
    }
}