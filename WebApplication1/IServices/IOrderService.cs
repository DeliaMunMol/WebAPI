using Entities.Entities;

namespace WebApplication1.IServices
{
    public interface IOrderService
    {
        int InsertOrder(Order order);
        void DeleteOrder(int Id);
        void UpdateOrder(Order order);
        List<Order> GetAll();
    }
}
