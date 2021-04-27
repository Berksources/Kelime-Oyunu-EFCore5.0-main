using Entity.KelimeOyunu;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DataAccesLayer.IRepository;

namespace DataAccesLayer
{
    public interface IRepositoryScoreTable<T>:IRepository<ScoreTable>
    {
        IEnumerable<ScoreTable> ScoreTablesWithUser();
        IEnumerable<ScoreTable> UserScoreResult(int ID);
    }
    public class RepositoryScoreTable<T>:Repository<ScoreTable>,IRepositoryScoreTable<T>
    {
        public RepositoryScoreTable(KelimeOyunuDBContext context) : base(context) { }

        public IEnumerable<ScoreTable> ScoreTablesWithUser()
        {
            return KelimeOyunuDBContext.ScoreTables
                .Include(x => x.User)
                .AsNoTracking().ToList();
        }

        public IEnumerable<ScoreTable> UserScoreResult(int ID)
        {
            return KelimeOyunuDBContext.ScoreTables.Where(x => x.UserID==ID)
                .ToList();
        }
    }
}
