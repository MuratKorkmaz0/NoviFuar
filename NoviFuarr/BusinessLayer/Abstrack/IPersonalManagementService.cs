using System;
using System.Collections.Generic;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstrack
{
	public interface IPersonalManagementService
	{
		void AddPersonal(PersonalManagement personal);

		void DeletePersonal(PersonalManagement personal);

		void UpdatePersonal(PersonalManagement personal);

		List<PersonalManagement> GetList();

		PersonalManagement GetById(int id);
	}
}

