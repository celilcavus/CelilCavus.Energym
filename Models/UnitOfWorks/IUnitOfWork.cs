using CelilCavus.Energym.Models.Database.Entitys;
using CelilCavus.Energym.Models.Interface;

namespace CelilCavus.Energym.Models.UnitOfWorks
{
    public interface IUnitOfWork
    {
        void SaveChanges();
        IRepository<T> GetRepository<T>() where T : BaseEntity;
    }
}
