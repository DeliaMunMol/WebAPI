using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using WebApplication1.IServices;

namespace WebApplication1.Services
{
    public class UserService : IUserService
    {
        private readonly IUserLogic _userLogic;
        public UserService(IUserLogic userLogic) 
        {
            _userLogic = userLogic;
        }

        public int InsertUser(User user)
        {
            _userLogic.InsertUser(user);
            return user.Id;
        }
        public void DeleteUser(int Id)
        {
            _userLogic.DeleteUser(Id);
        }
        public void UpdateUser(User user)
        {
            _userLogic.UpdateUser(user);
        }
        List<User> IUserService.GetAll()
        {
            return _userLogic.GetAll();
        }
    }
}
