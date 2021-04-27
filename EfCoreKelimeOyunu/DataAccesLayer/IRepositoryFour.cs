using Entity.KelimeOyunu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DataAccesLayer.IRepository;

namespace DataAccesLayer
{
   public interface IRepositoryFour<T>:IRepository<FourWord>
    {
        IEnumerable<FourWord> GetFourWordByID(int ID);
        IEnumerable<FourWord> GetAnyQuestion();
    }
    public class RepositoryFour<T> : Repository<FourWord>, IRepositoryFour<T>
    {
        public RepositoryFour(KelimeOyunuDBContext context) : base(context) {}

        public IEnumerable<FourWord> GetAnyQuestion()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 21);
            return KelimeOyunuDBContext.FourWords.ElementAt(num).ToList();
        }
        public IEnumerable<FourWord> GetFourWordByID(int ID)
        {
            return KelimeOyunuDBContext.FourWords.Where(x => x.FourWordID == ID)
                .ToList();
        }
    }
}
