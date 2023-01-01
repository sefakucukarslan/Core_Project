using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public Portfolio TGetByID(int id)
        {
            return _portfolioDal.GetByID(id);
        }

        public void TAdd(Portfolio entity)
        {
            _portfolioDal.Insert(entity);
        }

        public void TDelete(Portfolio entity)
        {
            _portfolioDal.Delete(entity);
        }

        public List<Portfolio> TGetList()
        {
            return _portfolioDal.GetList();
        }

        public void TUpdate(Portfolio entity)
        {
            _portfolioDal.Update(entity);
        }
    }
}
