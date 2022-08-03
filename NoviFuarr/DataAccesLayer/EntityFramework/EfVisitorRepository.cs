using DataAccesLayer.Abstract;
using DataAccesLayer.Repostories;
using EntityLayer.Concrete;

namespace DataAccesLayer.EntityFramework
{
    public class EfVisitorRepository : GenericRepostory<Visitors>, IVisitorDal
	{

	}
}

