using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public Skill TGetByID(int id)
        {
            return _skillDal.GetByID(id);
        }

        public void TAdd(Skill entity)
        {
            _skillDal.Insert(entity);
        }

        public void TDelete(Skill entity)
        {
            _skillDal.Delete(entity);
        }

        public List<Skill> TGetList()
        {
            return _skillDal.GetList();
        }

        public void TUpdate(Skill entity)
        {
            _skillDal.Update(entity);
        }
    }
}
