using Entity.KelimeOyunu;
using System;
using System.Collections.Generic;
using System.Text;
using static DataAccesLayer.IRepository;

namespace DataAccesLayer
{
   public interface IRepositoryFour<T>:IRepository<FourWord>{}
    public class RepositoryFour<T> : Repository<FourWord>, IRepositoryFour<T>
    {
        public RepositoryFour(KelimeOyunuDBContext context) : base(context) {}
    }
}
