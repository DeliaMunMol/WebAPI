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
    public class OrderLogic: BaseContextLogic, IOrderLogic
    {
        public OrderLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public void InsertOrder(Order order)
        {
            _serviceContext.Orders.Add(order);
            _serviceContext.SaveChanges();
        }
        void IOrderLogic.DeleteOrder(int Id)
        {
            _serviceContext.Orders.Remove(_serviceContext.Set<Order>().Where(o => o.Id == Id).FirstOrDefault());
            _serviceContext.SaveChanges();
        }
        public void UpdateOrder(Order order)
        {
            _serviceContext.Orders.Update(order);
            _serviceContext.SaveChanges();
        }
        List<Order> IOrderLogic.GetAll()
        {
            var allOrder = _serviceContext.Set<Order>().ToList();
            return allOrder;
        }
    }
}
