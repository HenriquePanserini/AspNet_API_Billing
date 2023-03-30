using Microsoft.EntityFrameworkCore;
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
        return await _data.Users.ToListAsync();
    }

    public async Task<User> GetUserById(int id)
    {
        return await _data.Users.FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task<User> AddUser(User user)
    {
        await _data.Users.AddAsync(user);
        await _data.SaveChangesAsync();

        return user;
    }

    public async Task<bool> DeleteUser(int id)
    {
        User userSearch = await GetUserById(id);

        if(userSearch == null){
            throw new ArgumentException($"User {id} not found");
        }

        _data.Users.Remove(userSearch);
        await _data.SaveChangesAsync();

        return true;
    }

    public async Task<User> UpdateUser(int id, User user)
    {
        User userSearch = await GetUserById(id);

        if(userSearch == null){
            throw new Exception($"User {id} does not exist");
        }

        userSearch.Name = user.Name;
        userSearch.Email = user.Email;

        _data.Users.Update(userSearch);
        await _data.SaveChangesAsync();

        return userSearch;
    }
}