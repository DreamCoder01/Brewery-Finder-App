using Capstone.Models;
using System.Collections.Generic;

namespace Capstone.DAO
{
    public interface IUserDao
    {
        User GetUser(string username);
        User AddUser(string username, string password, string role, bool requestBrewer);
        List<ReturnUser> GetUsers();
        ReturnUser ApproveBrewer(string username);
        ReturnUser DenyBrewer(string username);
    }
}
