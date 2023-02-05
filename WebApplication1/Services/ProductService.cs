using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using WebApplication1.IServices;

namespace WebApplication1.Services
{
    public class ProductService: IProductService
    {
        private readonly IProductLogic _productLogic;
        public ProductService(IProductLogic productLogic) 
        {
            _productLogic = productLogic;
        }
        public int InsertProduct(Product product)
        {
            _productLogic.InsertProduct(product);
            return product.Id;
        }
        public void DeleteProduct(int Id)
        {
            _productLogic.DeleteProduct(Id);
        }
        public void UpdateProduct(Product product)
        {
            _productLogic.UpdateProduct(product);
        }
        List<Product> IProductService.GetAll()
        {
            return _productLogic.GetAll();
        }
    }
}
