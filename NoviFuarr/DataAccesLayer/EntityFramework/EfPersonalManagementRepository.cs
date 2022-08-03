using System;
using DataAccesLayer.Abstract;
using DataAccesLayer.Repostories;
using EntityLayer.Concrete;

namespace DataAccesLayer.EntityFramework
{
	public class EfPersonalManagementRepository :GenericRepostory<PersonalManagement>, IPersonalManagementDal
	{

	}
}

