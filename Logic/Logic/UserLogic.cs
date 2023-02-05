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
    public class UserLogic : BaseContextLogic, IUserLogic
    {
        public UserLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public void InsertUser(User user)
        {
            _serviceContext.Users.Add(user); 
            _serviceContext.SaveChanges();
        }
        void IUserLogic.DeleteUser(int Id)
        {
            _serviceContext.Users.Remove(_serviceContext.Set<User>().Where(user => user.Id == Id).First());
            _serviceContext.SaveChanges();
        }
        public void UpdateUser(User user)
        {
            _serviceContext.Users.Update(user);
            _serviceContext.SaveChanges();
        }
        List<User> IUserLogic.GetAll()
        {
            var allUser = _serviceContext.Set<User>().ToList();
            return allUser;
        }
    }
}
