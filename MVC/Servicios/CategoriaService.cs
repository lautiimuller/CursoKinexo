using Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class CategoriaService : IService
    {
        public static List<Categoria> list = new List<Categoria>();

        public bool DeleteCategory(int id)
        {
            var categoryDelete = list.Where(x => x.Id == id).FirstOrDefault();

            if (categoryDelete != null)
            {
                list.Remove(categoryDelete);
                return true;
            }
            return false;
        }

        public bool EditCategory(Categoria catEdit)
        {
            var categoryEdit = list.Where(x => x.Id == catEdit.Id).FirstOrDefault();

            if (categoryEdit != null)
            {
                foreach (var item in list)
                {
                    if (item.Id == categoryEdit.Id)
                    {
                        item.Active = catEdit.Active;
                        item.Description = catEdit.Description;
                        item.Name = catEdit.Name;
                        break;
                    }
                }
                return true;
            }
            return false;
        }

        public List<Categoria> GetCategories()
        {
            var ejemplo1 = new Categoria { Name = "Futbol", Active = true, Description = "Primera División Argentina", Id = 1 };
            var ejemplo2 = new Categoria { Name = "Tenis", Active = true, Description = "Tenis Argentino", Id = 2 };
            list.Add(ejemplo1); list.Add(ejemplo2);

            return list;
        }

        public bool SaveCategory(Categoria category)
        {
            category.Id = list.Count + 1;
            list.Add(category);
            return true;
        }

        public Categoria SearchCategory(int id)
        {
            return list.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}

