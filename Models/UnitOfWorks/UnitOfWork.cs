using CelilCavus.Energym.Models.Database.Contexts;
using CelilCavus.Energym.Models.Database.Entitys;
using CelilCavus.Energym.Models.Interface;
using CelilCavus.Energym.Models.Repository;

namespace CelilCavus.Energym.Models.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmergymContext _context;

        public UnitOfWork(EmergymContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new GenericRepository<T>(_context);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}