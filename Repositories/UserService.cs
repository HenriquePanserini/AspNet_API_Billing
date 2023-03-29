using AspNet_API_App.Models;
using AspNet_API_App.Data;
using AspNet_API_App.Repositories.Services;

namespace AspNet_API_App.Repositories;

public class UserService : IUserService
{

    public readonly BillingsData _data;

    public UserService(BillingsData data){
        _data = data;
    }

    public async Task<List<User>> GetAllUsers()
    {
        throw new NotImplementedException();
    }

    public Task<User> GetUserById(int id)
    {
        throw new NotImplementedException();
    }
    public Task<User> AddUser(User user)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteUser(int id)
    {
        throw new NotImplementedException();
    }

    public Task<User> UpdateUser(int id, User user)
    {
        throw new NotImplementedException();
    }
}