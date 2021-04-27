using System;
using System.Collections.Generic;
using System.Text;
using static DataAccesLayer.IRepository;

namespace DataAccesLayer
{
    public interface IUnitOfWork<T> : IDisposable where T : class
    {
        IRepository<T> Repository { get; }
        IRepositoryFour<T> RepositoryFour { get; }
        IRepositoryFive<T> RepositoryFive { get; }
        IRepositorySix<T> RepositorySix { get; }
        IRepositorySeven<T> RepositorySeven { get; }
        IRepositoryEight<T> RepositoryEight { get; }
        IRepositoryNine<T> RepositoryNine { get; }
        IRepositoryTen<T> RepositoryTen { get; }
        IRepositoryUser<T> RepositoryUser { get; }
        IRepositoryUserRole<T> RepositoryUserRole { get; }
        IRepositoryScoreTable<T> RepositoryScoreTable { get; }
        IRepositoryGameVariant<T> RepositoryGameVariant { get; }
        int Complete();//Save Changes
    }
}