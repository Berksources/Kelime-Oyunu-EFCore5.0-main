using Entity.KelimeOyunu;
using System;
using System.Collections.Generic;
using System.Text;
using static DataAccesLayer.IRepository;

namespace DataAccesLayer
{
    public interface IRepositoryTen<T> : IRepository<TenWord> { }
    public class RepositoryTen<T>:Repository<TenWord>,IRepositoryTen<T>
    {
        public RepositoryTen(KelimeOyunuDBContext context) : base(context) { }
    }
}
