using Entity.KelimeOyunu;
using System;
using System.Collections.Generic;
using System.Text;
using static DataAccesLayer.IRepository;

namespace DataAccesLayer
{
    public interface IRepositoryFive<T>:IRepository<FifthWord>{}
    public class RepositoryFive<T> : Repository<FifthWord>, IRepositoryFive<T>
    {
        public RepositoryFive(KelimeOyunuDBContext context) : base(context) { }
    }

}
