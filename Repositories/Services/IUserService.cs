using AspNet_API_App.Models;

namespace AspNet_API_App.Services;

public interface IUserService{
    Task<List<User>> GetAllUsers();
    Task<User> GetUserById(int id);
    Task<User> AddUser(User user);
    Task<User> UpdateUser(int id, User user);
    Task<bool> DeleteUser(int id);
}