using Entity.KelimeOyunu;
using System;
using System.Collections.Generic;
using System.Text;
using static DataAccesLayer.IRepository;

namespace DataAccesLayer
{
    public interface IRepositorySeven<T>:IRepository<SevenWord>{}
    public class RepositorySeven<T> : Repository<SevenWord>, IRepositorySeven<T>
    {
        public RepositorySeven(KelimeOyunuDBContext context) : base(context) { }
    }
}
