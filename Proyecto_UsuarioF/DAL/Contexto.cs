using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_UsuarioF.Entidades;

namespace Proyecto_UsuarioF.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = GestionUsuario.Db");
        }
    }
}
