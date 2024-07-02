using WatchStore_NguyenVanLuc_21K4080078.Models;

namespace WatchStore_NguyenVanLuc_21K4080078.Services
{
    public class UserState
    {
        public User CurrentUser { get; private set; }

        public void SetUser(User user)
        {
            CurrentUser = user;
        }

        public void ClearUser()
        {
            CurrentUser = null;
        }
    }
}
