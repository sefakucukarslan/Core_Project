using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public Contact GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Contact entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Contact entity)
        {
            throw new NotImplementedException();
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public void TUpdate(Contact entity)
        {
            throw new NotImplementedException();
        }
    }
}
