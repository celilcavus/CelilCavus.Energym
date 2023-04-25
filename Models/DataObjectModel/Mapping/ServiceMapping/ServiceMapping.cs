using CelilCavus.Energym.Models.Database.Contexts;
using CelilCavus.Energym.Models.Database.Entitys;
using CelilCavus.Energym.Models.DataObjectModel.ServiceDto;
using CelilCavus.Energym.Models.UnitOfWorks;
using System.Linq;


namespace CelilCavus.Energym.Models.DataObjectModel.Mapping.ServiceMapping
{
    public class ServiceMapping
    {
        private readonly UnitOfWork _work;

        public ServiceMapping()
        {
            _work = new UnitOfWork(new EmergymContext());
        }

        public IQueryable<ServiceDtoList> GetServiceDtoListsAsc()
        {
            var serviceDto = from i in _work.GetRepository<Services>().GetListAsc()
                             select new ServiceDtoList
                             {
                                 ServiesTitle = i.ServiesTitle,
                                 ServiesImage = i.ServiesImage
                             };
            return serviceDto.AsQueryable();
        }
        public IQueryable<ServiceDtoList> GetServiceDtoListsDesc()
        {
            var serviceDto = from i in _work.GetRepository<Services>().GetListDesc()
                             select new ServiceDtoList
                             {
                                 ServiesTitle = i.ServiesTitle,
                                 ServiesImage = i.ServiesImage
                             };
            return serviceDto.AsQueryable();
        }
    }
}