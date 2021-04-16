using Entity.KelimeOyunu;
using System;
using System.Collections.Generic;
using System.Text;
using static DataAccesLayer.IRepository;

namespace DataAccesLayer
{
    public interface IRepositorySix<T>:IRepository<SixthWord>{}
    public class RepositorySix<T>:Repository<SixthWord>,IRepositorySix<T>
    {
          public RepositorySix(KelimeOyunuDBContext context) : base(context) { }
    }
}
