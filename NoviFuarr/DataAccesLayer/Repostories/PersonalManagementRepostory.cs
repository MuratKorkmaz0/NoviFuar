using System.Collections.Generic;
using System.Linq;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccesLayer.Repostories
{
    public class PersonalManagementRepostory : IPersonalManagementDal
    {
        Context c = new Context();

        public void AddPersonal(PersonalManagement personal)
        {
            c.Add(personal);
            c.SaveChanges();
        }

        public void Delete(PersonalManagement t)
        {
            throw new System.NotImplementedException();
        }

        public void DeletePersonal(PersonalManagement personal)
        {
            c.Remove(personal);
            c.SaveChanges();
        }

        public PersonalManagement GetById(int id)
        {
            return c.UserManagements.Find(id);
        }

        public List<PersonalManagement> GetList()
        {
            throw new System.NotImplementedException();
        }

        public void Insert(PersonalManagement t)
        {
            throw new System.NotImplementedException();
        }

        public List<PersonalManagement> ListAllPersonalManagement()
        {
            return c.UserManagements.ToList();
        }

        public void Update(PersonalManagement t)
        {
            throw new System.NotImplementedException();
        }

        public void UpdatePersonal(PersonalManagement personal)
        {
            c.Update(personal);
            c.SaveChanges();
        }
    }
}

