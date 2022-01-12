﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace processo_seletivo.Models
{
    public class Turma
    {
        [Key]
        public int IdTurma { get; set; }
        [Display(Name = "Curso")]
        public int IdCurso { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name ="Nome da Turma")]
        public string DescricaoTurma { get; set; }
        [Range(0, 60)]
        [Display(Name = "Quantidade de Alunos")]
        public int QtdeAlunos { get; set; }
        public Turnos Turno { get; set; }

        public bool Ativo { get; set; }

        public virtual string NomeCurso { get; set; }

        public enum Turnos : int
        {
            Matutino,
            Vespetino,
            Noturno
        }

    }
}