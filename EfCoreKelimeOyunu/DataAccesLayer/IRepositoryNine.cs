using Entity.KelimeOyunu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DataAccesLayer.IRepository;

namespace DataAccesLayer
{
   public interface IRepositoryNine<T>:IRepository<NineWord>
    {
        IEnumerable<NineWord> GetNineWordByID(int ID);
    }
    public class RepositoryNine<T> : Repository<NineWord>, IRepositoryNine<T>
    {
        public RepositoryNine(KelimeOyunuDBContext context) : base(context) { }

        public IEnumerable<NineWord> GetNineWordByID(int ID)
        {
            return KelimeOyunuDBContext.NineWords.Where(x => x.NineWordID == ID)
                .ToList();
        }
    }
}
