using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IOrderLogic
    {
        void InsertOrder(Order order);
        void DeleteOrder(int id);
        void UpdateOrder(Order order);
        List<Order> GetAll();
    }
}
