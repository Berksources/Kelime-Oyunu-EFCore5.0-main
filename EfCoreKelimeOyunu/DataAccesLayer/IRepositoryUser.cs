using Entity.KelimeOyunu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DataAccesLayer.IRepository;

namespace DataAccesLayer
{
    public interface IRepositoryUser<T> : IRepository<User>
    {
        IEnumerable<User> GetUsersByEmail(string userEmail);
        IEnumerable<User> GetGamers();
        IEnumerable<User> GetAdmins();
        IEnumerable<User> GetByIDForUpdate(int ID);
    }
    public class RepositoryUser<T> : Repository<User>, IRepositoryUser<T>
    {
        public RepositoryUser(KelimeOyunuDBContext context) : base(context) { }

        public IEnumerable<User> GetUsersByEmail(string userEmail)
        {
            return KelimeOyunuDBContext.Users.Where(x => x.UserEMail == userEmail).ToList();
        }
        public IEnumerable<User> GetGamers()
        {
            return KelimeOyunuDBContext.Users.Where(x => x.UserRoleID == 2).ToList();
        }
        public IEnumerable<User> GetAdmins()
        {
            return KelimeOyunuDBContext.Users.Where(x => x.UserRoleID == 1).ToList();
        }

        public IEnumerable<User> GetByIDForUpdate(int ID)
        {
            return KelimeOyunuDBContext.Users.Where(x => x.UserID == ID).ToList();
        }
    }
}
