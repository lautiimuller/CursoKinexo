using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface IServicioNotas
    {
        bool Create(Notas post);
        bool Edit(int id);
        bool Delete(int id);
        List<Notas> GetNews();
        Notas SearchNews(int id);
    }
}
