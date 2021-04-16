using Entity.KelimeOyunu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DataAccesLayer.IRepository;

namespace DataAccesLayer
{
    public interface IRepositoryEight<T> : IRepository<EightWord>
    {
        IEnumerable<EightWord> GetEightWordByID(int ID);
    }
    public class RepositoryEight<T> : Repository<EightWord>, IRepositoryEight<T>
    {
        public RepositoryEight(KelimeOyunuDBContext context) : base(context) { }

        public IEnumerable<EightWord> GetEightWordByID(int ID)
        {
            return KelimeOyunuDBContext.EightWords.Where(x => x.EightWordID == ID)
              .ToList();
        }
    }
}