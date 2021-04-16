using System;
using DataAccesLayer;
using Entity.KelimeOyunu;
using static DataAccesLayer.IRepository;

namespace BusinessLayer
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly KelimeOyunuDBContext _context;

        public UnitOfWork(KelimeOyunuDBContext context)
        {
            _context = context;
            Repository = new Repository<T>(_context);
            RepositoryFour = new RepositoryFour<T>(_context);
            RepositoryFive = new RepositoryFive<T>(_context);
            RepositorySix = new RepositorySix<T>(_context);
            RepositorySeven = new RepositorySeven<T>(_context);
            RepositoryEight = new RepositoryEight<T>(_context);
            RepositoryNine = new RepositoryNine<T>(_context);
            RepositoryTen = new RepositoryTen<T>(_context);
            RepositoryUser = new RepositoryUser<T>(_context);
            RepositoryUserRole = new RepositoryUserRole<T>(_context);
            RepositoryScoreTable = new RepositoryScoreTable<T>(_context);

        }
        public IRepository<T> Repository { get; private set; }
        public IRepositoryFour<T> RepositoryFour { get; private set; }
        public IRepositoryFive<T> RepositoryFive { get; private set; }
        public IRepositorySix<T> RepositorySix { get; private set; }
        public IRepositorySeven<T> RepositorySeven { get; private set; }
        public IRepositoryEight<T> RepositoryEight { get; private set; }
        public IRepositoryNine<T> RepositoryNine { get; private set; }
        public IRepositoryTen<T> RepositoryTen { get; private set; }
        public IRepositoryUser<T> RepositoryUser { get; private set; }
        public IRepositoryUserRole<T> RepositoryUserRole { get; private set; }
        public IRepositoryScoreTable<T> RepositoryScoreTable { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}