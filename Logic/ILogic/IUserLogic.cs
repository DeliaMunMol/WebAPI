using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IUserLogic
    {
        void InsertUser(User user);
        void DeleteUser(int Id);
        void UpdateUser(User user);
        List<User> GetAll();
    }
}
