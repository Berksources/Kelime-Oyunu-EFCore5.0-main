using Entity.KelimeOyunu;
using System;
using System.Collections.Generic;
using System.Text;
using static DataAccesLayer.IRepository;

namespace DataAccesLayer
{
    public interface IRepositoryGameVariant<T> : IRepository<GameVariant> { }
    public class RepositoryGameVariant<T> : Repository<GameVariant>, IRepositoryGameVariant<T>
    {
        public RepositoryGameVariant(KelimeOyunuDBContext context) : base(context) { }
    }
}
