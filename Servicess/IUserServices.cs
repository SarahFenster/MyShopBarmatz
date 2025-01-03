﻿using Entities;

namespace Servicess
{
    public interface IUserServices
    {
        Task<User> Add(User user);
        int CheckPassword(string password);
        Task<User> GetById(int id);
        Task<User> Login(string email, string password);
        Task<User> Update(int id, User userToUpdate);
    }
}