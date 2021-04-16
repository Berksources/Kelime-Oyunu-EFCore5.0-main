using Entity.KelimeOyunu;
using System;
using System.Collections.Generic;
using System.Text;
using static DataAccesLayer.IRepository;

namespace DataAccesLayer
{
   public interface IRepositoryNine<T>:IRepository<NineWord>{}
    public class RepositoryNine<T> : Repository<NineWord>, IRepositoryNine<T>
    {
        public RepositoryNine(KelimeOyunuDBContext context) : base(context) { }
    }
}
