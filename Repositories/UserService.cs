using Microsoft.EntityFrameworkCore;
using AspNet_API_App.Data;
using AspNet_API_App.Models;
using AspNet_API_App.Services;

namespace AspNet_API_App.Repositories;

public class UserService : IUserService
{

    public readonly BillingsData _data;

    public UserService(BillingsData data){
        _data = data;
    }

    public async Task<List<User>> GetAllUsers()
    {
        return await _data.Users.ToListAsync();
    }

    public async Task<User> GetUserById(int id)
    {
        return await _data.Users.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<User> AddUser(User user)
    {
        _data.Users.Add(user);
        await _data.SaveChangesAsync();

        return user;
    }

    public async Task<User> UpdateUser(int id, User user)
    {
        User userSearch = await GetUserById(id);

        if(userSearch == null){
            throw new ArgumentException($"User {id} does not exist");
        }

        _data.Users.Update(userSearch);
        await _data.SaveChangesAsync();

        return userSearch;
    }

    public async Task<bool> DeleteUser(int id)
    {
        User userSearch = await GetUserById(id);

        if(userSearch == null){
            throw new Exception($"Could not delete user");
        }

        _data.Users.Remove(userSearch);
        await _data.SaveChangesAsync();

        return true;
    }

}