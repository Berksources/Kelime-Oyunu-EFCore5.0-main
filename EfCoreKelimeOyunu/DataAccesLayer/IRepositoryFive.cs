using Entity.KelimeOyunu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DataAccesLayer.IRepository;

namespace DataAccesLayer
{
    public interface IRepositoryFive<T>:IRepository<FifthWord>
    {
        IEnumerable<FifthWord> GetFifthWordByID(int ID);
    }
    public class RepositoryFive<T> : Repository<FifthWord>, IRepositoryFive<T>
    {
        public RepositoryFive(KelimeOyunuDBContext context) : base(context) { }
        public IEnumerable<FifthWord> GetFifthWordByID(int ID)
        {
            return KelimeOyunuDBContext.FifthWords.Where(x => x.FifthWordID == ID)
               .ToList();
        }
    }

}
