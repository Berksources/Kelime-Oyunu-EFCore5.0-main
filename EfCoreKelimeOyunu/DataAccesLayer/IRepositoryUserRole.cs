using Entity.KelimeOyunu;
using System;
using System.Collections.Generic;
using System.Text;
using static DataAccesLayer.IRepository;

namespace DataAccesLayer
{
    public interface IRepositoryUserRole<T> : IRepository<UserRole> { }
    public class RepositoryUserRole<T> : Repository<UserRole>, IRepositoryUserRole<T>
    {
        public RepositoryUserRole(KelimeOyunuDBContext context) : base(context) { }
    }
}
