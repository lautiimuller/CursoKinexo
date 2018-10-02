using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public class Notas
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public int IdCategoria { get; set; }

        public DateTime Date { get; set; }

        public bool Active { get; set; }

    }
}
