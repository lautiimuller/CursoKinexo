using Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class NotasService : IServicioNotas
    {
        public static List<Notas> list = new List<Notas>();

        public List<Notas> Create(Notas post)
        {
            var nota1 = new Notas { Id = post.Id, Active = post.Active, Date = post.Date, Descripcion = post.Descripcion, IdCategoria = post.IdCategoria, Titulo = post.Titulo };
            list.Add(nota1);
            return list;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(int id)
        {
            throw new NotImplementedException();
        }

        public List<Notas> GetNews()
        {
            return list;
        }

        public Notas SearchNews(int id)
        {
            throw new NotImplementedException();
        }
    }
}
