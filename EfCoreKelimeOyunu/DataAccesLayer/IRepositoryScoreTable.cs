using Entity.KelimeOyunu;
using System;
using System.Collections.Generic;
using System.Text;
using static DataAccesLayer.IRepository;

namespace DataAccesLayer
{
    public interface IRepositoryScoreTable<T>:IRepository<ScoreTable>{}
    public class RepositoryScoreTable<T>:Repository<ScoreTable>,IRepositoryScoreTable<T>
    {
        public RepositoryScoreTable(KelimeOyunuDBContext context) : base(context) { }
    }
}
