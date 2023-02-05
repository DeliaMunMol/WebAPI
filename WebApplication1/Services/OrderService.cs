using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using WebApplication1.IServices;

namespace WebApplication1.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderLogic _orderLogic; 
        public OrderService(IOrderLogic orderLogic)
        {
            _orderLogic = orderLogic;
        }
        public int InsertOrder(Order order)
        {
            _orderLogic.InsertOrder(order);
            return order.Id;
        }
        public void DeleteOrder(int Id)
        {
            _orderLogic.DeleteOrder(Id);
        }
        public void UpdateOrder(Order order)
        {
            _orderLogic.UpdateOrder(order);
        }
        List<Order> IOrderService.GetAll()
        {
            return _orderLogic.GetAll();
        }
    }
}
