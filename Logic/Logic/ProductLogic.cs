using Data;
using Entities.Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class ProductLogic : BaseContextLogic, IProductLogic
    {
        public ProductLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public int InsertProduct(Product product)
        {
            _serviceContext.Products.Add(product);
            _serviceContext.SaveChanges();
            return product.Id;
        }
        void IProductLogic.DeleteProduct(int Id)
        {
            _serviceContext.Products.Remove(_serviceContext.Set<Product>().Where(p => p.Id == Id).FirstOrDefault());
            _serviceContext.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            _serviceContext.Products.Update(product);
            _serviceContext.SaveChanges();
        }
        List<Product> IProductLogic.GetAll()
        {
            var allProducts = _serviceContext.Set<Product>().ToList();
            return allProducts;
        }
    }
}
