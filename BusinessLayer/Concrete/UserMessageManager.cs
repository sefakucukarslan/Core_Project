using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageDal _userMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }

        public List<UserMessage> GetUserMessagesWithUserService()
        {
            return _userMessageDal.GetUserMessagesWithUser();
        }

        public void TAdd(UserMessage entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(UserMessage entity)
        {
            throw new NotImplementedException();
        }

        public UserMessage TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> TGetList()
        {
            return _userMessageDal.GetList();
        }

        public List<UserMessage> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(UserMessage entity)
        {
            throw new NotImplementedException();
        }
    }
}
