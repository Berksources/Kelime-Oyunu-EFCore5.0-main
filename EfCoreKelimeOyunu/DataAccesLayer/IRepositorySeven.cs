using Entity.KelimeOyunu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DataAccesLayer.IRepository;

namespace DataAccesLayer
{
    public interface IRepositorySeven<T>:IRepository<SevenWord>
    {
        IEnumerable<SevenWord> GetSevenWordByID(int ID);
    }
    public class RepositorySeven<T> : Repository<SevenWord>, IRepositorySeven<T>
    {
        public RepositorySeven(KelimeOyunuDBContext context) : base(context) { }

        public IEnumerable<SevenWord> GetSevenWordByID(int ID)
        {
            return KelimeOyunuDBContext.SevenWords.Where(x => x.SevenWordID == ID)
                .ToList();
        }
    }
}
