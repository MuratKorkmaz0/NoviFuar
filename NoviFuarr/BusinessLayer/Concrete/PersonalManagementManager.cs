using System;
using System.Collections.Generic;
using BusinessLayer.Abstrack;
using DataAccesLayer.Abstract;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class PersonalManagementManager : IPersonalManagementService
    {

        IPersonalManagementDal _personalDal;

        public PersonalManagementManager(IPersonalManagementDal personalDal)
        {
            _personalDal = personalDal;
        }

        public void AddPersonal(PersonalManagement personal)
        {
            _personalDal.Insert(personal);
        }

        public void DeletePersonal(PersonalManagement personal)
        {
            _personalDal.Delete(personal);
        }

        public PersonalManagement GetById(int id)
        {
            return _personalDal.GetById(id);
        }

        public List<PersonalManagement> GetList()
        {
            return _personalDal.GetList();
        }

        public void UpdatePersonal(PersonalManagement personal)
        {
            _personalDal.Update(personal);
        }
    }
}

