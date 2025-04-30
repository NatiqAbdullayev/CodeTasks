using ConsoleApp10.Context;
using ConsoleApp10.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Services;

class UserService
{

    private readonly AppDbContext _context;
    private readonly DbSet<User> _user;

    public UserService()
    {
        _context = new AppDbContext();
        _user = _context.User;
    }

    public void AddUser(User user)
    {
        if (user is null)
        {
            throw new Exception("Register failde.Object cannot be null");
        }

        _context.User.Add(user);
        _context.SaveChanges();
    }

    public void UpdateUser(int id, User user)
    {
        if (user is null)
        {
            throw new Exception("Register failed.Object cannot be null");
        }

        var oldUser = _context.User.Find(id);

        if (oldUser is not null)
        {
            oldUser.Username = user.Username;
            oldUser.Password = user.Password;
            _context.SaveChanges();
            return;
        }

        throw new Exception("Cannot find entity with this id");

    }

    public User GetUserById(int id)
    {
        User? user = _user.Find(id);

        if (user is not null)
        {
            return user;
        }
        throw new Exception("Cannot find entity with this id");
    }

    public List<User> GetAllUsers()
    {
        List<User> users = _context.User.ToList();

        if (users.Count == 0)
        {

            throw new Exception("Cannot find any entity");
        }

        return users;
    }

    public void DeleteUser(int id)
    {

        var user = _user.Find(id);
        _user.Remove(user);
        _context.SaveChanges();
    }


}
