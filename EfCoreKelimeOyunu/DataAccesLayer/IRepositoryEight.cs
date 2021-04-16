using Entity.KelimeOyunu;
using System;
using System.Collections.Generic;
using System.Text;
using static DataAccesLayer.IRepository;

namespace DataAccesLayer
{
    public interface IRepositoryEight<T> : IRepository<EightWord> { }
    public class RepositoryEight<T> : Repository<EightWord>, IRepositoryEight<T>
    {
        public RepositoryEight(KelimeOyunuDBContext context) : base(context) { }
    }
}