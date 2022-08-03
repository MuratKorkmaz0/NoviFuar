using System;
using System.Collections.Generic;
using BusinessLayer.Abstrack;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class VisitorManager : IVisitorServices
    {
        IVisitorDal _visitorDal;

        public VisitorManager(IVisitorDal visitorDal)
        {
            _visitorDal = visitorDal;
        }

        public void AddVisitor(Visitors visitor)
        {
            _visitorDal.Insert(visitor);
        }

        public void DeleteVisitor(Visitors visitor)
        {
            _visitorDal.Delete(visitor);
        }

        public Visitors GetById(int id)
        {
            return _visitorDal.GetById(id);
        }

        public List<Visitors> GetList()
        {
            return _visitorDal.GetList();
        }

        public void UpdateVisitor(Visitors visitor)
        {
            _visitorDal.Update(visitor);
        }
    }
}
