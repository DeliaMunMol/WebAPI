using Entities.Entities;

namespace WebApplication1.IServices
{
    public interface IUserService
    {
        int InsertUser(User user);
        void DeleteUser(int Id);
        void UpdateUser(User user);
        List<User> GetAll();
    }
}
