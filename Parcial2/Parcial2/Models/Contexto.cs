using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Parcial2.Models
{
    public class Contexto:DbContext
    {
        public DbSet<Registro> Registro { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

    }
}