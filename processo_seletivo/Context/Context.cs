using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using processo_seletivo.Models;

namespace processo_seletivo.Context
{
    public class Context:DbContext
    {
        public DbSet<Curso> ctCurso { get; set; }
        public DbSet<Turma> ctTurma { get; set; }
        public DbSet<Usuario> ctUsario { get; set; }
    }
}