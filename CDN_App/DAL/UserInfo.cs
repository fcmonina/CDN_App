using CDN_App.Context;
using CDN_App.Models;
using Microsoft.EntityFrameworkCore;


namespace CDN_App.DAL
{
    public class UserInfo : IUserInfoRepository, IDisposable
    {
        private CDNContext _CDNContext;
        public UserInfo(CDNContext _CDNContext)
        {
            this._CDNContext = _CDNContext; 
        }

        public IEnumerable<UserInfos> getUser()
        {
            return _CDNContext!.Users.ToList().OrderBy(x => x.ID);
        }

        public UserInfos getUserById(int userid)
        {
            return _CDNContext!.Users.Find(userid);
        }

        public void insertUser(UserInfos user)
        {
            _CDNContext!.Users.Add(user);
        }
        public void deleteUser(int userid)
        {
            UserInfos user = _CDNContext!.Users.Find(userid);
            _CDNContext!.Users.Remove(user);
        }
        public void updateUser(UserInfos user)
        {
            _CDNContext!.Entry(user).State = EntityState.Modified;
        }
        public void save()
        {
            _CDNContext!.SaveChanges();
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _CDNContext!.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
