using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IProductLogic
    {
        int InsertProduct(Product product);
        void DeleteProduct(int id);
        void UpdateProduct(Product product);
        List<Product> GetAll();

    }
}
