using System;
using System.Collections.Generic;
using System.Linq;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccesLayer.Repostories
{
    public class VisitorsRepostory : IVisitorDal
    {

        public static void AddVisitors(Visitors visitors)
        {
            using var c = new Context();
            c.Add(visitors);
            c.SaveChanges();
        }

        public void Delete(Visitors t)
        {
            throw new NotImplementedException();
        }

        public static void DeleteVisitors(Visitors visitors)
        {
            using var c = new Context();
            c.Remove(visitors);
            c.SaveChanges();
        }

        public Visitors GetById(int id)
        {
            using var c = new Context();
            return c.Visitors.Find(id);
        }

        public List<Visitors> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(Visitors t)
        {
            throw new NotImplementedException();
        }

        public List<Visitors> ListAllVisitor()
        {
            using var c = new Context();
            return c.Visitors.ToList();
        }

        public void Update(Visitors t)
        {
            throw new NotImplementedException();
        }

        public static void UpdateVisitors(Visitors visitors)
        {
            using var c = new Context();
            c.Add(visitors);
            c.SaveChanges();
        }
    }
}

