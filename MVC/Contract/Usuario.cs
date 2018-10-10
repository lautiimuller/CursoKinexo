using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nick { get; set; }

        public string Email { get; set; }

        public char Contraseña { get; set; }

        public bool TipoUsuario { get; set; }

    }
}
