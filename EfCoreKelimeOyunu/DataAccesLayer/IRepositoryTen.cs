using Entity.KelimeOyunu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DataAccesLayer.IRepository;

namespace DataAccesLayer
{
    public interface IRepositoryTen<T> : IRepository<TenWord> 
    {
        IEnumerable<TenWord> GetTenWordByID(int ID);
    }
    public class RepositoryTen<T>:Repository<TenWord>,IRepositoryTen<T>
    {
        public RepositoryTen(KelimeOyunuDBContext context) : base(context) { }

        public IEnumerable<TenWord> GetTenWordByID(int ID)
        {
            return KelimeOyunuDBContext.TenWords.Where(x => x.TenWordID == ID)
                .ToList();
        }
    }
}
