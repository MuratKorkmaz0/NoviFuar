using System.Collections.Generic;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstrack
{
	public interface IVisitorServices
	{
		void AddVisitor(Visitors visitor);

		void DeleteVisitor(Visitors visitor);

		void UpdateVisitor(Visitors visitor);

		List<Visitors> GetList();

		Visitors GetById(int id);
    }
}
