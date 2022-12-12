using ProjectModels;
using ProjectWebApp.Data.Repository;

namespace ProjectWebApp.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<Artikel> ArtikelRepository { get; }
        Task Save();
    }
}
