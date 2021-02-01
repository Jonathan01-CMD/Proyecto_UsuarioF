using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto_UsuarioF.Entidades
{
    public class Usuario
    {
        [Key]
        public int IdR { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Alias { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public string RolId { get; set; }
        public bool Activo { get; set; }
        public string UsuarioNombre { get; set; }

        public Usuario()
        {
            UsuarioId = 0;
            IdR = 0;
            FechaIngreso = DateTime.Now;
            Alias = string.Empty;
            Nombres = string.Empty;
            Email = string.Empty;
            Clave = string.Empty;
            RolId = string.Empty;
            Activo = false;
            UsuarioNombre = string.Empty;
        }
    }
}
