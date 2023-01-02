using ProjectModels;
using ProjectWebApp.Data.Repository;

namespace ProjectWebApp.Data.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ProjectDBContext _context;
        private IGenericRepository<Artikel> artikelRepository;
        public UnitOfWork(ProjectDBContext context)
        {
            _context = context;
        }
        public IGenericRepository<Artikel> ArtikelRepository
        {
            get 
            {
                if (artikelRepository == null)
                {
                    this.artikelRepository = new GenericRepository<Artikel>(_context);
                }
                return artikelRepository;
            }
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
