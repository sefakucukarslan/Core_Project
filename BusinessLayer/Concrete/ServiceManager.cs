using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public Service GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public void TAdd(Service entity)
        {
            throw new System.NotImplementedException();
        }

        public void TDelete(Service entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public void TUpdate(Service entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
