using WatchStore_NguyenVanLuc_21K4080078.Models;
using System.Collections.Generic;
using System.Linq;
namespace WatchStore_NguyenVanLuc_21K4080078.Services
{
    public class UserService
    {
        private List<User> users = new List<User>();

        public bool Register(User user)
        {
            if (users.Any(u => u.Username == user.Username))
            {
                return false; // Tên người dùng đã tồn tại
            }

            users.Add(user);
            return true;
        }

        public bool Login(User user)
        {
            return users.Any(u => u.Username == user.Username && u.Password == user.Password);
        }
    }
}