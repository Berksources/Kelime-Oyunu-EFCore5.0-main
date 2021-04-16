using Entity.KelimeOyunu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DataAccesLayer.IRepository;

namespace DataAccesLayer
{
    public interface IRepositorySix<T> : IRepository<SixthWord>
    {
        IEnumerable<SixthWord> GetSixWordByID(int ID);
    }
    public class RepositorySix<T> : Repository<SixthWord>, IRepositorySix<T>
    {
        public RepositorySix(KelimeOyunuDBContext context) : base(context) { }

        public IEnumerable<SixthWord> GetSixWordByID(int ID)
        {
            return KelimeOyunuDBContext.SixthWords.Where(x => x.SixthWordID == ID)
                .ToList();
        }
    }
}
