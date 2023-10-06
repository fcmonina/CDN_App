using CDN_App.Models;

namespace CDN_App.DAL
{
    public interface IUserInfoRepository : IDisposable
    {
        IEnumerable<UserInfos> getUser();
        UserInfos getUserById(int userid);
        void insertUser(UserInfos user);
        void deleteUser(int userid);
        void updateUser(UserInfos user);
        void save();
    }
}
