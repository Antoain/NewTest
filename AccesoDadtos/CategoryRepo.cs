using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDadtos
{
    public class CategoryRepo
    {
        public NorthwindEntities contexto = new NorthwindEntities();

        public List<Categories> ObtnTodos() 
        { 
            var categ = from custM in contexto.Categories select custM;
            return categ.ToList();
        }
    }
}
