using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Dalc
{
    public class DalcProduct
    {
        public static List<Product> GetProducts()
        {
            var context = new NorthwindEntities();
            return context.Products.ToList();
        }
    }
}
