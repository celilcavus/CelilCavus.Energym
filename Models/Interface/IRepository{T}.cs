using CelilCavus.Energym.Models.Database.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CelilCavus.Energym.Models.Interface
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Add(T item);
        //void Update(T item);
        void Delete(T item);

        T GetById(int id);

        List<T> GetListDesc();
        List<T> GetListAsc();
    }
}