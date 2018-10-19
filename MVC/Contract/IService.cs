using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface IService
    {
        bool SaveCategory(Categoria category);

        List<Categoria> Getcategory();

        bool EditCategory(Categoria category);

        Categoria SearchCategory(int id);

        bool DeleteCategory(int id);

  

    }
}
