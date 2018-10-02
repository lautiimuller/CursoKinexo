using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class NotaModel
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public int IdCategoria { get; set; }

        public DateTime Date { get; set; }

        public bool Active { get; set; }
    }
}