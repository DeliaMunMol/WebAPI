using Entities.Entities;

namespace WebApplication1.IServices
{
    public interface IProductService
    {
        int InsertProduct(Product product);
        void DeleteProduct(int Id);
        void UpdateProduct(Product product);
        List<Product> GetAll();
    }
}
