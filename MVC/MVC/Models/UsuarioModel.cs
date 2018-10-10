using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        public string Nick { get; set; }

        public string Email { get; set; }

        public char Contraseña { get; set; }

        public bool TipoUsuario { get; set; }
    }
}