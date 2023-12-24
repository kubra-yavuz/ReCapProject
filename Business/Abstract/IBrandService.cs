using System;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IBrandService
	{
        List<Brand> GetAll();
        List<Brand> GetAllByBrandId(int id);
    }
}

