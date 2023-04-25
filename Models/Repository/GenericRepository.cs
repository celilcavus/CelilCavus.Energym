using CelilCavus.Energym.Models.Database.Contexts;
using CelilCavus.Energym.Models.Database.Entitys;
using CelilCavus.Energym.Models.Interface;
using System.Collections.Generic;
using System.Linq;

namespace CelilCavus.Energym.Models.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly EmergymContext _context;
        public GenericRepository(EmergymContext context)
        {
            _context = context;
        }
        public void Add(T item)
        {
            _context.Set<T>().Add(item);
        }

        public void Delete(T item)
        {
            _context.Set<T>().Remove(item);
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetListAsc()
        {
            return _context.Set<T>().AsNoTracking().OrderBy(x => x.Id).ToList();
        }

        public List<T> GetListDesc()
        {
            return _context.Set<T>().AsNoTracking().OrderByDescending(x => x.Id).ToList();
        }
    }
}